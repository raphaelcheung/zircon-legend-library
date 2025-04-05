using System;
using System.Collections.Generic;

namespace Library
{
    public sealed class FrameSet
    {
        public static Dictionary<MirAnimation, Frame> Players = new Dictionary<MirAnimation, Frame>()
        {
            [MirAnimation.Standing] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(500.0)),
            [MirAnimation.Walking] = new Frame(80, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Running] = new Frame(160, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.CreepStanding] = new Frame(1680, 4, 10, TimeSpan.FromMilliseconds(500.0)),
            [MirAnimation.CreepWalkFast] = new Frame(1760, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.CreepWalkSlow] = new Frame(1760, 6, 10, TimeSpan.FromMilliseconds(200.0)),
            [MirAnimation.Pushed] = new Frame(240, 6, 10, TimeSpan.FromMilliseconds(50.0))
            {
                Reversed = true,
                StaticSpeed = true
            },
            [MirAnimation.Stance] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(500.0)),
            [MirAnimation.Harvest] = new Frame(480, 2, 10, TimeSpan.FromMilliseconds(300.0)),
            [MirAnimation.Combat1] = new Frame(560, 5, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat2] = new Frame(640, 5, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat3] = new Frame(720, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat4] = new Frame(800, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat5] = new Frame(880, 10, 10, TimeSpan.FromMilliseconds(60.0)),
            [MirAnimation.Combat6] = new Frame(960, 10, 10, TimeSpan.FromMilliseconds(60.0)),
            [MirAnimation.Combat7] = new Frame(1040, 10, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat8] = new Frame(1120, 6, 10, TimeSpan.FromMilliseconds(50.0))
            {
                StaticSpeed = true
            },
            [MirAnimation.Combat9] = new Frame(1200, 10, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat10] = new Frame(1280, 10, 10, TimeSpan.FromMilliseconds(60.0)),
            [MirAnimation.Combat11] = new Frame(1360, 10, 10, TimeSpan.FromMilliseconds(60.0)),
            [MirAnimation.Combat12] = new Frame(1440, 10, 10, TimeSpan.FromMilliseconds(60.0)),
            [MirAnimation.Combat13] = new Frame(1520, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat14] = new Frame(1600, 8, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Combat15] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(200.0)),
            [MirAnimation.DragonRepulseStart] = new Frame(1600, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.DragonRepulseMiddle] = new Frame(1605, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
            [MirAnimation.DragonRepulseEnd] = new Frame(1606, 2, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Struck] = new Frame(1840, 3, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Die] = new Frame(1920, 10, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.Dead] = new Frame(1929, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
            [MirAnimation.HorseStanding] = new Frame(2240, 4, 10, TimeSpan.FromMilliseconds(500.0)),
            [MirAnimation.HorseWalking] = new Frame(2320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.HorseRunning] = new Frame(2400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.HorseStruck] = new Frame(2480, 3, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.ChannellingStart] = new Frame(560, 4, 10, TimeSpan.FromMilliseconds(100.0)),
            [MirAnimation.ChannellingMiddle] = new Frame(563, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
            [MirAnimation.ChannellingEnd] = new Frame(0, 1, 10, TimeSpan.FromMilliseconds(60.0))
        };
        public static Dictionary<MirAnimation, Frame> DefaultItem;
        public static Dictionary<MirAnimation, Frame> DefaultNPC;
        public static Dictionary<MirAnimation, Frame> DefaultMonster;
        public static Dictionary<MirAnimation, Frame> ForestYeti;
        public static Dictionary<MirAnimation, Frame> ChestnutTree;
        public static Dictionary<MirAnimation, Frame> CarnivorousPlant;
        public static Dictionary<MirAnimation, Frame> DevouringGhost;
        public static Dictionary<MirAnimation, Frame> Larva;
        public static Dictionary<MirAnimation, Frame> ZumaGuardian;
        public static Dictionary<MirAnimation, Frame> ZumaKing;
        public static Dictionary<MirAnimation, Frame> Monkey;
        public static Dictionary<MirAnimation, Frame> NumaMage;
        public static Dictionary<MirAnimation, Frame> CursedCactus;
        public static Dictionary<MirAnimation, Frame> NetherWorldGate;
        public static Dictionary<MirAnimation, Frame> WestDesertLizard;
        public static Dictionary<MirAnimation, Frame> BanyaGuard;
        public static Dictionary<MirAnimation, Frame> EmperorSaWoo;
        public static Dictionary<MirAnimation, Frame> JinchonDevil;
        public static Dictionary<MirAnimation, Frame> ArchLichTaeda;
        public static Dictionary<MirAnimation, Frame> ShinsuBig;
        public static Dictionary<MirAnimation, Frame> PachonTheChaosBringer;
        public static Dictionary<MirAnimation, Frame> IcySpiritGeneral;
        public static Dictionary<MirAnimation, Frame> FieryDancer;
        public static Dictionary<MirAnimation, Frame> EmeraldDancer;
        public static Dictionary<MirAnimation, Frame> QueenOfDawn;
        public static Dictionary<MirAnimation, Frame> JinamStoneGate;
        public static Dictionary<MirAnimation, Frame> OYoungBeast;
        public static Dictionary<MirAnimation, Frame> YumgonWitch;
        public static Dictionary<MirAnimation, Frame> JinhwanSpirit;
        public static Dictionary<MirAnimation, Frame> ChiwooGeneral;
        public static Dictionary<MirAnimation, Frame> DragonQueen;
        public static Dictionary<MirAnimation, Frame> DragonLord;
        public static Dictionary<MirAnimation, Frame> FerociousIceTiger;
        public static Dictionary<MirAnimation, Frame> SamaFireGuardian;
        public static Dictionary<MirAnimation, Frame> Phoenix;
        public static Dictionary<MirAnimation, Frame> EnshrinementBox;
        public static Dictionary<MirAnimation, Frame> BloodStone;
        public static Dictionary<MirAnimation, Frame> SamaCursedBladesman;
        public static Dictionary<MirAnimation, Frame> SamaCursedSlave;
        public static Dictionary<MirAnimation, Frame> SamaProphet;
        public static Dictionary<MirAnimation, Frame> SamaSorcerer;
        public static Dictionary<MirAnimation, Frame> EasterEvent;
        public static Dictionary<MirAnimation, Frame> OrangeTiger;
        public static Dictionary<MirAnimation, Frame> RedTiger;
        public static Dictionary<MirAnimation, Frame> OrangeBossTiger;
        public static Dictionary<MirAnimation, Frame> BigBossTiger;
        public static Dictionary<MirAnimation, Frame> SDMob3;
        public static Dictionary<MirAnimation, Frame> SDMob8;
        public static Dictionary<MirAnimation, Frame> SDMob15;
        public static Dictionary<MirAnimation, Frame> SDMob16;
        public static Dictionary<MirAnimation, Frame> SDMob17;
        public static Dictionary<MirAnimation, Frame> SDMob18;
        public static Dictionary<MirAnimation, Frame> SDMob19;
        public static Dictionary<MirAnimation, Frame> SDMob21;
        public static Dictionary<MirAnimation, Frame> SDMob22;
        public static Dictionary<MirAnimation, Frame> SDMob23;
        public static Dictionary<MirAnimation, Frame> SDMob24;
        public static Dictionary<MirAnimation, Frame> SDMob25;
        public static Dictionary<MirAnimation, Frame> SDMob26;
        public static Dictionary<MirAnimation, Frame> SDMob27;
        public static Dictionary<MirAnimation, Frame> SDMob28;
        public static Dictionary<MirAnimation, Frame> SDMob29;
        public static Dictionary<MirAnimation, Frame> SDMob30;
        public static Dictionary<MirAnimation, Frame> SDMob31;
        public static Dictionary<MirAnimation, Frame> SDMob32;
        public static Dictionary<MirAnimation, Frame> SDMob33;
        public static Dictionary<MirAnimation, Frame> GardenSoldier;
        public static Dictionary<MirAnimation, Frame> GardenDefender;
        public static Dictionary<MirAnimation, Frame> RedBlossom;
        public static Dictionary<MirAnimation, Frame> BlueBlossom;
        public static Dictionary<MirAnimation, Frame> FireBird;
        public static Dictionary<MirAnimation, Frame> Changmingdeng;
        public static Dictionary<MirAnimation, Frame> Xianjin;
        public static Dictionary<MirAnimation, Frame> LobsterLord;
        public static Dictionary<MirAnimation, Frame> LobsterSpawn;
        public static Dictionary<MirAnimation, Frame> DeadTree;
        public static Dictionary<MirAnimation, Frame> BobbitWorm;
        public static Dictionary<MirAnimation, Frame> MonasteryMon1;
        public static Dictionary<MirAnimation, Frame> MonasteryMon3;
        public static Dictionary<MirAnimation, Frame> Yanhua;
        public static Dictionary<MirAnimation, Frame> Hehua;
        public static Dictionary<MirAnimation, Frame> CrazedPrimate;
        public static Dictionary<MirAnimation, Frame> HellBringer;
        public static Dictionary<MirAnimation, Frame> YurinMon0;
        public static Dictionary<MirAnimation, Frame> YurinMon1;
        public static Dictionary<MirAnimation, Frame> WhiteBeardedTiger;
        public static Dictionary<MirAnimation, Frame> HardenedRhino;
        public static Dictionary<MirAnimation, Frame> Mammoth;
        public static Dictionary<MirAnimation, Frame> CursedSlave1;
        public static Dictionary<MirAnimation, Frame> CursedSlave2;
        public static Dictionary<MirAnimation, Frame> CursedSlave3;
        public static Dictionary<MirAnimation, Frame> PoisonousGolem;
        public static Dictionary<MirAnimation, Frame> QitiandashenFrame;

        static FrameSet()
        {
            FrameSet.Players[MirAnimation.Combat1].Delays[1] = TimeSpan.FromMilliseconds(200.0);
            FrameSet.Players[MirAnimation.Combat2].Delays[3] = TimeSpan.FromMilliseconds(200.0);
            FrameSet.DefaultItem = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.DefaultNPC = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 4, 0, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.DefaultMonster = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 6, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(160, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(160, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 2, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(329, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
                [MirAnimation.Skeleton] = new Frame(880, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
                [MirAnimation.Show] = new Frame(640, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Hide] = new Frame(640, 10, 10, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                },
                [MirAnimation.StoneStanding] = new Frame(640, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.ForestYeti = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Die] = new Frame(320, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(323, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.ChestnutTree = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.CarnivorousPlant = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 4, 0, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Show] = new Frame(640, 8, 0, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                },
                [MirAnimation.Hide] = new Frame(640, 8, 0, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.DevouringGhost = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.Larva = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(80, 6, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.ZumaGuardian = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(640, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.ZumaKing = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(640, 20, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.StoneStanding] = new Frame(640, 1, 0, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.Monkey = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.NetherWorldGate = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 0, TimeSpan.FromMilliseconds(200.0))
            };
            FrameSet.CursedCactus = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.NumaMage = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat3] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.WestDesertLizard = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.BanyaGuard = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.JinchonDevil = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Combat2] = new Frame(400, 9, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Combat3] = new Frame(480, 8, 10, TimeSpan.FromMilliseconds(70.0))
            };
            FrameSet.EmperorSaWoo = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.ArchLichTaeda = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Show] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(720, 20, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(739, 1, 20, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.PachonTheChaosBringer = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(480, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.DragonRepulseStart] = new Frame(480, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.DragonRepulseMiddle] = new Frame(486, 1, 10, TimeSpan.FromMilliseconds(1000.0)),
                [MirAnimation.DragonRepulseEnd] = new Frame(487, 3, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.IcySpiritGeneral = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat3] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.FieryDancer = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.EmeraldDancer = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 20, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(320, 20, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(320, 20, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(480, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(560, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(569, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.QueenOfDawn = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(400, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.OYoungBeast = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 5, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.YumgonWitch = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.JinhwanSpirit = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.ChiwooGeneral = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.DragonQueen = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(327, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.DragonLord = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.FerociousIceTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(480, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(560, 16, 0, TimeSpan.FromMilliseconds(40.0)),
                [MirAnimation.Combat3] = new Frame(560, 16, 0, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.SamaFireGuardian = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.Phoenix = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(480, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(489, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.EnshrinementBox = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Struck] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Die] = new Frame(80, 10, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(89, 1, 0, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.BloodStone = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 4, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Struck] = new Frame(240, 2, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Die] = new Frame(320, 9, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 0, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SamaCursedBladesman = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SamaCursedSlave = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SamaProphet = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(50, 4, 0, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(130, 9, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(210, 9, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(290, 10, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(370, 3, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(450, 10, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(459, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SamaSorcerer = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(320, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(480, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(489, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.EasterEvent = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Show] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Hide] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                },
                [MirAnimation.StoneStanding] = new Frame(0, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.DragonRepulseStart] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.DragonRepulseMiddle] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(1000.0)),
                [MirAnimation.DragonRepulseEnd] = new Frame(0, 4, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.OrangeTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.RedTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.OrangeBossTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 0, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(406, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.BigBossTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 0, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 2, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(329, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat2] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat4] = new Frame(560, 10, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.SDMob3 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(640, 10, 10, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                },
                [MirAnimation.Hide] = new Frame(640, 10, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.SDMob8 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat2] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.SDMob15 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 7, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob16 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Walking] = new Frame(80, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 7, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob17 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob18 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob19 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob21 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob22 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(325, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob23 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(327, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.SDMob24 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 7, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 9, 10, TimeSpan.FromMilliseconds(70.0))
            };
            FrameSet.SDMob25 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 7, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(70.0))
            };
            FrameSet.SDMob26 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 7, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.LobsterLord = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(20, 6, 0, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(30, 7, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(40, 7, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(60, 7, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat4] = new Frame(70, 7, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat5] = new Frame(80, 7, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat6] = new Frame(110, 8, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat7] = new Frame(120, 4, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(50, 4, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(130, 9, 0, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(138, 1, 0, TimeSpan.FromMilliseconds(500.0))
            };
            FrameSet.JinamStoneGate = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0))
            };
            FrameSet.DeadTree = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Struck] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Die] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Dead] = new Frame(0, 1, 0, TimeSpan.FromMilliseconds(200.0))
            };
            FrameSet.MonasteryMon1 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 15, 20, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(320, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(320, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(400, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(480, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(488, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.MonasteryMon3 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 15, 20, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(480, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(560, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(568, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.BobbitWorm = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Hide] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                }
            };
            FrameSet.GardenSoldier = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(480, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(488, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.GardenDefender = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 9, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.RedBlossom = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(240, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(320, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(409, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.BlueBlossom = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat2] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.FireBird = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(320, 5, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(240, 5, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat4] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(480, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(560, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(569, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.SDMob27 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.StoneStanding] = new Frame(0, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Show] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Walking] = new Frame(240, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Combat2] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(480, 3, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(560, 10, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(713, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.SDMob28 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Die] = new Frame(480, 10, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Dead] = new Frame(560, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.SDMob29 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(0, 13, 20, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Hide] = new Frame(0, 13, 20, TimeSpan.FromMilliseconds(100.0))
                {
                    Reversed = true
                },
                [MirAnimation.Standing] = new Frame(160, 4, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(240, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat1] = new Frame(320, 8, 10, TimeSpan.FromMilliseconds(70.0)),
                [MirAnimation.Pushed] = new Frame(400, 3, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Die] = new Frame(480, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(480, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.Changmingdeng = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 1, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Die] = new Frame(80, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(85, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.Xianjin = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 5, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Dead] = new Frame(5, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.CrazedPrimate = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(327, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.HellBringer = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(480, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat4] = new Frame(560, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 4, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.YurinMon0 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.YurinMon1 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.WhiteBeardedTiger = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.HardenedRhino = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(480, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.Mammoth = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat2] = new Frame(400, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(480, 6, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.CursedSlave1 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat3] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.CursedSlave2 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(328, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.CursedSlave3 = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Walking] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Pushed] = new Frame(80, 8, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat1] = new Frame(160, 9, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Combat2] = new Frame(400, 8, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0))
            };
            FrameSet.PoisonousGolem = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Standing] = new Frame(0, 6, 10, TimeSpan.FromMilliseconds(500.0)),
                [MirAnimation.Walking] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(80.0)),
                [MirAnimation.Pushed] = new Frame(80, 10, 10, TimeSpan.FromMilliseconds(50.0))
                {
                    Reversed = true,
                    StaticSpeed = true
                },
                [MirAnimation.Combat3] = new Frame(400, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Struck] = new Frame(240, 3, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Die] = new Frame(320, 7, 10, TimeSpan.FromMilliseconds(100.0)),
                [MirAnimation.Dead] = new Frame(326, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
            FrameSet.Yanhua = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(0, 8, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Standing] = new Frame(0, 8, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Walking] = new Frame(0, 8, 10, TimeSpan.FromMilliseconds(200.0))
            };
            FrameSet.Hehua = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Standing] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Walking] = new Frame(0, 10, 10, TimeSpan.FromMilliseconds(200.0))
            };
            FrameSet.QitiandashenFrame = new Dictionary<MirAnimation, Frame>()
            {
                [MirAnimation.Show] = new Frame(30000, 10, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Standing] = new Frame(30000, 10, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Walking] = new Frame(30080, 6, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Running] = new Frame(30160, 6, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Pushed] = new Frame(30240, 1, 10, TimeSpan.FromMilliseconds(200.0)),
                [MirAnimation.Combat1] = new Frame(30560, 5, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Struck] = new Frame(30720, 6, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Die] = new Frame(31920, 10, 10, TimeSpan.FromMilliseconds(150.0)),
                [MirAnimation.Dead] = new Frame(31930, 1, 10, TimeSpan.FromMilliseconds(1000.0))
            };
        }
    }

    public sealed class Frame
    {
        public static Frame EmptyFrame = new Frame(0, 0, 0, TimeSpan.Zero);

        public int StartIndex;
        public int FrameCount;
        public int OffSet;

        public bool Reversed, StaticSpeed;

        public TimeSpan[] Delays { get; set; } //Index = Duration to freeze
        

        public Frame(int startIndex, int frameCount, int offSet, TimeSpan frameDelay)
        {
            StartIndex = startIndex;
            FrameCount = frameCount;
            OffSet = offSet;

            Delays = new TimeSpan[FrameCount];
            for (int i = 0; i < Delays.Length; i++)
                Delays[i] = frameDelay;
        }
        public Frame(Frame frame)
        {
            StartIndex = frame.StartIndex;
            FrameCount = frame.FrameCount;
            OffSet = frame.OffSet;

            Delays = new TimeSpan[FrameCount];
            for (int i = 0; i < Delays.Length; i++)
                Delays[i] = frame.Delays[i];
        }
        public int GetFrame(DateTime start, DateTime now, bool doubleSpeed)
        {
            TimeSpan enlapsed = now - start;

            if (doubleSpeed && !StaticSpeed)
                enlapsed += enlapsed;


            if (Reversed)
            {
                for (int i = 0; i < Delays.Length; i++)
                {
                    enlapsed -= Delays[Delays.Length - 1 - i];
                    if (enlapsed >= TimeSpan.Zero) continue;

                    return i;
                }
            }
            else
            {
                for (int i = 0; i < Delays.Length; i++)
                {
                    enlapsed -= Delays[i];
                    if (enlapsed >= TimeSpan.Zero) continue;

                    return i;
                }
            }


            return FrameCount;
        }
    }


}
