using System;
using System.IO;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Linq.Expressions;
using G = Library.Network.GeneralPackets;


//TODO Dispose ?
namespace Library.Network
{
    public abstract class BaseConnection
    {
        public static Dictionary<string, DiagnosticValue> Diagnostics = new Dictionary<string, DiagnosticValue>();
        public static Dictionary<Type, Action<BaseConnection, Packet>> PacketMethods = new Dictionary<Type, Action<BaseConnection, Packet>>();
        public static bool Monitor;

        public bool Connected { get; set; }
        protected bool Sending { get; set; }

        public int TotalBytesSent { get; set; }
        public int TotalBytesReceived { get; set; }

        public bool AdditionalLogging { get; private set; } = true;

        protected TcpClient Client;

        public DateTime TimeConnected { get; set; }
        public TimeSpan Duration => Time.Now - TimeConnected;

        protected abstract TimeSpan TimeOutDelay { get; }
        public DateTime TimeOutTime { get; set; }

        private bool _disconnecting;
        public bool Disconnecting
        {
            get { return _disconnecting; }
            set
            {
                if (_disconnecting == value) return;
                _disconnecting = value;
                TimeOutTime = Time.Now.AddSeconds(2);
            }
        }

        protected ConcurrentQueue<Packet> ReceiveList { get; private set; } = new ConcurrentQueue<Packet>();
        protected ConcurrentQueue<Packet> SendList { get; private set; } = new ConcurrentQueue<Packet>();
        private byte[] _rawData = new byte[0];

        public EventHandler<Exception> OnException { get; set; }

        protected BaseConnection(TcpClient client)
        {
            Client = client;
            Client.NoDelay = true;


            Connected = true;
            TimeConnected = Time.Now;
        }

        protected void BeginReceive()
        {
            try
            {
                if (Client == null || !Client.Connected) return;

                byte[] rawBytes = new byte[8 * 1024];

                Client.Client.BeginReceive(rawBytes, 0, rawBytes.Length, SocketFlags.None, ReceiveData, rawBytes);
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
                Disconnecting = true;
            }
        }
        private void ReceiveData(IAsyncResult result)
        {
            try
            {
                if (!Connected) return;

                int dataRead = Client.Client.EndReceive(result);

                if (dataRead == 0)
                {
                    Disconnecting = true;
                    return;
                }
                TotalBytesReceived += dataRead;

                UpdateTimeOut();

                byte[] rawBytes = result.AsyncState as byte[];

                byte[] temp = _rawData;
                _rawData = new byte[dataRead + temp.Length];
                Buffer.BlockCopy(temp, 0, _rawData, 0, temp.Length);
                Buffer.BlockCopy(rawBytes, 0, _rawData, temp.Length, dataRead);

                Packet p;

                while ((p = Packet.ReceivePacket(_rawData, out _rawData)) != null)
                    ReceiveList.Enqueue(p);

                BeginReceive();
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
                Disconnecting = true;
            }
        }
        private void BeginSend(byte[] data, int length)
        {
            if (!Connected || length == 0) return;

            try
            {
                Sending = true;
                TotalBytesSent += length;
                Client.Client.BeginSend(data, 0, length, SocketFlags.None, SendData, null);
                UpdateTimeOut();
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
                Disconnecting = true;
                Sending = false;
            }
        }
        private void SendData(IAsyncResult result)
        {
            try
            {
                Sending = false;
                Client.Client.EndSend(result);
                UpdateTimeOut();
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
                Disconnecting = true;
            }
        }
        public virtual void Enqueue(Packet p)
        {
            if (!Connected || p == null) return;

            SendList.Enqueue(p);
        }

        public abstract void TryDisconnect();

        public virtual void Disconnect()
        {
            if (!Connected) return;

            Connected = false;

            SendList = null;
            ReceiveList = null;
            _rawData = null;

            Client.Client.Dispose();
            Client = null;
        }

        public abstract void TrySendDisconnect(Packet p);

        public virtual void SendDisconnect(Packet p)
        {
            if (!Connected || Disconnecting)
            {
                Disconnecting = true;
                return;
            }

            List<byte> data = new List<byte>();

            data.AddRange(p.GetPacketBytes());

            BeginSendDisconnect(data);
        }
        private void BeginSendDisconnect(List<byte> data)
        {
            if (!Connected || data.Count == 0) return;

            if (Disconnecting) return;

            try
            {
                Disconnecting = true;

                TotalBytesSent += data.Count;
                Client.Client.BeginSend(data.ToArray(), 0, data.Count, SocketFlags.None, SendDataDisconnect, null);
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
            }
        }
        private void SendDataDisconnect(IAsyncResult result)
        {

            try
            {
                Client.Client.EndSend(result);
            }
            catch (Exception ex)
            {
                if (AdditionalLogging)
                    OnException(this, ex);
            }
        }

        public virtual void Process()
        {
            if (Client == null || !Client.Connected)
            {
                TryDisconnect();
                return;
            }

            while (!ReceiveList.IsEmpty && !Disconnecting)
            {
                try
                {
                    Packet p;
                    if (!ReceiveList.TryDequeue(out p)) continue;

                    ProcessPacket(p);
                }
                catch (NotImplementedException ex)
                {
                    OnException(this, ex);
                }
                catch (Exception ex)
                {
                    OnException(this, ex);
                    throw ex;
                }
            }

            if (Time.Now >= TimeOutTime)
            {
                if (!Disconnecting)
                    TrySendDisconnect(new G.Disconnect { Reason = DisconnectReason.TimedOut });
                else
                    TryDisconnect();

                return;
            }

            if (!Disconnecting && Sending)
                UpdateTimeOut();

            if (SendList.IsEmpty || Sending) return;

            MemoryStream data = new MemoryStream(8192);
            while (!SendList.IsEmpty)
            {
                Packet p;

                if (!SendList.TryDequeue(out p)) continue;

                if (p == null) continue;

                try
                {
                    byte[] bytes = p.GetPacketBytes();

                    data.Write(bytes, 0, bytes.Length);
                }
                catch (Exception ex)
                {
                    OnException?.Invoke(this, ex);
                    Disconnecting = true;
                    return;
                }


                if (!Monitor) continue;
                
                DiagnosticValue value;
                Type type = p.GetType();

                if (!Diagnostics.TryGetValue(type.FullName, out value))
                    Diagnostics[type.FullName] = value = new DiagnosticValue { Name = type.FullName };

                value.Count++;
                value.TotalSize += p.Length;
                
                if (p.Length > value.LargestSize)
                    value.LargestSize = p.Length;
            }

            BeginSend(data.GetBuffer(), (int)data.Length);
        }

        private void ProcessPacket(Packet p)
        {
            if (p == null) return;

            DateTime start = Time.Now;
            
            Action<BaseConnection, Packet> handler;
            if (!PacketMethods.TryGetValue(p.PacketType, out handler))
            {
                MethodInfo info = GetType().GetMethod("Process", new[] { p.PacketType });
                if (info == null)
                    throw new NotImplementedException($"Not Implemented Exception: Method Process({p.PacketType}).");

                ParameterExpression connParam = Expression.Parameter(typeof(BaseConnection), "conn");
                ParameterExpression packetParam = Expression.Parameter(typeof(Packet), "p");
                MethodCallExpression call = Expression.Call(
                    Expression.Convert(connParam, info.DeclaringType),
                    info,
                    Expression.Convert(packetParam, p.PacketType));
                handler = Expression.Lambda<Action<BaseConnection, Packet>>(call, connParam, packetParam).Compile();
                PacketMethods[p.PacketType] = handler;
            }

            try { handler(this, p); }
            catch(Exception e)
            {
                if (AdditionalLogging)
                    OnException(this, e);

                //Disconnecting = true;
            }
            

            if (!Monitor) return;

            TimeSpan execution = Time.Now - start;
            DiagnosticValue value;

            if (!Diagnostics.TryGetValue(p.PacketType.FullName, out value))
                Diagnostics[p.PacketType.FullName] = value = new DiagnosticValue { Name = p.PacketType.FullName };

            value.Count++;
            value.TotalTime += execution;
            value.TotalSize += p.Length;

            if (execution > value.LargestTime)
                value.LargestTime = execution;

            if (p.Length > value.LargestSize)
                value.LargestSize = p.Length;


        }
        public void UpdateTimeOut()
        {
            if (Disconnecting) return;

            TimeOutTime = Time.Now + TimeOutDelay;
        }
    }


    public class DiagnosticValue
    {
        public string Name { get; set; }
        public TimeSpan TotalTime { get; set; }
        public TimeSpan LargestTime { get; set; }
        public int Count { get; set; }
        public long TotalSize { get; set; }
        public long LargestSize { get; set; }

        public long TotalTicks => TotalTime.Ticks;
        public long TotalMilliseconds => TotalTicks / TimeSpan.TicksPerMillisecond;

        public long LargestTicks => LargestTime.Ticks;
        public long LargestMilliseconds => LargestTicks / TimeSpan.TicksPerMillisecond;
    }
}
