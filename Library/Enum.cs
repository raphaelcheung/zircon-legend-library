using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum MirGender : byte
    {
        [Description("男性")] Male,
        [Description("女性")] Female
    }

    public enum MirClass : byte
    {
        [Description("战士")] Warrior,
        [Description("法师")] Wizard,
        [Description("道士")] Taoist,
        [Description("刺客")] Assassin,
    }

    public enum AttackMode : byte
    {
        [Description("攻击模式: 和平")]
        Peace,
        [Description("攻击模式: 组队")]
        Group,
        [Description("攻击模式: 帮会")]
        Guild,
        [Description("攻击模式: 战争, 红名, 灰名")]
        WarRedBrown,
        [Description("攻击模式: 全体")]
        All
    }

    public enum PetMode : byte
    {
        [Description("宠物: 移动, 攻击")]
        Both,
        [Description("宠物: 移动")]
        Move,
        [Description("宠物: 攻击")]
        Attack,
        [Description("宠物: PvP")]
        PvP,
        [Description("宠物: 休息")]
        None,
    }

    public enum MirDirection : byte
    {
        [Description("上")]  Up = 0,
        [Description("右上")] UpRight = 1,
        [Description("右")] Right = 2,
        [Description("右下")] DownRight = 3,
        [Description("下")] Down = 4,
        [Description("左下")] DownLeft = 5,
        [Description("左")] Left = 6,
        [Description("左上")] UpLeft = 7
    }

    [Flags]
    public enum RequiredClass : byte
    {
        [Description("无")] None = 0,
        [Description("战士")] Warrior = 1,
        [Description("法师")] Wizard = 2,
        [Description("道士")] Taoist = 4,
        [Description("刺客")] Assassin = 8,
        [Description("战士, 法师, 道士")]WarWizTao = Warrior | Wizard | Taoist,
        [Description("法师, 道士")]WizTao = Wizard | Taoist,
        [Description("战士, 刺客")]AssWar = Warrior | Assassin,
        [Description("战士, 法师, 道士, 刺客")] All = WarWizTao | Assassin
    }

    [Flags]
    public enum RequiredGender : byte
    {
        [Description("男")] Male = 1,
        [Description("女")] Female = 2,
        [Description("男、女")] None = Male | Female
    }

    public enum EquipmentSlot
    {
        Weapon = 0,
        Armour = 1,
        Helmet = 2,
        Torch = 3,
        Necklace = 4,
        BraceletL = 5,
        BraceletR = 6,
        RingL = 7,
        RingR = 8,
        Shoes = 9,
        Poison = 10,
        Amulet = 11,
        Flower = 12,
        HorseArmour = 13,
        Emblem = 14,
        Shield = 15,
    }

    public enum CompanionSlot
    {
        Bag = 0,
        Head = 1,
        Back = 2,
        Food = 3,
    }


    public enum GridType
    {
        None,
        Inventory,
        Equipment,
        Belt,
        Sell,
        Repair,
        Storage,
        AutoPotion,
        RefineBlackIronOre,
        RefineAccessory,
        RefineSpecial,
        Inspect,
        Consign,
        SendMail,
        TradeUser,
        TradePlayer,
        GuildStorage,
        CompanionInventory,
        CompanionEquipment,
        WeddingRing,
        RefinementStoneIronOre,
        RefinementStoneSilverOre,
        RefinementStoneDiamond,
        RefinementStoneGoldOre,
        RefinementStoneCrystal,
        ItemFragment,
        AccessoryRefineUpgradeTarget,
        AccessoryRefineLevelTarget,
        AccessoryRefineLevelItems,
        MasterRefineFragment1,
        MasterRefineFragment2,
        MasterRefineFragment3,
        MasterRefineStone,
        MasterRefineSpecial,
        AccessoryReset,
        WeaponCraftTemplate,
        WeaponCraftYellow,
        WeaponCraftBlue,
        WeaponCraftRed,
        WeaponCraftPurple,
        WeaponCraftGreen,
        WeaponCraftGrey,
        PatchGrid,
        BaoshiItems
    }

    public enum BuffType
    {
        None,

        Server = 1,
        HuntGold = 2,

        Observable = 3,
        Brown  = 4,
        PKPoint = 5,
        PvPCurse = 6,
        Redemption = 7,
        Companion = 8,

        Castle = 9,



        ItemBuff = 10,
        ItemBuffPermanent = 11,

        Ranking = 12,
        Developer = 13,
        Veteran = 14,

        MapEffect = 15,
        Guild = 16,

        DeathDrops = 17,

        Defiance = 100,
        Might = 101,
        Endurance = 102,
        ReflectDamage = 103,

        Renounce = 200,
        MagicShield = 201,
        JudgementOfHeaven = 202,


        Heal = 300,
        Invisibility = 301,
        MagicResistance = 302,
        Resilience = 303,
        ElementalSuperiority = 304,
        BloodLust = 305,
        StrengthOfFaith = 306,
        CelestialLight = 307,
        Transparency = 308,
        LifeSteal = 309,

        PoisonousCloud = 400,

        FullBloom = 401, 
        WhiteLotus = 402,
        RedLotus = 403,
        Cloak = 404,
        GhostWalk = 405,
        TheNewBeginning = 406,
        DarkConversion = 407,
        DragonRepulse = 408,
        Evasion = 409,
        RagingWind = 410,
        FrostBite = 411,

        MagicWeakness = 500,
    }

    public enum RequiredType : byte
    {
        Level,
        MaxLevel,
        AC,
        MR,
        DC,
        MC,
        SC,
        Health,
        Mana,
        Accuracy,
        Agility,
        CompanionLevel,
        MaxCompanionLevel,
        RebirthLevel,
        MaxRebirthLevel,
    }

    public enum Rarity : byte
    {
        [Description("普通物品")] Common,
        [Description("高级物品")] Superior,
        [Description("稀世物品")] Elite,
    }

    public enum LightSetting : byte
    {
        Default,
        Light,
        Night,
        Twilight,
    }

    public enum FightSetting : byte
    {
        None,
        Safe,
        Fight,
    }

    public enum ObjectType : byte
    {
        None, //Error

        Player,
        Item,
        NPC,
        Spell,
        Monster
    }

    public enum ItemType : byte
    {
        [Description("无")] Nothing,
        [Description("药水")]Consumable,
        [Description("武器")]Weapon,
        [Description("盔甲")]Armour,
        [Description("火炬")]Torch,
        [Description("头盔")]Helmet,
        [Description("项链")] Necklace,
        [Description("手镯")] Bracelet,
        [Description("戒指")] Ring,
        [Description("鞋")] Shoes,
        [Description("毒")] Poison,
        [Description("护身符")] Amulet,
        [Description("肉")] Meat,
        [Description("矿")] Ore,
        [Description("书")] Book,
        [Description("卷轴")] Scroll,
        [Description("暗石")]DarkStone,
        [Description("特殊精炼")]RefineSpecial,
        [Description("马甲")]HorseArmour,
        [Description("鲜花")] Flower,
        [Description("小伙伴食物")]CompanionFood,
        [Description("小伙伴背包")]CompanionBag,
        [Description("小伙伴头盔")]CompanionHead,
        [Description("小伙伴背甲")]CompanionBack,
        [Description("系统")] System,
        [Description("套装组件")]ItemPart,
        [Description("徽章")] Emblem,
        [Description("盾牌")] Shield,

        [Description("法宝")] Fabao,
    }

    public enum MirAction : byte
    {
        Standing,
        Moving,
        Pushed,
        Attack,
        RangeAttack, //?
        Spell,
        Harvest,
      //  Struck,
        Die,
        Dead,
        Show,
        Hide,
        Mount,
        Mining,
    }

    public enum MirAnimation : byte
    {
        Standing,
        Walking,
        CreepStanding,
        CreepWalkSlow,
        CreepWalkFast,
        Running,
        Pushed,
        Combat1,
        Combat2,
        Combat3,
        Combat4,
        Combat5,
        Combat6,
        Combat7,
        Combat8,
        Combat9,
        Combat10,
        Combat11,
        Combat12,
        Combat13,
        Combat14,
        Combat15,
        Harvest,
        Stance,
        Struck,
        Die,
        Dead,
        Skeleton,
        Show,
        Hide,
        HorseStanding,
        HorseWalking,
        HorseRunning,
        HorseStruck,
        StoneStanding,
        DragonRepulseStart,
        DragonRepulseMiddle,
        DragonRepulseEnd,
        ChannellingStart,
        ChannellingMiddle,
        ChannellingEnd,
    }

    public enum MessageAction
    {
        None,
        Revive,
    }

    public enum MessageType
    {
        Normal,
        Shout,
        WhisperIn,
        GMWhisperIn,
        WhisperOut,
        Group,
        Global,
        Hint,
        System,
        Announcement,
        Combat,
        ObserverChat,
        Guild,
    }

    public enum NPCDialogType
    {
        None,
        BuySell,
        Repair,
        Refine,
        RefineRetrieve,
        CompanionManage,
        WeddingRing,
        RefinementStone,
        MasterRefine,
        WeaponReset,
        ItemFragment,
        AccessoryRefineUpgrade,
        AccessoryRefineLevel,
        AccessoryReset,
        WeaponCraft,
        KuijiaFenjie,
    }

    public enum MagicSchool
    {
        None,
        Passive,
        WeaponSkills,
        Neutral,
        Fire,
        Ice,
        Lightning,
        Wind,
        Holy,
        Dark,
        Phantom,
        Combat,
        Assassination
    }
    
    public enum Element : byte
    {
        None,
        Fire,
        Ice,
        Lightning ,
        Wind,
        Holy,
        Dark ,
        Phantom,
    }

    public enum MagicMode
    {
        Free,           //可自由释放，随时，无需目标
        Pose,           //需要摆POSE的技能，无需目标
        Point,          //需指定单个已存在目标
        Direction,      //需指定释放方向
        Block,          //需指定任意释放点
    }

    public enum PickType
    {
        Sequence = 0,   //捡拾范围内按顺序捡拾，一次只捡一个
        All,            //捡拾范围内全部
        Gold,           //捡拾范围内金币
        Valuable,       //捡拾范围内的有加成普通物品以及高级、稀世物品
    }

    public enum MagicType
    {
        None,

        Swordsmanship = 100,            //基本剑术
        PotionMastery = 101,            //运气术
        Slaying = 102,                  //攻杀剑法
        Thrusting = 103,                //刺杀剑术
        HalfMoon = 104,                 //半月弯刀
        ShoulderDash = 105,             //野蛮冲撞
        FlamingSword = 106,             //烈火剑法
        DragonRise = 107,               //翔空剑法
        BladeStorm = 108,               //莲月剑法
        DestructiveSurge = 109,         //十方斩
        Interchange = 110,              //乾坤大挪移
        Defiance = 111,                 //铁布衫
        Beckon = 112,                   //斗转星移
        Might = 113,                    //破血狂杀
        SwiftBlade = 114,               //快刀斩麻
        Assault = 115,                  //狂暴冲撞
        Endurance = 116,                //金刚之躯
        ReflectDamage = 117,            //移花接木
        Fetter = 118,                   //泰山压顶
        SwirlingBlade = 119,            //旋风斩
        ReigningStep = 120,             //君临步
        MaelstromBlade = 121,           //屠龙斩
        AdvancedPotionMastery = 122,    //高级运气术
        MassBeckon = 123,               //吸气魔吼
        SeismicSlam = 124,              //天雷锤

        FireBall = 201,                 //火球术
        LightningBall = 202,            //霹雳掌
        IceBolt = 203,                  //冰月神掌
        GustBlast = 204,                //风掌
        Repulsion = 205,                //抗拒火环
        ElectricShock = 206,            //诱惑之光
        Teleportation = 207,            //瞬息移动
        AdamantineFireBall = 208,       //大火球
        ThunderBolt = 209,              //雷电术
        IceBlades = 210,                //冰月震天
        Cyclone = 211,                  //击风
        ScortchedEarth = 212,           //地狱火
        LightningBeam = 213,            //疾光电影
        FrozenEarth = 214,              //冰沙掌
        BlowEarth = 215,                //风震天
        FireWall = 216,                 //火墙
        ExpelUndead = 217,              //圣言术
        GeoManipulation = 218,          //移形换位
        MagicShield = 219,              //魔法盾
        FireStorm = 220,                //爆裂火焰
        LightningWave = 221,            //地狱雷光
        IceStorm = 222,                 //冰咆哮
        DragonTornado = 223,            //龙卷风
        GreaterFrozenEarth = 224,       //魄冰刺
        ChainLightning = 225,           //怒神霹雳
        MeteorShower = 226,             //焰天火雨
        Renounce = 227,                 //凝血离魂
        Tempest = 228,                  //旋风墙
        JudgementOfHeaven = 229,        //天打雷劈
        ThunderStrike = 230,            //电闪雷鸣
        RayOfLight = 231,               //混元掌
        BurstOfEnergy = 232,            //透心琏
        ShieldOfPreservation = 233,     //魔光盾
        RetrogressionOfEnergy = 234,    //焚魂魔功
        FuryBlast = 235,                //魔爆术
        TempestOfUnstableEnergy = 236,  //地狱魔焰
        MirrorImage = 237,              //分身术
        AdvancedRenounce = 238,         //高级凝血离魂
        FrostBite = 239,                //护身冰环
        Asteroid = 240,                 //天之怒火

        Heal = 300,                     //治愈术
        SpiritSword = 301,              //精神力战法
        PoisonDust = 302,               //施毒术
        ExplosiveTalisman = 303,        //灵魂火符
        EvilSlayer = 304,               //月魂断玉
        Invisibility = 305,             //隐身术
        MagicResistance = 306,          //幽灵盾
        MassInvisibility = 307,         //集体隐身术
        GreaterEvilSlayer = 308,        //月魂灵波
        Resilience = 309,               //神圣战甲术
        TrapOctagon = 310,              //困魔咒
        TaoistCombatKick = 311,         //空拳刀法
        ElementalSuperiority = 312,     //强震魔法
        MassHeal = 313,                 //群体治愈术
        BloodLust = 314,                //猛虎强势
        Resurrection = 315,             //回生术
        Purification = 316,             //云寂术
        Transparency = 317,             //妙影无踪
        CelestialLight = 318,           //阴阳法环
        EmpoweredHealing = 319,         //养生术
        LifeSteal = 320,                //吸星大法
        ImprovedExplosiveTalisman = 321,//灭魂火符
        GreaterPoisonDust = 322,        //施毒大法
        Scarecrow = 323,                //迷魂大法
        ThunderKick = 324,              //横扫千军
        DragonBreath = 325,             //神灵守护
        MassTransparency = 326,         //隐魂术
        GreaterHolyStrike = 327,        //月明波
        AugmentExplosiveTalisman = 328, //强化灵魂火符
        AugmentEvilSlayer = 329,        //强化月魂断玉
        AugmentPurification = 330,      //强化云寂术
        OathOfThePerished = 331,        //强化回生术
        SummonSkeleton = 332,           //召唤骷髅
        SummonShinsu = 333,             //召唤神兽
        SummonJinSkeleton = 334,        //超强召唤骷髅
        StrengthOfFaith = 335,          //移花接玉
        SummonDemonicCreature = 336,    //炎魔召唤术
        DemonExplosion = 337,           //炎魔火焰
        Infection = 338,                //传染
        DemonicRecovery = 339,          //恶魔的复苏

        WillowDance = 401,              //垂柳舞
        VineTreeDance = 402,            //蔓藤舞
        Discipline = 403,               //锋刀术
        PoisonousCloud = 404,           //鬼雾
        FullBloom = 405,                //盛开
        Cloak = 406,                    //潜行
        WhiteLotus = 407,               //白莲
        CalamityOfFullMoon = 408,       //满月饿狼
        WraithGrip = 409,               //亡灵束缚
        RedLotus = 410,                 //红莲
        HellFire = 411,                 //惩罚
        PledgeOfBlood = 412,            //血禅
        Rake = 413,                     //血盟
        SweetBrier = 414,               //暗灭茶花
        SummonPuppet = 415,             //亡灵替身
        Karma = 416,                    //孽报
        TouchOfTheDeparted = 417,       //亡灵掌握
        WaningMoon = 418,               //残月乱鸦
        GhostWalk = 419,                //鬼灵步
        ElementalPuppet = 420,          //神机妙算
        Rejuvenation = 421,             //长生诀
        Resolution = 422,               //结义
        ChangeOfSeasons = 423,          //心机一转
        Release = 424,                  //顽强
        FlameSplash = 425,              //朔月炎龙
        BloodyFlower = 426,             //百花盛开
        TheNewBeginning = 427,          //心击一战
        DanceOfSwallow = 428,           //鹰击蝶舞
        DarkConversion = 429,           //暗黑转换
        DragonRepulse = 430,            //星云锁链
        AdventOfDemon = 431,            //修罗降临
        AdventOfDevil = 432,            //罗刹降临
        Abyss = 433,                    //深渊苦海
        FlashOfLight = 434,             //一闪
        Stealth = 435,                  //银轮
        Evasion = 436,                  //疾风
        RagingWind = 437,               //狂风
        AdvancedBloodyFlower = 438,     //高级百花盛开
        Massacre = 439,                 //讨伐
        ArtOfShadows = 440,             //影魅乱舞

        MonsterScortchedEarth = 501,
        MonsterIceStorm = 502,
        MonsterDeathCloud = 503,
        MonsterThunderStorm = 504,

        SamaGuardianFire = 505,
        SamaGuardianIce = 506,
        SamaGuardianLightning = 507,
        SamaGuardianWind = 508,

        SamaPhoenixFire = 509,
        SamaBlackIce = 510,
        SamaBlueLightning = 511,
        SamaWhiteWind = 512,

        SamaProphetFire = 513,
        SamaProphetLightning = 514,
        SamaProphetWind = 515,

        DoomClawLeftPinch = 520,
        DoomClawLeftSwipe = 521,
        DoomClawRightPinch = 522,
        DoomClawRightSwipe = 523,
        DoomClawWave = 524,
        DoomClawSpit = 525,

        PinkFireBall = 530,
        GreenSludgeBall = 540,

        IgyuScorchedEarth = 552, // 0x00000228
        IgyuCyclone = 553, // 0x00000229
        Qierbian = 554, // 0x0000022A
    }


    public enum MonsterImage
    {
        None,
        Guard,
        Chicken,
        Pig,
        Deer,
        Cow,
        Sheep,
        ClawCat,
        Wolf,
        ForestYeti,
        ChestnutTree,
        CarnivorousPlant,
        Oma,
        TigerSnake,
        SpittingSpider,
        Scarecrow,
        OmaHero,
        CaveBat,
        Scorpion,
        Skeleton,
        SkeletonAxeMan,
        SkeletonAxeThrower,
        SkeletonWarrior,
        SkeletonLord,
        CaveMaggot,
        GhostSorcerer,
        GhostMage,
        VoraciousGhost,
        DevouringGhost,
        CorpseRaisingGhost,
        GhoulChampion,
        ArmoredAnt,
        AntSoldier,
        AntHealer,
        AntNeedler,
        ShellNipper,
        Beetle,
        VisceralWorm,
        MutantFlea,
        PoisonousMutantFlea,
        BlasterMutantFlea,
        WasHatchling,
        Centipede,
        ButterflyWorm,
        MutantMaggot,
        Earwig,
        IronLance,
        LordNiJae,
        RottingGhoul,
        DecayingGhoul,
        BloodThirstyGhoul,
        SpinedDarkLizard,
        UmaInfidel,
        UmaFlameThrower,
        UmaAnguisher,
        UmaKing,
        SpiderBat,
        ArachnidGazer,
        Larva,
        RedMoonGuardian,
        RedMoonProtector,
        VenomousArachnid,
        DarkArachnid,
        RedMoonTheFallen,
        ZumaSharpShooter,
        ZumaFanatic,
        ZumaGuardian,
        ViciousRat,
        ZumaKing,
        EvilFanatic,
        Monkey,
        EvilElephant,
        CannibalFanatic,
        SpikedBeetle,
        NumaGrunt,
        NumaMage,
        NumaElite,
        SandShark,
        StoneGolem,
        WindfurySorceress,
        CursedCactus,
        NetherWorldGate,
        RagingLizard,
        SawToothLizard,
        MutantLizard,
        VenomSpitter,
        SonicLizard,
        GiantLizard,
        CrazedLizard,
        TaintedTerror,
        DeathLordJichon,
        Minotaur,
        FrostMinotaur,
        ShockMinotaur,
        FlameMinotaur,
        FuryMinotaur,
        BanyaLeftGuard,
        BanyaRightGuard,
        EmperorSaWoo,
        BoneArcher,
        BoneBladesman,
        BoneCaptain,
        BoneSoldier,
        ArchLichTaedu,
        WedgeMothLarva,
        LesserWedgeMoth,
        WedgeMoth,
        RedBoar,
        ClawSerpent,
        BlackBoar,
        TuskLord,
        RazorTusk,
        PinkGoddess,
        GreenGoddess,
        MutantCaptain,
        StoneGriffin,
        FlameGriffin,
        WhiteBone,
        Shinsu,
        InfernalSoldier,
        InfernalGuardian,
        InfernalWarrior,
        CorpseStalker,
        LightArmedSoldier,
        CorrosivePoisonSpitter,
        PhantomSoldier,
        MutatedOctopus,
        AquaLizard,
        Stomper,
        CrimsonNecromancer,
        ChaosKnight,
        PachonTheChaosBringer,
        NumaCavalry,
        NumaHighMage,
        NumaStoneThrower,
        NumaRoyalGuard,
        NumaArmoredSoldier,
        IcyRanger,
        IcyGoddess,
        IcySpiritWarrior,
        IcySpiritGeneral,
        GhostKnight,
        IcySpiritSpearman,
        Werewolf,
        Whitefang,
        IcySpiritSolider,
        WildBoar,
        JinamStoneGate,
        FrostLordHwa,
        Companion_Pig,
        Companion_TuskLord,
        Companion_SkeletonLord,
        Companion_Griffin,
        Companion_Dragon,
        Companion_Donkey,
        Companion_Sheep,
        Companion_BanyoLordGuzak,
        Companion_Panda,
        Companion_Rabbit,
        JinchonDevil,
        OmaWarlord,
        EscortCommander,
        FieryDancer,
        EmeraldDancer,
        QueenOfDawn,
        OYoungBeast,
        YumgonWitch,
        MaWarlord,
        JinhwanSpirit,
        JinhwanGuardian,
        YumgonGeneral,
        ChiwooGeneral,
        DragonQueen,
        DragonLord,
        FerociousIceTiger,
        SamaFireGuardian,
        SamaIceGuardian,
        SamaLightningGuardian,
        SamaWindGuardian,
        Phoenix,
        BlackTortoise,
        BlueDragon,
        WhiteTiger,
        SamaCursedBladesman,
        SamaCursedSlave,
        SamaCursedFlameMage,
        SamaProphet,
        SamaSorcerer,
        EnshrinementBox,
        BloodStone,
        OrangeTiger,
        RegularTiger,
        RedTiger,
        SnowTiger,
        BlackTiger,
        BigBlackTiger,
        BigWhiteTiger,
        OrangeBossTiger,
        BigBossTiger,
        WildMonkey,
        FrostYeti,
        EvilSnake,
        Salamander,
        SandGolem,
        SDMob4,
        SDMob5,
        SDMob6,
        SDMob7,
        OmaMage,
        SDMob9,
        SDMob10,
        SDMob11,
        SDMob12,
        SDMob13,
        SDMob14,
        CrystalGolem,
        DustDevil,
        TwinTailScorpion,
        BloodyMole,
        SDMob19,
        SDMob20,
        SDMob21,
        SDMob22,
        SDMob23,
        SDMob24,
        SDMob25,
        GangSpider,
        VenomSpider,
        SDMob26,
        LobsterLord,
        LobsterSpawn,
        NewMob1,
        NewMob2,
        NewMob3,
        NewMob4,
        NewMob5,
        NewMob6,
        NewMob7,
        NewMob8,
        NewMob9,
        NewMob10,
        MonasteryMon0,
        MonasteryMon1,
        MonasteryMon2,
        MonasteryMon3,
        MonasteryMon4,
        MonasteryMon5,
        MonasteryMon6,
        Taishan01,
        Taishan02,
        Taishan03,
        Taishan04,
        Taishan05,
        Taishan06,
        Taishan07,
        Yuehe00,
        Yuehe01,
        Yuehe02,
        Yuehe03,
        Yuehe04,
        Yuehe05,
        Yuehe06,
        Dashewan,
        GardenSoldier,
        GardenDefender,
        RedBlossom,
        BlueBlossom,
        FireBird,
        Taohua06,
        Taohua07,
        Taohua08,
        Taohua09,
        Benma01,
        Benma02,
        Benma03,
        Qinling01,
        Qinling02,
        Qinling03,
        Qinling04,
        Qinling05,
        Qinling06,
        Qinling07,
        Qinling08,
        Qinling09,
        Qinling10,
        Companion_Snow,
        CrazedPrimate,
        HellBringer,
        YurinMon0,
        YurinMon1,
        WhiteBeardedTiger,
        BlackBeardedTiger,
        HardenedRhino,
        Mammoth,
        CursedSlave1,
        CursedSlave2,
        CursedSlave3,
        PoisonousGolem,
        Huanjingsamll,
        Huolong,
        Luwang,
        Yangling,
        Zhandouji,
        Wolong1,
        Wolong2,
        Wolong3,
        Wolong4,
        Wolong5,
        ShengdanMan,
        ShengdanTree,
        Haidi01,
        Haidi02,
        Haidi03,
        Haidi04,
        Haidi05,
        Haidi06,
        Haidi07,
        Zhangyu,
        Yanhua,
        Nian,
        Bindu,
        Qitiandashen,
        NewSenlingXueren,
        红狐,
        白狐,
        黄狐,
        镜中仙,
        五雷使,
        白泽,
        混沌,
        Mon63_1,
        Mon63_2,
        Mon63_5,
        Mon63_6,
        Mon63_7,
        Mon63_8,
        Mon63_9,
    }

    public enum MapIcon
    {
        None,
        Cave,
        Exit,
        Down,
        Up,
        Province,
        Building
    }

    public enum Effect
    {
        TeleportOut,
        TeleportIn,

        //??
        FullBloom,
        WhiteLotus,
        RedLotus,
        SweetBrier,
        Karma,

        Puppet,
        PuppetFire,
        PuppetIce,
        PuppetLightning,
        PuppetWind,

        SummonSkeleton,
        SummonShinsu,

        ThunderBolt,
        DanceOfSwallow,
        FlashOfLight,

        DemonExplosion,
        FrostBiteEnd
    }

    [Flags]
    public enum PoisonType
    {
        None = 0,
        Green = 1,
        Red = 2,
        Slow = 4,
        Paralysis = 8,
        WraithGrip = 16,
        HellFire = 32,
        Silenced = 64,
        Abyss = 128,
        Infection = 256,
    }

    public enum SpellEffect
    {
        None,

        SafeZone,


        FireWall,
        MonsterFireWall,
        Tempest,

        TrapOctagon,

        PoisonousCloud,

        Rubble,

        MonsterDeathCloud,

        QierBian,

    }

    public enum MarketPlaceSort
    {
        [Description("最新的")] Newest,
        [Description("最早的")] Oldest,
        [Description("最高价格")] HighestPrice,
        [Description("最低价格")] LowestPrice,
    }


    public enum MarketPlaceStoreSort
    {
        [Description("名称")] Alphabetical,
        [Description("最高价格")] HighestPrice,
        [Description("最低价格")] LowestPrice,
        [Description("喜好")] Favourite
    }

    public enum RefineType : byte
    {
        None,
        Durability,
        DC,
        SpellPower,
        Fire,
        Ice,
        Lightning,
        Wind,
        Holy,
        Dark,
        Phantom,
        Reset,
        Health,
        Mana,
        AC,
        MR,
        Accuracy,
        Agility,
        DCPercent,
        SPPercent,
        HealthPercent,
        ManaPercent,
    }

    public enum RefineQuality : byte
    {
        [Description("立刻")] Rush,
        [Description("较快")] Quick,
        [Description("标准")] Standard,
        [Description("仔细")] Careful,
        [Description("大师")] Precise,
    }

    public enum ItemEffect : byte
    {
        None,

        Gold = 1,
        Experience = 2,
        CompanionTicket = 3,
        BasicCompanionBag = 4,
        PickAxe = 5,
        UmaKingHorn = 6,
        ItemPart = 7,
        Carrot = 8,

        DestructionElixir = 10,
        HasteElixir = 11,
        LifeElixir = 12,
        ManaElixir = 13,
        NatureElixir = 14,
        SpiritElixir = 15,

        BlackIronOre = 20,
        GoldOre = 21,
        Diamond = 22,
        SilverOre = 23,
        IronOre = 24,
        Corundum = 25,

        ElixirOfPurification = 30,
        PillOfReincarnation = 31,

        Crystal = 40,
        RefinementStone = 41,
        Fragment1 = 42,
        Fragment2 = 43,
        Fragment3 = 44,

        GenderChange = 50,
        HairChange = 51,
        ArmourDye = 52,
        NameChange = 53,
        FortuneChecker = 54,

        WeaponTemplate = 60,
        WarriorWeapon = 61,
        WizardWeapon = 63,
        TaoistWeapon = 64,
        AssassinWeapon = 65,

        YellowSlot = 70,
        BlueSlot = 71,
        RedSlot = 72,
        PurpleSlot = 73,
        GreenSlot = 74,
        GreySlot = 75,

        FootballArmour = 80,
        FootBallWhistle = 81,

        StatExtractor = 90,
        SpiritBlade = 91,
        RefineExtractor = 92,
    }

    [Flags]
    public enum UserItemFlags
    {
        None = 0,
        
        Locked = 1,
        Bound = 2,
        Worthless = 4,
        Refinable = 8,
        Expirable = 16,
        QuestItem = 32,
        GameMaster = 64,
        Marriage = 128,
        NonRefinable = 256
    }
    
    public enum HorseType : byte
    {
        None,
        Brown,
        White,
        Red,
        Black,
    }

    [Flags]
    public enum GuildPermission
    {
        None = 0,

        Leader = -1,

        EditNotice = 1,
        AddMember = 2,
        RemoveMember = 4,
        Storage = 8,
        FundsRepair = 16,
        FundsMerchant = 32,
        FundsMarket = 64,
        StartWar = 128,
    }

    [Flags]
    public enum QuestIcon
    {
        None = 0,

        NewQuest = 1,
        QuestIncomplete = 2,
        QuestComplete = 4,


        NewRepeatable = 8,
        RepeatableComplete = 16,
    }

    public enum MovementEffect
    {
        None = 0,

        SpecialRepair = 1,
    }

    public enum SpellKey : byte
    {
        None,

        [Description("F1")]
        Spell01,
        [Description("F2")]
        Spell02,
        [Description("F3")]
        Spell03,
        [Description("F4")]
        Spell04,
        [Description("F5")]
        Spell05,
        [Description("F6")]
        Spell06,
        [Description("F7")]
        Spell07,
        [Description("F8")]
        Spell08,
        [Description("F9")]
        Spell09,
        [Description("F10")]
        Spell10,
        [Description("F11")]
        Spell11,
        [Description("F12")]
        Spell12,

        [Description("Key\n13")]
        Spell13,
        [Description("Key\n14")]
        Spell14,
        [Description("Key\n15")]
        Spell15,
        [Description("Key\n16")]
        Spell16,
        [Description("Key\n17")]
        Spell17,
        [Description("Key\n18")]
        Spell18,
        [Description("Key\n19")]
        Spell19,
        [Description("Key\n20")]
        Spell20,
        [Description("Key\n21")]
        Spell21,
        [Description("Key\n22")]
        Spell22,
        [Description("Key\n23")]
        Spell23,
        [Description("Key\n24")]
        Spell24,
    }

    public enum MonsterFlag
    {
        None = 0,

        Skeleton = 1,
        JinSkeleton = 2,
        Shinsu = 3,
        InfernalSoldier = 4,
        Scarecrow = 5,

        SummonPuppet = 6,

        MirrorImage = 7,


        Larva = 100,

        LesserWedgeMoth = 110,

        ZumaArcherMonster = 120,
        ZumaGuardianMonster = 121,
        ZumaFanaticMonster = 122,
        ZumaKeeperMonster = 123,

        BoneArcher = 130,
        BoneCaptain = 131,
        BoneBladesman = 132,
        BoneSoldier = 133,
        SkeletonEnforcer = 134,

        MatureEarwig = 140,
        GoldenArmouredBeetle = 141,
        Millipede = 142,

        FerociousFlameDemon = 150,
        FlameDemon = 151,

        GoruSpearman = 160,
        GoruArcher = 161,
        GoruGeneral = 162,

        DragonLord = 170,
        OYoungBeast = 171,
        YumgonWitch = 172,
        MaWarden = 173,
        MaWarlord = 174,
        JinhwanSpirit = 175,
        JinhwanGuardian = 176,
        OyoungGeneral = 177,
        YumgonGeneral = 178,

        BanyoCaptain = 180,

        SamaSorcerer = 190,
        BloodStone = 191,

        QuartzPinkBat = 200,
        QuartzBlueBat = 201,
        QuartzBlueCrystal = 202,
        QuartzRedHood = 203,
        QuartzMiniTurtle = 204,
        QuartzTurtleSub = 205,

        Sacrafice = 210,
    }

    #region Packet Enums

    public enum NewAccountResult : byte
    {
        Disabled,
        BadEMail,
        BadPassword,
        BadRealName,
        AlreadyExists,
        BadReferral,
        ReferralNotFound,
        ReferralNotActivated,
        Success
    }

    public enum ChangePasswordResult : byte
    {
        Disabled,
        BadEMail,
        BadCurrentPassword,
        BadNewPassword,
        AccountNotFound,
        AccountNotActivated,
        WrongPassword,
        Banned,
        Success
    }
    public enum RequestPasswordResetResult : byte
    {
        Disabled,
        BadEMail,
        AccountNotFound,
        AccountNotActivated,
        ResetDelay,
        Banned,
        Success
    }
    public enum ResetPasswordResult : byte
    {
        Disabled,
        AccountNotFound,
        BadNewPassword,
        KeyExpired,
        Success
    }
    

    public enum ActivationResult : byte
    {
        Disabled,
        AccountNotFound,
        Success,
    }

    public enum RequestActivationKeyResult : byte
    {
        Disabled,
        BadEMail,
        AccountNotFound,
        AlreadyActivated,
        RequestDelay,
        Success,
    }

    public enum LoginResult : byte
    {
        Disabled,
        BadEMail,
        BadPassword,
        AccountNotExists,
        AccountNotActivated,
        WrongPassword,
        Banned,
        AlreadyLoggedIn,
        AlreadyLoggedInPassword,
        AlreadyLoggedInAdmin,
        Success
    }

    public enum NewCharacterResult : byte
    {
        Disabled,
        BadCharacterName,
        BadGender,
        BadClass,
        BadHairType,
        BadHairColour,
        BadArmourColour,
        ClassDisabled,
        MaxCharacters,
        AlreadyExists,
        Success
    }

    public enum DeleteCharacterResult : byte
    {
        Disabled,
        AlreadyDeleted,
        NotFound,
        Success
    }

    public enum StartGameResult : byte
    {
        Disabled,
        Deleted,
        Delayed,
        UnableToSpawn,
        NotFound,
        Success
    }

    public enum DisconnectReason : byte
    {
        Unknown,
        TimedOut,
        WrongVersion,
        ServerClosing,
        AnotherUser,
        AnotherUserPassword,
        AnotherUserAdmin,
        Banned,
        Crashed
    }




    #endregion

    #region Sound

    public enum SoundIndex
    {
        None,
        LoginScene,
        SelectScene,
        B000,
        B2,
        B8,
        B009D,
        B009N,
        B0014D,
        B0014N,
        B100,
        B122,
        B300,
        B400,
        B14001,
        BD00,
        BD01,
        BD02,
        BD041,
        BD042,
        BD50,
        BD60,
        BD70,
        BD99,
        BD100,
        BD101,
        BD210,
        BD211,
        BDUnderseaCave,
        BDUnderseaCaveBoss,
        D3101,
        D3102,
        D3400,
        Dungeon_1,
        Dungeon_2,
        ID1_001,
        ID1_002,
        ID1_003,
        TS001,
        TS002,
        TS003,
        Caomiaocun,
        Xueyuan,
        Kunlun,
        Taishan,
        Saiwai,
        Benmadao,
        Qinling,
        Zhenyuan,
        Huanjing,
        WolongMusic,
        ChristmasSong,
        TaoyuanMusic,
        ButtonA,
        ButtonB,
        ButtonC,
        SelectWarriorMale,
        SelectWarriorFemale,
        SelectWizardMale,
        SelectWizardFemale,
        SelectTaoistMale,
        SelectTaoistFemale,
        SelectAssassinMale,
        SelectAssassinFemale,
        TeleportOut,
        TeleportIn,
        ItemPotion,
        ItemWeapon,
        ItemArmour,
        ItemRing,
        ItemBracelet,
        ItemNecklace,
        ItemHelmet,
        ItemShoes,
        ItemDefault,
        GoldPickUp,
        GoldGained,
        DaggerSwing,
        WoodSwing,
        IronSwordSwing,
        ShortSwordSwing,
        AxeSwing,
        ClubSwing,
        WandSwing,
        FistSwing,
        GlaiveAttack,
        ClawAttack,
        GenericStruckPlayer,
        GenericStruckMonster,
        Foot1,
        Foot2,
        Foot3,
        Foot4,
        HorseWalk1,
        HorseWalk2,
        HorseRun,
        MaleStruck,
        FemaleStruck,
        MaleDie,
        FemaleDie,
        SlayingMale,
        SlayingFemale,
        EnergyBlast,
        HalfMoon,
        FlamingSword,
        DragonRise,
        BladeStorm,
        DestructiveBlow,
        DefianceStart,
        AssaultStart,
        SwiftBladeEnd,
        CrushingWave,
        FireBallStart,
        FireBallTravel,
        FireBallEnd,
        ThunderBoltStart,
        ThunderBoltTravel,
        ThunderBoltEnd,
        IceBoltStart,
        IceBoltTravel,
        IceBoltEnd,
        GustBlastStart,
        GustBlastTravel,
        GustBlastEnd,
        RepulsionEnd,
        ElectricShockStart,
        ElectricShockEnd,
        GreaterFireBallStart,
        GreaterFireBallTravel,
        GreaterFireBallEnd,
        LightningStrikeStart,
        LightningStrikeEnd,
        GreaterIceBoltStart,
        GreaterIceBoltTravel,
        GreaterIceBoltEnd,
        CycloneStart,
        CycloneEnd,
        TeleportationStart,
        LavaStrikeStart,
        LightningBeamEnd,
        FrozenEarthStart,
        FrozenEarthEnd,
        BlowEarthStart,
        BlowEarthEnd,
        BlowEarthTravel,
        FireWallStart,
        FireWallEnd,
        ExpelUndeadStart,
        ExpelUndeadEnd,
        MagicShieldStart,
        FireStormStart,
        FireStormEnd,
        LightningWaveStart,
        LightningWaveEnd,
        IceStormStart,
        IceStormEnd,
        DragonTornadoStart,
        DragonTornadoEnd,
        GreaterFrozenEarthStart,
        GreaterFrozenEarthEnd,
        ChainLightningStart,
        ChainLightningEnd,
        FrostBiteStart,
        ElementalHurricane,
        HealStart,
        HealEnd,
        PoisonDustStart,
        PoisonDustEnd,
        ExplosiveTalismanStart,
        ExplosiveTalismanTravel,
        ExplosiveTalismanEnd,
        HolyStrikeStart,
        HolyStrikeTravel,
        HolyStrikeEnd,
        ImprovedHolyStrikeStart,
        ImprovedHolyStrikeTravel,
        ImprovedHolyStrikeEnd,
        MagicResistanceTravel,
        MagicResistanceEnd,
        ResilienceTravel,
        ResilienceEnd,
        ShacklingTalismanStart,
        ShacklingTalismanEnd,
        SummonSkeletonStart,
        SummonSkeletonEnd,
        InvisibilityEnd,
        MassInvisibilityTravel,
        MassInvisibilityEnd,
        TaoistCombatKickStart,
        MassHealStart,
        MassHealEnd,
        BloodLustTravel,
        BloodLustEnd,
        ResurrectionStart,
        PurificationStart,
        PurificationEnd,
        SummonShinsuStart,
        SummonShinsuEnd,
        StrengthOfFaithStart,
        StrengthOfFaithEnd,
        NeutralizeEnd,
        DarkSoulPrison,
        PoisonousCloudStart,
        CloakStart,
        WraithGripStart,
        WraithGripEnd,
        HellFireStart,
        FullBloom,
        WhiteLotus,
        RedLotus,
        SweetBrier,
        SweetBrierMale,
        SweetBrierFemale,
        Karma,
        TheNewBeginning,
        SummonPuppet,
        DanceOfSwallowsEnd,
        DragonRepulseStart,
        AbyssStart,
        FlashOfLightEnd,
        EvasionStart,
        RagingWindStart,
        Concentration,
        XuanfengZhan,
        Xuanlonghuansha,
        Xuanlonghuansha1,
        Laosunlaiye,
        ChickenAttack,
        ChickenStruck,
        ChickenDie,
        PigAttack,
        PigStruck,
        PigDie,
        DeerAttack,
        DeerStruck,
        DeerDie,
        CowAttack,
        CowStruck,
        CowDie,
        SheepAttack,
        SheepStruck,
        SheepDie,
        ClawCatAttack,
        ClawCatStruck,
        ClawCatDie,
        WolfAttack,
        WolfStruck,
        WolfDie,
        ForestYetiAttack,
        ForestYetiStruck,
        ForestYetiDie,
        CarnivorousPlantAttack,
        CarnivorousPlantStruck,
        CarnivorousPlantDie,
        OmaAttack,
        OmaStruck,
        OmaDie,
        TigerSnakeAttack,
        TigerSnakeStruck,
        TigerSnakeDie,
        SpittingSpiderAttack,
        SpittingSpiderStruck,
        SpittingSpiderDie,
        ScarecrowAttack,
        ScarecrowStruck,
        ScarecrowDie,
        OmaHeroAttack,
        OmaHeroStruck,
        OmaHeroDie,
        CaveBatAttack,
        CaveBatStruck,
        CaveBatDie,
        ScorpionAttack,
        ScorpionStruck,
        ScorpionDie,
        SkeletonAttack,
        SkeletonStruck,
        SkeletonDie,
        SkeletonAxeManAttack,
        SkeletonAxeManStruck,
        SkeletonAxeManDie,
        SkeletonAxeThrowerAttack,
        SkeletonAxeThrowerStruck,
        SkeletonAxeThrowerDie,
        SkeletonWarriorAttack,
        SkeletonWarriorStruck,
        SkeletonWarriorDie,
        SkeletonLordAttack,
        SkeletonLordStruck,
        SkeletonLordDie,
        CaveMaggotAttack,
        CaveMaggotStruck,
        CaveMaggotDie,
        GhostSorcererAttack,
        GhostSorcererStruck,
        GhostSorcererDie,
        GhostMageAppear,
        GhostMageAttack,
        GhostMageStruck,
        GhostMageDie,
        VoraciousGhostAttack,
        VoraciousGhostStruck,
        VoraciousGhostDie,
        GhoulChampionAttack,
        GhoulChampionStruck,
        GhoulChampionDie,
        ArmoredAntAttack,
        ArmoredAntStruck,
        ArmoredAntDie,
        AntNeedlerAttack,
        AntNeedlerStruck,
        AntNeedlerDie,
        KeratoidAttack,
        KeratoidStruck,
        KeratoidDie,
        ShellNipperAttack,
        ShellNipperStruck,
        ShellNipperDie,
        VisceralWormAttack,
        VisceralWormStruck,
        VisceralWormDie,
        MutantFleaAttack,
        MutantFleaStruck,
        MutantFleaDie,
        PoisonousMutantFleaAttack,
        PoisonousMutantFleaStruck,
        PoisonousMutantFleaDie,
        BlasterMutantFleaAttack,
        BlasterMutantFleaStruck,
        BlasterMutantFleaDie,
        WasHatchlingAttack,
        WasHatchlingStruck,
        WasHatchlingDie,
        CentipedeAttack,
        CentipedeStruck,
        CentipedeDie,
        ButterflyWormAttack,
        ButterflyWormStruck,
        ButterflyWormDie,
        MutantMaggotAttack,
        MutantMaggotStruck,
        MutantMaggotDie,
        EarwigAttack,
        EarwigStruck,
        EarwigDie,
        IronLanceAttack,
        IronLanceStruck,
        IronLanceDie,
        LordNiJaeAttack,
        LordNiJaeStruck,
        LordNiJaeDie,
        RottingGhoulAttack,
        RottingGhoulStruck,
        RottingGhoulDie,
        DecayingGhoulAttack,
        DecayingGhoulStruck,
        DecayingGhoulDie,
        BloodThirstyGhoulAttack,
        BloodThirstyGhoulStruck,
        BloodThirstyGhoulDie,
        SpinedDarkLizardAttack,
        SpinedDarkLizardStruck,
        SpinedDarkLizardDie,
        UmaInfidelAttack,
        UmaInfidelStruck,
        UmaInfidelDie,
        UmaFlameThrowerAttack,
        UmaFlameThrowerStruck,
        UmaFlameThrowerDie,
        UmaAnguisherAttack,
        UmaAnguisherStruck,
        UmaAnguisherDie,
        UmaKingAttack,
        UmaKingStruck,
        UmaKingDie,
        SpiderBatAttack,
        SpiderBatStruck,
        SpiderBatDie,
        ArachnidGazerStruck,
        ArachnidGazerDie,
        LarvaAttack,
        LarvaStruck,
        RedMoonGuardianAttack,
        RedMoonGuardianStruck,
        RedMoonGuardianDie,
        RedMoonProtectorAttack,
        RedMoonProtectorStruck,
        RedMoonProtectorDie,
        VenomousArachnidAttack,
        VenomousArachnidStruck,
        VenomousArachnidDie,
        DarkArachnidAttack,
        DarkArachnidStruck,
        DarkArachnidDie,
        RedMoonTheFallenAttack,
        RedMoonTheFallenStruck,
        RedMoonTheFallenDie,
        ViciousRatAttack,
        ViciousRatStruck,
        ViciousRatDie,
        ZumaSharpShooterAttack,
        ZumaSharpShooterStruck,
        ZumaSharpShooterDie,
        ZumaFanaticAttack,
        ZumaFanaticStruck,
        ZumaFanaticDie,
        ZumaGuardianAttack,
        ZumaGuardianStruck,
        ZumaGuardianDie,
        ZumaKingAppear,
        ZumaKingAttack,
        ZumaKingStruck,
        ZumaKingDie,
        EvilFanaticAttack,
        EvilFanaticStruck,
        EvilFanaticDie,
        MonkeyAttack,
        MonkeyStruck,
        MonkeyDie,
        EvilElephantAttack,
        EvilElephantStruck,
        EvilElephantDie,
        CannibalFanaticAttack,
        CannibalFanaticStruck,
        CannibalFanaticDie,
        SpikedBeetleAttack,
        SpikedBeetleStruck,
        SpikedBeetleDie,
        NumaGruntAttack,
        NumaGruntStruck,
        NumaGruntDie,
        NumaMageAttack,
        NumaMageStruck,
        NumaMageDie,
        NumaEliteAttack,
        NumaEliteStruck,
        NumaEliteDie,
        SandSharkAttack,
        SandSharkStruck,
        SandSharkDie,
        StoneGolemAppear,
        StoneGolemAttack,
        StoneGolemStruck,
        StoneGolemDie,
        WindfurySorceressAttack,
        WindfurySorceressStruck,
        WindfurySorceressDie,
        CursedCactusAttack,
        CursedCactusStruck,
        CursedCactusDie,
        RagingLizardAttack,
        RagingLizardStruck,
        RagingLizardDie,
        SawToothLizardAttack,
        SawToothLizardStruck,
        SawToothLizardDie,
        MutantLizardAttack,
        MutantLizardStruck,
        MutantLizardDie,
        VenomSpitterAttack,
        VenomSpitterStruck,
        VenomSpitterDie,
        SonicLizardAttack,
        SonicLizardStruck,
        SonicLizardDie,
        GiantLizardAttack,
        GiantLizardStruck,
        GiantLizardDie,
        CrazedLizardAttack,
        CrazedLizardStruck,
        CrazedLizardDie,
        TaintedTerrorAttack,
        TaintedTerrorStruck,
        TaintedTerrorDie,
        TaintedTerrorAttack2,
        DeathLordJichonAttack,
        DeathLordJichonStruck,
        DeathLordJichonDie,
        DeathLordJichonAttack2,
        DeathLordJichonAttack3,
        MinotaurAttack,
        MinotaurStruck,
        MinotaurDie,
        FrostMinotaurAttack,
        FrostMinotaurStruck,
        FrostMinotaurDie,
        BanyaLeftGuardAttack,
        BanyaLeftGuardStruck,
        BanyaLeftGuardDie,
        EmperorSaWooAttack,
        EmperorSaWooStruck,
        EmperorSaWooDie,
        BoneArcherAttack,
        BoneArcherStruck,
        BoneArcherDie,
        BoneCaptainAttack,
        BoneCaptainStruck,
        BoneCaptainDie,
        ArchLichTaeduAttack,
        ArchLichTaeduStruck,
        ArchLichTaeduDie,
        WedgeMothLarvaAttack,
        WedgeMothLarvaStruck,
        WedgeMothLarvaDie,
        LesserWedgeMothAttack,
        LesserWedgeMothStruck,
        LesserWedgeMothDie,
        WedgeMothAttack,
        WedgeMothStruck,
        WedgeMothDie,
        RedBoarAttack,
        RedBoarStruck,
        RedBoarDie,
        ClawSerpentAttack,
        ClawSerpentStruck,
        ClawSerpentDie,
        BlackBoarAttack,
        BlackBoarStruck,
        BlackBoarDie,
        TuskLordAttack,
        TuskLordStruck,
        TuskLordDie,
        RazorTuskAttack,
        RazorTuskStruck,
        RazorTuskDie,
        PinkGoddessAttack,
        PinkGoddessStruck,
        PinkGoddessDie,
        GreenGoddessAttack,
        GreenGoddessStruck,
        GreenGoddessDie,
        MutantCaptainAttack,
        MutantCaptainStruck,
        MutantCaptainDie,
        StoneGriffinAttack,
        StoneGriffinStruck,
        StoneGriffinDie,
        FlameGriffinAttack,
        FlameGriffinStruck,
        FlameGriffinDie,
        WhiteBoneAttack,
        WhiteBoneStruck,
        WhiteBoneDie,
        ShinsuSmallStruck,
        ShinsuSmallDie,
        ShinsuBigAttack,
        ShinsuBigStruck,
        ShinsuBigDie,
        ShinsuShow,
        CorpseStalkerAttack,
        CorpseStalkerStruck,
        CorpseStalkerDie,
        LightArmedSoldierAttack,
        LightArmedSoldierStruck,
        LightArmedSoldierDie,
        CorrosivePoisonSpitterAttack,
        CorrosivePoisonSpitterStruck,
        CorrosivePoisonSpitterDie,
        PhantomSoldierAttack,
        PhantomSoldierStruck,
        PhantomSoldierDie,
        MutatedOctopusAttack,
        MutatedOctopusStruck,
        MutatedOctopusDie,
        AquaLizardAttack,
        AquaLizardStruck,
        AquaLizardDie,
        CrimsonNecromancerAttack,
        CrimsonNecromancerStruck,
        CrimsonNecromancerDie,
        ChaosKnightAttack,
        ChaosKnightStruck,
        ChaosKnightDie,
        PachontheChaosbringerAttack,
        PachontheChaosbringerStruck,
        PachontheChaosbringerDie,
        NumaCavalryAttack,
        NumaCavalryStruck,
        NumaCavalryDie,
        NumaHighMageAttack,
        NumaHighMageStruck,
        NumaHighMageDie,
        NumaStoneThrowerAttack,
        NumaStoneThrowerStruck,
        NumaStoneThrowerDie,
        NumaRoyalGuardAttack,
        NumaRoyalGuardStruck,
        NumaRoyalGuardDie,
        NumaArmoredSoldierAttack,
        NumaArmoredSoldierStruck,
        NumaArmoredSoldierDie,
        IcyRangerAttack,
        IcyRangerStruck,
        IcyRangerDie,
        IcyGoddessAttack,
        IcyGoddessStruck,
        IcyGoddessDie,
        IcySpiritWarriorAttack,
        IcySpiritWarriorStruck,
        IcySpiritWarriorDie,
        IcySpiritGeneralAttack,
        IcySpiritGeneralStruck,
        IcySpiritGeneralDie,
        GhostKnightAttack,
        GhostKnightStruck,
        GhostKnightDie,
        IcySpiritSpearmanAttack,
        IcySpiritSpearmanStruck,
        IcySpiritSpearmanDie,
        WerewolfAttack,
        WerewolfStruck,
        WerewolfDie,
        WhitefangAttack,
        WhitefangStruck,
        WhitefangDie,
        IcySpiritSoliderAttack,
        IcySpiritSoliderStruck,
        IcySpiritSoliderDie,
        WildBoarAttack,
        WildBoarStruck,
        WildBoarDie,
        FrostLordHwaAttack,
        FrostLordHwaStruck,
        FrostLordHwaDie,
        JinchonDevilAttack,
        JinchonDevilAttack2,
        JinchonDevilAttack3,
        JinchonDevilStruck,
        JinchonDevilDie,
        EscortCommanderAttack,
        EscortCommanderStruck,
        EscortCommanderDie,
        FieryDancerAttack,
        FieryDancerStruck,
        FieryDancerDie,
        EmeraldDancerAttack,
        EmeraldDancerStruck,
        EmeraldDancerDie,
        QueenOfDawnAttack,
        QueenOfDawnStruck,
        QueenOfDawnDie,
        OYoungBeastAttack,
        OYoungBeastStruck,
        OYoungBeastDie,
        YumgonWitchAttack,
        YumgonWitchStruck,
        YumgonWitchDie,
        MaWarlordAttack,
        MaWarlordStruck,
        MaWarlordDie,
        JinhwanSpiritAttack,
        JinhwanSpiritStruck,
        JinhwanSpiritDie,
        JinhwanGuardianAttack,
        JinhwanGuardianStruck,
        JinhwanGuardianDie,
        YumgonGeneralAttack,
        YumgonGeneralStruck,
        YumgonGeneralDie,
        ChiwooGeneralAttack,
        ChiwooGeneralStruck,
        ChiwooGeneralDie,
        DragonQueenAttack,
        DragonQueenStruck,
        DragonQueenDie,
        DragonLordAttack,
        DragonLordStruck,
        DragonLordDie,
        FerociousIceTigerAttack,
        FerociousIceTigerStruck,
        FerociousIceTigerDie,
        SamaFireGuardianAttack,
        SamaFireGuardianStruck,
        SamaFireGuardianDie,
        SamaIceGuardianAttack,
        SamaIceGuardianStruck,
        SamaIceGuardianDie,
        SamaLightningGuardianAttack,
        SamaLightningGuardianStruck,
        SamaLightningGuardianDie,
        SamaWindGuardianAttack,
        SamaWindGuardianStruck,
        SamaWindGuardianDie,
        PhoenixAttack,
        PhoenixStruck,
        PhoenixDie,
        BlackTortoiseAttack,
        BlackTortoiseStruck,
        BlackTortoiseDie,
        BlueDragonAttack,
        BlueDragonStruck,
        BlueDragonDie,
        WhiteTigerAttack,
        WhiteTigerStruck,
        WhiteTigerDie,
        GardenSoldierAttack,
        GardenSoldierAttack2,
        GardenSoldierStruck,
        GardenSoldierDie,
        GardenDefenderAttack,
        GardenDefenderAttack2,
        GardenDefenderStruck,
        GardenDefenderDie,
        RedBlossomAttack,
        RedBlossomAttack2,
        RedBlossomStruck,
        RedBlossomDie,
        BlueBlossomAttack,
        BlueBlossomStruck,
        BlueBlossomDie,
        FireBirdAttack,
        FireBirdAttack2,
        FireBirdAttack3,
        FireBirdStruck,
        FireBirdDie,
        CrazedPrimateAttack,
        CrazedPrimateStruck,
        CrazedPrimateDie,
        HellBringerAttack,
        HellBringerAttack2,
        HellBringerAttack3,
        HellBringerStruck,
        HellBringerDie,
        YurinHoundAttack,
        YurinHoundStruck,
        YurinHoundDie,
        YurinTigerAttack,
        YurinTigerStruck,
        YurinTigerDie,
        HardenedRhinoAttack,
        HardenedRhinoStruck,
        HardenedRhinoDie,
        MammothAttack,
        MammothStruck,
        MammothDie,
        CursedSlave1Attack,
        CursedSlave1Attack2,
        CursedSlave1Struck,
        CursedSlave1Die,
        CursedSlave2Attack,
        CursedSlave2Struck,
        CursedSlave2Die,
        CursedSlave3Attack,
        CursedSlave3Attack2,
        CursedSlave3Struck,
        CursedSlave3Die,
        PoisonousGolemAttack,
        PoisonousGolemAttack2,
        PoisonousGolemStruck,
        PoisonousGolemDie,
        Qierbian,
        ThunderKickEnd,
        ThunderKickStart,
        RakeStart,

        WolongbianfuAttack,
        WolongbianfuAttack2,
        WolongbianfuStruck,
        WolongbianfuDie,
        OmaKingAttack,
        OmaKingAttack2,
        OmaKingStruck,
        OmaKingDie,
        WuguiAttack,
        WuguiAttack2,
        WuguiStruck,
        WuguiDie
    }
    #endregion

    public enum AutoSetConf
    {
        None = 0,
        SuijisBox = 1,
        SetShiftBox = 2,
        SetDisplayBox = 3,
        SetBrightBox = 4,
        SetCorpseBox = 5,
        SetFlamingSwordBox = 6,
        SetDragobRiseBox = 7,
        SetBladeStormBox = 8,
        SetMagicShieldBox = 9,
        SetRenounceBox = 10,
        SetPoisonDustBox = 11,
        SetCelestialBox = 12,
        SetFourFlowersBox = 13,
        SetMagicskillsBox = 14,
        SetMagicskills1Box = 15,
        SetAutoOnHookBox = 16,
        SuijiBox = 17,
        SetAutoPoisonBox = 18,
        SetAutoAvoidBox = 19,
        SetDeathResurrectionBox = 20,
        SetSingleHookSkillsBox = 21,
        SetGroupHookSkillsBox = 22,
        SetSummoningSkillsBox = 23,
        SetRandomItemBox = 24,
        SetHomeItemBox = 25,
        SetDefianceBox = 27,
        SetMightBox = 28,
        SetShowHealth = 29,
        SetEvasionBox = 30,
        SerRagingWindBox = 31,
        SetJsPickUpBox = 32,
        Kuaisuxiaotui = 33,
        SetAutojinpiaoBox = 34,
        SetMaxConf = 35,
        SetSwiftBladeBox = 36,
        SetThunderStrikeBox = 37,
    }

    public enum AccountIdentity : int
    {
        [Description("普通玩家")] Normal = 0,
        [Description("监督者")] Supervisor,
        [Description("运营者")] Operator,
        [Description("管理员")] Admin,
        [Description("超级管理员")] SuperAdmin,

    }
}