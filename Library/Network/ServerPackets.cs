using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Library.SystemModels;

namespace Library.Network.ServerPackets
{
    [PacketMark(2001)]
    public sealed class NewAccount : Packet
    {
        public NewAccountResult Result { get; set; }
    }

    [PacketMark(2002)]
    public sealed class ChangePassword : Packet
    {
        public ChangePasswordResult Result { get; set; }

        public string Message { get; set; }
        public TimeSpan Duration { get; set; }
    }

    [PacketMark(2003)]
    public sealed class Login : Packet
    {
        public LoginResult Result { get; set; }

        public string Message { get; set; }
        public TimeSpan Duration { get; set; }

        public List<SelectInfo> Characters { get; set; }
        public List<ClientUserItem> Items { get; set; }

        public List<ClientBlockInfo> BlockList { get; set; }

        public string Address { get; set; }

        public bool TestServer { get; set; }
    }

    [PacketMark(2004)]
    public sealed class RequestPasswordReset : Packet
    {
        public RequestPasswordResetResult Result { get; set; }
        public string Message { get; set; }
        public TimeSpan Duration { get; set; }
    }

    [PacketMark(2005)]
    public sealed class ResetPassword : Packet
    {
        public ResetPasswordResult Result { get; set; }
    }

    [PacketMark(2006)]
    public sealed class Activation : Packet
    {
        public ActivationResult Result { get; set; }
    }

    [PacketMark(2007)]
    public sealed class RequestActivationKey : Packet
    {
        public RequestActivationKeyResult Result { get; set; }
        public TimeSpan Duration { get; set; }
    }

    [PacketMark(2008)]
    public sealed class SelectLogout : Packet
    {
    }

    [PacketMark(2009)]
    public sealed class GameLogout : Packet
    {
        public List<SelectInfo> Characters { get; set; }
    }

    [PacketMark(2010)]
    public sealed class NewCharacter : Packet
    {
        public NewCharacterResult Result { get; set; }

        public SelectInfo Character { get; set; }
    }

    [PacketMark(2011)]
    public sealed class DeleteCharacter : Packet
    {
        public DeleteCharacterResult Result { get; set; }

        public int DeletedIndex { get; set; }
    }

    [PacketMark(2012)]
    public sealed class StartGame : Packet
    {
        public StartGameResult Result { get; set; }

        public string Message { get; set; }
        public TimeSpan Duration { get; set; }

        public StartInformation StartInformation { get; set; }
    }

    [PacketMark(2013)]
    public sealed class MapChanged : Packet
    {
        public int MapIndex { get; set; }
    }

    [PacketMark(2014)]
    public sealed class UserLocation : Packet
    {
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2015)]
    public sealed class ObjectRemove : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(2016)]
    public sealed class ObjectTurn : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public TimeSpan Slow { get; set; }
    }

    [PacketMark(2017)]
    public sealed class ObjectHarvest : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public TimeSpan Slow { get; set; }
    }

    [PacketMark(2018)]
    public sealed class ObjectMount : Packet
    {
        public uint ObjectID { get; set; }
        public HorseType Horse { get; set; }
    }

    [PacketMark(2019)]
    public sealed class ObjectMove : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public int Distance { get; set; }
        public TimeSpan Slow { get; set; }
    }

    [PacketMark(2020)]
    public sealed class ObjectDash : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public int Distance { get; set; }
        public MagicType Magic { get; set; }
    }

    [PacketMark(2021)]
    public sealed class ObjectPushed : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2022)]
    public sealed class ObjectAttack : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }

        public MagicType AttackMagic { get; set; }
        public Element AttackElement { get; set; }

        public uint TargetID { get; set; }

        public TimeSpan Slow { get; set; }
    }

    [PacketMark(2023)]
    public sealed class ObjectRangeAttack : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }

        public MagicType AttackMagic { get; set; }
        public Element AttackElement { get; set; }

        public List<uint> Targets { get; set; } = new List<uint>();
    }

    [PacketMark(2024)]
    public sealed class ObjectMagic : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point CurrentLocation { get; set; }

        public MagicType Type { get; set; }
        public List<uint> Targets { get; set; } = new List<uint>();
        public List<Point> Locations { get; set; } = new List<Point>();
        public bool Cast { get; set; }

        public TimeSpan Slow { get; set; }
    }

    [PacketMark(2025)]
    public sealed class ObjectMining : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }

        public TimeSpan Slow { get; set; }
        public bool Effect { get; set; }
    }

    [PacketMark(2026)]
    public sealed class ObjectPetOwnerChanged : Packet
    {
        public uint ObjectID { get; set; }
        public string PetOwner { get; set; }
    }

    [PacketMark(2027)]
    public sealed class ObjectShow : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2028)]
    public sealed class ObjectHide : Packet
    {
        public uint ObjectID { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2029)]
    public sealed class ObjectEffect : Packet
    {
        public uint ObjectID { get; set; }

        public Effect Effect { get; set; }
    }

    [PacketMark(2030)]
    public sealed class MapEffect : Packet
    {
        public Point Location { get; set; }
        public Effect Effect { get; set; }
        public MirDirection Direction { get; set; }
    }

    [PacketMark(2031)]
    public sealed class ObjectBuffAdd : Packet
    {
        public uint ObjectID { get; set; }
        public BuffType Type { get; set; }
    }

    [PacketMark(2032)]
    public sealed class ObjectBuffRemove : Packet
    {
        public uint ObjectID { get; set; }
        public BuffType Type { get; set; }
    }

    [PacketMark(2033)]
    public sealed class ObjectPoison : Packet
    {
        public uint ObjectID { get; set; }
        public PoisonType Poison { get; set; }
    }

    [PacketMark(2034)]
    public sealed class ObjectPlayer : Packet
    {
        public int Index { get; set; }

        public uint ObjectID { get; set; }
        public string Name { get; set; }
        public Color NameColour { get; set; }
        public string GuildName { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }

        public MirClass Class { get; set; }
        public MirGender Gender { get; set; }

        public int HairType { get; set; }
        public Color HairColour { get; set; }
        public int Weapon { get; set; }
        public int Shield { get; set; }
        public int Armour { get; set; }
        public Color ArmourColour { get; set; }
        public int ArmourImage { get; set; }

        public int Light { get; set; }

        public bool Dead { get; set; }
        public PoisonType Poison { get; set; }

        public List<BuffType> Buffs { get; set; }

        public HorseType Horse { get; set; }

        public int Helmet { get; set; }

        public int HorseShape { get; set; }
    }

    [PacketMark(2035)]
    public sealed class ObjectMonster : Packet
    {
        public uint ObjectID { get; set; }
        public int MonsterIndex { get; set; }
        public Color NameColour { get; set; }
        public string PetOwner { get; set; }

        public MirDirection Direction { get; set; }
        public Point Location { get; set; }

        public bool Dead { get; set; }
        public bool Skeleton { get; set; }

        public PoisonType Poison { get; set; }

        public bool EasterEvent { get; set; }
        public bool HalloweenEvent { get; set; }
        public bool ChristmasEvent { get; set; }

        public List<BuffType> Buffs { get; set; }
        public bool Extra { get; set; }

        public ClientCompanionObject CompanionObject { get; set; }

        //public bool Extra { get; set; }
        //public int ExtraInt { get; set; }

    }

    [PacketMark(2036)]
    public sealed class ObjectNPC : Packet
    {
        public uint ObjectID { get; set; }

        public int NPCIndex { get; set; }
        public Point CurrentLocation { get; set; }

        public MirDirection Direction { get; set; }
    }

    [PacketMark(2037)]
    public sealed class ObjectItem : Packet
    {
        public uint ObjectID { get; set; }

        public ClientUserItem Item { get; set; }

        public Point Location { get; set; }
    }

    [PacketMark(2038)]
    public sealed class ObjectSpell : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public SpellEffect Effect { get; set; }
        public int Power { get; set; }

    }

    [PacketMark(2039)]
    public sealed class ObjectSpellChanged : Packet
    {
        public uint ObjectID { get; set; }
        public int Power { get; set; }
    }

    [PacketMark(2040)]
    public sealed class ObjectNameColour : Packet
    {
        public uint ObjectID { get; set; }
        public Color Colour { get; set; }
    }

    [PacketMark(2041)]
    public sealed class PlayerUpdate : Packet
    {
        public uint ObjectID { get; set; }
        public int Weapon { get; set; }
        public int Shield { get; set; }
        public int Armour { get; set; }
        public Color ArmourColour { get; set; }
        public int ArmourImage { get; set; }

        public int HorseArmour { get; set; }
        public int Helmet { get; set; }

        public int Light { get; set; }
    }

    [PacketMark(2042)]
    public sealed class MagicToggle : Packet
    {
        public MagicType Magic { get; set; }
        public bool CanUse { get; set; }
    }

    [PacketMark(2043)]
    public sealed class DayChanged : Packet
    {
        public float DayTime { get; set; }
    }

    [PacketMark(2044)]
    public sealed class LevelChanged : Packet
    {
        public int Level { get; set; }
        public decimal Experience { get; set; }
    }

    [PacketMark(2045)]
    public sealed class ObjectLeveled : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(2046)]
    public sealed class ObjectRevive : Packet
    {
        public uint ObjectID { get; set; }
        public Point Location { get; set; }
        public bool Effect { get; set; }
    }

    [PacketMark(2047)]
    public sealed class GainedExperience : Packet
    {
        public decimal Amount { get; set; }
    }

    [PacketMark(2048)]
    public sealed class NewMagic : Packet
    {
        public ClientUserMagic Magic { get; set; }
    }

    [PacketMark(2049)]
    public sealed class MagicLeveled : Packet
    {
        public int InfoIndex { get; set; }
        public MagicInfo Info;
        public int Level { get; set; }
        public long Experience { get; set; }

        [CompleteObject]
        public void Complete()
        {
            Info = Globals.MagicInfoList.Binding.FirstOrDefault(x => x.Index == InfoIndex);
        }
    }

    [PacketMark(2050)]
    public sealed class MagicCooldown : Packet
    {
        public int InfoIndex { get; set; }
        public int Delay { get; set; }
        public MagicInfo Info;

        [CompleteObject]
        public void Complete()
        {
            Info = Globals.MagicInfoList.Binding.FirstOrDefault(x => x.Index == InfoIndex);
        }
    }

    [PacketMark(2051)]
    public sealed class StatsUpdate : Packet
    {
        public Stats Stats { get; set; }
        public Stats HermitStats { get; set; }
        public int HermitPoints { get; set; }
    }

    [PacketMark(2052)]
    public sealed class HealthChanged : Packet
    {
        public uint ObjectID { get; set; }
        public int Change { get; set; }
        public bool Miss { get; set; }
        public bool Block { get; set; }
        public bool Critical { get; set; }
    }

    [PacketMark(2053)]
    public sealed class ObjectStats : Packet
    {
        public uint ObjectID { get; set; }
        public Stats Stats { get; set; }
    }

    [PacketMark(2054)]
    public sealed class ManaChanged : Packet
    {
        public uint ObjectID { get; set; }
        public int Change { get; set; }
    }

    [PacketMark(2055)]
    public sealed class ObjectStruck : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
        public uint AttackerID { get; set; }
        public Element Element { get; set; }
    }

    [PacketMark(2056)]
    public sealed class ObjectDied : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2057)]
    public sealed class ObjectHarvested : Packet
    {
        public uint ObjectID { get; set; }
        public MirDirection Direction { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(2058)]
    public sealed class ItemsGained : Packet
    {
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2059)]
    public sealed class ItemMove : Packet
    {
        public GridType FromGrid { get; set; }
        public GridType ToGrid { get; set; }
        public int FromSlot { get; set; }
        public int ToSlot { get; set; }
        public bool MergeItem { get; set; }

        public bool Success { get; set; }
    }

    [PacketMark(2060)]
    public sealed class ItemSplit : Packet
    {
        public GridType Grid { get; set; }
        public int Slot { get; set; }
        public long Count { get; set; }
        public int NewSlot { get; set; }

        public bool Success { get; set; }
    }

    [PacketMark(2061)]
    public sealed class ItemLock : Packet
    {
        public GridType Grid { get; set; }
        public int Slot { get; set; }
        public bool Locked { get; set; }

    }

    [PacketMark(2062)]
    public sealed class ItemUseDelay : Packet
    {
        public TimeSpan Delay { get; set; }
    }

    [PacketMark(2063)]
    public sealed class ItemChanged : Packet
    {
        public CellLinkInfo Link { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2064)]
    public sealed class ItemStatsChanged : Packet
    {
        public GridType GridType { get; set; }
        public int Slot { get; set; }
        public Stats NewStats { get; set; }
    }

    [PacketMark(2065)]
    public sealed class ItemStatsRefreshed : Packet
    {
        public GridType GridType { get; set; }
        public int Slot { get; set; }
        public Stats NewStats { get; set; }
    }

    [PacketMark(2066)]
    public sealed class ItemDurability : Packet
    {
        public GridType GridType { get; set; }
        public int Slot { get; set; }
        public int CurrentDurability { get; set; }
    }

    [PacketMark(2067)]
    public sealed class GoldChanged : Packet
    {
        public long Gold { get; set; }
    }

    [PacketMark(2068)]
    public sealed class ItemExperience : Packet
    {
        public CellLinkInfo Target { get; set; }
        public decimal Experience { get; set; }
        public int Level { get; set; }
        public UserItemFlags Flags { get; set; }
    }

    [PacketMark(2069)]
    public sealed class Chat : Packet
    {
        public uint ObjectID { get; set; }
        public string Text { get; set; }
        public MessageType Type { get; set; }
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2070)]
    public sealed class NPCResponse : Packet
    {
        public uint ObjectID { get; set; }
        public int Index { get; set; }
        public List<ClientRefineInfo> Extra { get; set; }

        public NPCPage Page;

        [CompleteObject]
        public void Complete()
        {
            Page = Globals.NPCPageList.Binding.FirstOrDefault(x => x.Index == Index);
        }
    }

    [PacketMark(2071)]
    public sealed class ItemsChanged : Packet
    {
        public List<CellLinkInfo> Links { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2072)]
    public sealed class NPCRepair : Packet
    {
        public List<CellLinkInfo> Links { get; set; }
        public bool Special { get; set; }
        public bool Success { get; set; }
        public TimeSpan SpecialRepairDelay { get; set; }
    }

    [PacketMark(2073)]
    public sealed class NPCRefinementStone : Packet
    {
        public List<CellLinkInfo> IronOres { get; set; }
        public List<CellLinkInfo> SilverOres { get; set; }
        public List<CellLinkInfo> DiamondOres { get; set; }
        public List<CellLinkInfo> GoldOres { get; set; }
        public List<CellLinkInfo> Crystal { get; set; }
    }

    [PacketMark(2074)]
    public sealed class NPCRefine : Packet
    {
        public RefineType RefineType { get; set; }
        public RefineQuality RefineQuality { get; set; }
        public List<CellLinkInfo> Ores { get; set; }
        public List<CellLinkInfo> Items { get; set; }
        public List<CellLinkInfo> Specials { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2075)]
    public sealed class NPCMasterRefine : Packet
    {
        public List<CellLinkInfo> Fragment1s { get; set; }
        public List<CellLinkInfo> Fragment2s { get; set; }
        public List<CellLinkInfo> Fragment3s { get; set; }
        public List<CellLinkInfo> Stones { get; set; }
        public List<CellLinkInfo> Specials { get; set; }

        public bool Success { get; set; }
    }

    [PacketMark(2076)]
    public sealed class NPCClose : Packet
    {
    }

    [PacketMark(2077)]
    public sealed class NPCAccessoryLevelUp : Packet
    {
        public CellLinkInfo Target { get; set; }
        public List<CellLinkInfo> Links { get; set; }
    }

    [PacketMark(2078)]
    public sealed class NPCAccessoryUpgrade : Packet
    {
        public CellLinkInfo Target { get; set; }
        public RefineType RefineType { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2079)]
    public sealed class NPCRefineRetrieve : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2080)]
    public sealed class RefineList : Packet
    {
        public List<ClientRefineInfo> List { get; set; }
    }

    [PacketMark(2081)]
    public sealed class GroupSwitch : Packet
    {
        public bool Allow { get; set; }
    }

    [PacketMark(2082)]
    public sealed class GroupMember : Packet
    {
        public uint ObjectID { get; set; }
        public string Name { get; set; }
    }

    [PacketMark(2083)]
    public sealed class GroupRemove : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(2084)]
    public sealed class GroupInvite : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(2085)]
    public sealed class BuffAdd : Packet
    {
        public ClientBuffInfo Buff { get; set; }
    }

    [PacketMark(2086)]
    public sealed class BuffRemove : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2087)]
    public sealed class BuffChanged : Packet
    {
        public int Index { get; set; }
        public Stats Stats { get; set; }
    }

    [PacketMark(2088)]
    public sealed class BuffTime : Packet
    {
        public int Index { get; set; }
        public TimeSpan Time { get; set; }
    }

    [PacketMark(2089)]
    public sealed class BuffPaused : Packet
    {
        public int Index { get; set; }
        public bool Paused { get; set; }
    }

    [PacketMark(2090)]
    public sealed class SafeZoneChanged : Packet
    {
        public bool InSafeZone { get; set; }
    }

    [PacketMark(2091)]
    public sealed class CombatTime : Packet
    {

    }

    [PacketMark(2092)]
    public sealed class Inspect : Packet
    {
        public string Name { get; set; }
        public string GuildName { get; set; }
        public string GuildRank { get; set; }
        public string Partner { get; set; }
        public MirClass Class { get; set; }
        public int Level { get; set; }
        public MirGender Gender { get; set; }
        public Stats Stats { get; set; }
        public Stats HermitStats { get; set; }
        public int HermitPoints { get; set; }
        public List<ClientUserItem> Items { get; set; }
        public int Hair { get; set; }
        public Color HairColour { get; set; }

        public int WearWeight { get; set; }
        public int HandWeight { get; set; }
    }

    [PacketMark(2093)]
    public sealed class Rankings : Packet
    {
        public bool OnlineOnly { get; set; }
        public RequiredClass Class { get; set; }
        public int StartIndex { get; set; }
        public int Total { get; set; }

        public List<RankInfo> Ranks { get; set; }
    }

    [PacketMark(2094)]
    public sealed class StartObserver : Packet
    {
        public StartInformation StartInformation { get; set; }
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2095)]
    public sealed class ObservableSwitch : Packet
    {
        public bool Allow { get; set; }
    }

    [PacketMark(2096)]
    public sealed class MarketPlaceHistory : Packet
    {
        public int Index { get; set; }
        public long SaleCount { get; set; }
        public long LastPrice { get; set; }
        public long AveragePrice { get; set; }
        public int Display { get; set; }
    }

    [PacketMark(2097)]
    public sealed class MarketPlaceConsign : Packet
    {
        public List<ClientMarketPlaceInfo> Consignments { get; set; }
    }

    [PacketMark(2098)]
    public sealed class MarketPlaceSearch : Packet
    {
        public int Count { get; set; }
        public List<ClientMarketPlaceInfo> Results { get; set; }
    }

    [PacketMark(2099)]
    public sealed class MarketPlaceSearchCount : Packet
    {
        public int Count { get; set; }
    }

    [PacketMark(2100)]
    public sealed class MarketPlaceSearchIndex : Packet
    {
        public int Index { get; set; }
        public ClientMarketPlaceInfo Result { get; set; }
    }

    [PacketMark(2101)]
    public sealed class MarketPlaceBuy : Packet
    {
        public int Index { get; set; }
        public long Count { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2102)]
    public sealed class MarketPlaceStoreBuy : Packet
    {
    }

    [PacketMark(2103)]
    public sealed class MarketPlaceConsignChanged : Packet
    {
        public int Index { get; set; }
        public long Count { get; set; }
    }

    [PacketMark(2104)]
    public sealed class MailList : Packet
    {
        public List<ClientMailInfo> Mail { get; set; }
    }

    [PacketMark(2105)]
    public sealed class MailNew : Packet
    {
        public ClientMailInfo Mail { get; set; }
    }

    [PacketMark(2106)]
    public sealed class MailDelete : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2107)]
    public sealed class MailItemDelete : Packet
    {
        public int Index { get; set; }
        public int Slot { get; set; }
    }

    [PacketMark(2108)]
    public sealed class MailSend : Packet
    {
    }

    [PacketMark(2109)]
    public sealed class ChangeAttackMode : Packet
    {
        public AttackMode Mode { get; set; }
    }

    [PacketMark(2110)]
    public sealed class ChangePetMode : Packet
    {
        public PetMode Mode { get; set; }
    }

    [PacketMark(2111)]
    public sealed class GameGoldChanged : Packet
    {
        public int GameGold { get; set; }
    }

    [PacketMark(2112)]
    public sealed class MountFailed : Packet
    {
        public HorseType Horse { get; set; }
    }

    [PacketMark(2114)]
    public sealed class WeightUpdate : Packet
    {
        public int BagWeight { get; set; }
        public int WearWeight { get; set; }
        public int HandWeight { get; set; }
    }

    [PacketMark(2115)]
    public sealed class HuntGoldChanged : Packet
    {
        public int HuntGold { get; set; }
    }

    [PacketMark(2116)]
    public sealed class TradeRequest : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(2117)]
    public sealed class TradeOpen : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(2118)]
    public sealed class TradeClose : Packet { }

    [PacketMark(2119)]
    public sealed class TradeAddItem : Packet
    {
        public CellLinkInfo Cell { get; set; }
        public bool Success { get; set; }
    }

    [PacketMark(2120)]
    public sealed class TradeAddGold : Packet
    {
        public long Gold { get; set; }
    }

    [PacketMark(2121)]
    public sealed class TradeItemAdded : Packet
    {
        public ClientUserItem Item { get; set; }
    }

    [PacketMark(2122)]
    public sealed class TradeGoldAdded : Packet
    {
        public long Gold { get; set; }
    }

    [PacketMark(2123)]
    public sealed class TradeUnlock : Packet { }

    [PacketMark(2124)]
    public sealed class GuildCreate : Packet
    {

    }

    [PacketMark(2125)]
    public sealed class GuildInfo : Packet
    {
        public ClientGuildInfo Guild { get; set; }
    }

    [PacketMark(2126)]
    public sealed class GuildNoticeChanged : Packet
    {
        public string Notice { get; set; }
    }

    [PacketMark(2127)]
    public sealed class GuildNewItem : Packet
    {
        public int Slot { get; set; }
        public ClientUserItem Item { get; set; }
        //public int Count { get; set; }
    }

    [PacketMark(2128)]
    public sealed class GuildGetItem : Packet
    {
        public GridType Grid { get; set; }
        public int Slot { get; set; }
        public ClientUserItem Item { get; set; }
    }

    [PacketMark(2129)]
    public sealed class GuildUpdate : Packet
    {
        public int MemberLimit { get; set; }
        public int StorageLimit { get; set; }

        public long GuildFunds { get; set; }
        public long DailyGrowth { get; set; }

        public int GuildLevel { get; set; }
        public int Tax { get; set; }

        public long TotalContribution { get; set; }
        public long DailyContribution { get; set; }

        public string DefaultRank { get; set; }
        public GuildPermission DefaultPermission { get; set; }

        public List<ClientGuildMemberInfo> Members { get; set; }
    }

    [PacketMark(2130)]
    public sealed class GuildKick : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2131)]
    public sealed class GuildTax : Packet
    {

    }

    [PacketMark(2132)]
    public sealed class GuildIncreaseMember : Packet
    {

    }

    [PacketMark(2133)]
    public sealed class GuildIncreaseStorage : Packet
    {

    }

    [PacketMark(2134)]
    public sealed class GuildInviteMember : Packet
    {

    }

    [PacketMark(2135)]
    public sealed class GuildInvite : Packet
    {
        public string Name { get; set; }
        public string GuildName { get; set; }
    }

    [PacketMark(2136)]
    public sealed class GuildStats : Packet
    {
        public int Index { get; set; }
        public Stats Stats { get; set; }

    }

    [PacketMark(2137)]
    public sealed class GuildMemberOffline : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2138)]
    public sealed class GuildMemberOnline : Packet
    {
        public int Index { get; set; }

        public string Name { get; set; }
        public uint ObjectID { get; set; }
    }

    [PacketMark(2139)]
    public sealed class GuildMemberContribution : Packet
    {
        public int Index { get; set; }

        public long Contribution { get; set; }
    }

    [PacketMark(2140)]
    public sealed class GuildDayReset : Packet
    {

    }

    [PacketMark(2141)]
    public sealed class GuildFundsChanged : Packet
    {
        public long Change { get; set; }
    }

    [PacketMark(2142)]
    public sealed class GuildChanged : Packet
    {
        public uint ObjectID { get; set; }
        public string GuildName { get; set; }
        public string GuildRank { get; set; }
    }

    [PacketMark(2143)]
    public sealed class GuildWarFinished : Packet
    {
        public string GuildName { get; set; }
    }

    [PacketMark(2144)]
    public sealed class GuildWar : Packet
    {
        public bool Success { get; set; }
    }

    [PacketMark(2145)]
    public sealed class GuildWarStarted : Packet
    {
        public string GuildName { get; set; }
        public TimeSpan Duration { get; set; }
    }

    [PacketMark(2146)]
    public sealed class GuildConquestDate : Packet
    {
        public int Index { get; set; }
        public TimeSpan WarTime { get; set; }

        public DateTime WarDate;

        [CompleteObject]
        public void Update()
        {
            if (WarTime == TimeSpan.MinValue)
                WarDate = DateTime.MinValue;
            else
                WarDate = Time.Now + WarTime;
        }
    }

    [PacketMark(2147)]
    public sealed class GuildCastleInfo : Packet
    {
        public int Index { get; set; }
        public string Owner { get; set; }
    }

    [PacketMark(2148)]
    public sealed class GuildConquestStarted : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2149)]
    public sealed class GuildConquestFinished : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2150)]
    public sealed class ReviveTimers : Packet
    {
        public TimeSpan ItemReviveTime { get; set; }
        public TimeSpan ReincarnationPillTime { get; set; }
    }

    [PacketMark(2151)]
    public sealed class QuestChanged : Packet
    {
        public ClientUserQuest Quest { get; set; }
    }

    [PacketMark(2152)]
    public sealed class CompanionUnlock : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2153)]
    public sealed class CompanionAdopt : Packet
    {
        public ClientUserCompanion UserCompanion { get; set; }
    }

    [PacketMark(2154)]
    public sealed class CompanionRetrieve : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2155)]
    public sealed class CompanionStore : Packet
    {
    }

    [PacketMark(2156)]
    public sealed class CompanionWeightUpdate : Packet
    {
        public int BagWeight { get; set; }
        public int MaxBagWeight { get; set; }
        public int InventorySize { get; set; }
    }

    [PacketMark(2157)]
    public sealed class CompanionItemsGained : Packet
    {
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2158)]
    public sealed class CompanionUpdate : Packet
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Hunger { get; set; }
    }

    [PacketMark(2159)]
    public sealed class CompanionSkillUpdate : Packet
    {
        public Stats Level3 { get; set; }
        public Stats Level5 { get; set; }
        public Stats Level7 { get; set; }
        public Stats Level10 { get; set; }
        public Stats Level11 { get; set; }
        public Stats Level13 { get; set; }
        public Stats Level15 { get; set; }
    }

    [PacketMark(2160)]
    public sealed class MarriageInvite : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(2161)]
    public sealed class MarriageInfo : Packet
    {
        public ClientPlayerInfo Partner { get; set; }
    }

    [PacketMark(2162)]
    public sealed class MarriageRemoveRing : Packet
    {

    }

    [PacketMark(2163)]
    public sealed class MarriageMakeRing : Packet
    {

    }

    [PacketMark(2164)]
    public sealed class MarriageOnlineChanged : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(2165)]
    public sealed class DataObjectRemove : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(2166)]
    public sealed class DataObjectPlayer : Packet
    {
        public uint ObjectID { get; set; }
        public int MapIndex { get; set; }
        public Point CurrentLocation { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }
        public bool Dead { get; set; }

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
    }

    [PacketMark(2167)]
    public sealed class DataObjectMonster : Packet
    {
        public uint ObjectID { get; set; }

        public int MapIndex { get; set; }
        public Point CurrentLocation { get; set; }

        public MonsterInfo MonsterInfo;
        public int MonsterIndex { get; set; }
        public string PetOwner { get; set; }

        public int Health { get; set; }
        public Stats Stats { get; set; }
        public bool Dead { get; set; }

        [CompleteObject]
        public void OnComplete()
        {
            MonsterInfo = Globals.MonsterInfoList.Binding.First(x => x.Index == MonsterIndex);
        }
    }

    [PacketMark(2168)]
    public sealed class DataObjectItem : Packet
    {
        public uint ObjectID { get; set; }

        public int MapIndex { get; set; }
        public Point CurrentLocation { get; set; }

        public ItemInfo ItemInfo;
        public int ItemIndex { get; set; }

        [CompleteObject]
        public void OnComplete()
        {
            ItemInfo = Globals.ItemInfoList.Binding.First(x => x.Index == ItemIndex);
        }
    }

    [PacketMark(2169)]
    public sealed class DataObjectLocation : Packet
    {
        public uint ObjectID { get; set; }
        public int MapIndex { get; set; }
        public Point CurrentLocation { get; set; }
    }

    [PacketMark(2170)]
    public sealed class DataObjectHealthMana : Packet
    {
        public uint ObjectID { get; set; }

        public int Health { get; set; }
        public int Mana { get; set; }
        public bool Dead { get; set; }
    }

    [PacketMark(2171)]
    public sealed class DataObjectMaxHealthMana : Packet
    {
        public uint ObjectID { get; set; }

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public Stats Stats { get; set; }
    }

    [PacketMark(2172)]
    public sealed class BlockAdd : Packet
    {
        public ClientBlockInfo Info { get; set; }
    }

    [PacketMark(2173)]
    public sealed class BlockRemove : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(2174)]
    public sealed class HelmetToggle : Packet
    {
        public bool HideHelmet { get; set; }
    }

    [PacketMark(2175)]
    public sealed class StorageSize : Packet
    {
        public int Size { get; set; }
    }

    [PacketMark(2176)]
    public sealed class PlayerChangeUpdate : Packet
    {

        public uint ObjectID { get; set; }
        public string Name { get; set; }
        public MirGender Gender { get; set; }
        public int HairType { get; set; }

        public Color HairColour { get; set; }
        public Color ArmourColour { get; set; }

    }

    [PacketMark(2177)]
    public sealed class FortuneUpdate : Packet
    {
        public List<ClientFortuneInfo> Fortunes { get; set; }

    }

    [PacketMark(2178)]
    public sealed class NPCWeaponCraft : Packet
    {
        public CellLinkInfo Template { get; set; }
        public CellLinkInfo Yellow { get; set; }
        public CellLinkInfo Blue { get; set; }
        public CellLinkInfo Red { get; set; }
        public CellLinkInfo Purple { get; set; }
        public CellLinkInfo Green { get; set; }
        public CellLinkInfo Grey { get; set; }

        public bool Success { get; set; }
    }

    [PacketMark(2179)]
    public sealed class CheckClientDb : Packet
    {
        public bool IsUpgrading { get; set; }
        public int CurrentIndex { get; set; } //从0开始
        public int TotalCount { get; set; }
        public byte[] Datas { get; set; }
    }

    [PacketMark(2180)]
    public sealed class CheckClientHash : Packet
    {
        public List<ClientUpgradeItem> ClientFileHash { get; set; }
    }

    [PacketMark(2181)]
    public sealed class UpgradeClient : Packet
    {
        public string FileKey { get; set; }
        public int TotalSize { get; set; }
        public int StartIndex { get; set; }
        public byte[] Datas { get; set; }
    }

    [PacketMark(2182)]
    public sealed class LoginSimple : Packet
    {
        public LoginResult Result { get; set; }

        public string Message { get; set; }
        public TimeSpan Duration { get; set; }

        public List<SelectInfo> Characters { get; set; }

        public string Address { get; set; }

        public bool TestServer { get; set; }
    }

    [PacketMark(2183)]
    public sealed class AccountExpand : Packet
    {
        public List<ClientUserItem> Items { get; set; }

        public List<ClientBlockInfo> BlockList { get; set; }
    }

    [PacketMark(2184)]
    public sealed class AutoTimeChanged : Packet
    {
        public long AutoTime { get; set; }
    }

    [PacketMark(2185)]
    public sealed class SortBagItem : Packet
    {
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2186)]
    public sealed class Qiehuanxunzhaoguaiwumoshi : Packet
    {
        public bool Moshi01 { get; set; }
        public bool Moshi02 { get; set; }
    }

    [PacketMark(2187)]
    public sealed class SortStorageItem : Packet
    {
        public List<ClientUserItem> Items { get; set; }
    }

    [PacketMark(2188)]
    public sealed class WeaponRefineBase : Packet
    {
        public int LevelLimit { get; set; }
        public int RarityStep { get; set; }
    }

    [PacketMark(2189)]
    public sealed class SkillConfig : Packet
    {
        public int SkillLevelLimit {  get; set; }

    }
}

