using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library.Network;

namespace Library
{
    public sealed class Stats
    {
        public SortedDictionary<Stat, int> Values { get; set; } = new SortedDictionary<Stat, int>();

        [IgnorePropertyPacket]
        public int Count => Values.Sum(pair => Math.Abs(pair.Value));

        [IgnorePropertyPacket]
        public int this[Stat stat]
        {
            get
            {
                int result;

                return !Values.TryGetValue(stat, out result) ? 0 : result;
            }
            set
            {
                if (value == 0)
                {
                    if (Values.ContainsKey(stat))
                        Values.Remove(stat);
                    return;
                }

                Values[stat] = value;
            }
        }

        public Stats()
        { }

        public Stats(Stats stats)
        {
            foreach (KeyValuePair<Stat, int> pair in stats.Values)
                this[pair.Key] += pair.Value;
        }
        public Stats(BinaryReader reader)
        {
            int count = reader.ReadInt32();

            for (int i = 0; i < count; i++)
                Values[(Stat) reader.ReadInt32()] = reader.ReadInt32();
        }
        public void Add(Stats stats, bool addElements = true)
        {
            foreach (KeyValuePair<Stat, int> pair in stats.Values)
                switch (pair.Key)
                {
                    case Stat.FireAttack:
                    case Stat.LightningAttack:
                    case Stat.IceAttack:
                    case Stat.WindAttack:
                    case Stat.HolyAttack:
                    case Stat.DarkAttack:
                    case Stat.PhantomAttack:
                        if (addElements)
                            this[pair.Key] += pair.Value;
                        break;
                    case Stat.ItemReviveTime:
                        if (pair.Value == 0) continue;

                        if (this[pair.Key] == 0)
                            this[pair.Key] = pair.Value;
                        else
                            this[pair.Key] = Math.Min(this[pair.Key], pair.Value);
                        break;
                    default:
                        this[pair.Key] += pair.Value;
                        break;
                }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Values.Count);

            foreach (KeyValuePair<Stat, int> pair in Values)
            {
                writer.Write((int)pair.Key);
                writer.Write(pair.Value);
            }

        }

        public string GetDisplay(Stat stat)
        {
            Type type = stat.GetType();

            MemberInfo[] infos = type.GetMember(stat.ToString());

            StatDescription description = infos[0].GetCustomAttribute<StatDescription>();

            if (description == null) return null;

            List<Stat> list;
            string value;
            bool neecComma;
            switch (description.Mode)
            {
                case StatType.None:
                    return null;
                case StatType.Default:
                    return description.Title + ": " + string.Format(description.Format, this[stat]);
                case StatType.Min:
                    if (this[description.MaxStat] != 0) return null;

                    return description.Title + ": " + string.Format(description.Format, this[stat]);
                case StatType.Max:
                    return description.Title + ": " + string.Format(description.Format, this[description.MinStat], this[stat]);
                case StatType.Percent:
                    return description.Title + ": " + string.Format(description.Format, this[stat]/100D);
                case StatType.Text:
                    return description.Title;
                case StatType.Time:
                    if (this[stat] < 0)
                        return description.Title + ": 永久";

                    return description.Title + ": " + Functions.ToString(TimeSpan.FromSeconds(this[stat]), true);
                case StatType.SpellPower:
                    if (description.MinStat == stat && this[description.MaxStat] != 0) return null;

                    if (this[Stat.MinMC] != this[Stat.MinSC] || this[Stat.MaxMC] != this[Stat.MaxSC])
                        return description.Title + ": " + string.Format(description.Format, this[description.MinStat], this[stat]);

                    if (stat != Stat.MaxSC) return null;


                    return "法术强度: " + string.Format(description.Format, this[description.MinStat], this[stat]);
                case StatType.AttackElement:

                    list = new List<Stat>();
                    foreach (KeyValuePair<Stat, int> pair in Values)
                        if (type.GetMember(pair.Key.ToString())[0].GetCustomAttribute<StatDescription>().Mode == StatType.AttackElement) list.Add(pair.Key);

                    if (list.Count == 0 || list[0] != stat)
                        return null;

                    value = $"元素攻击: ";

                    neecComma = false;
                    foreach (Stat s in list)
                    {
                        description = type.GetMember(s.ToString())[0].GetCustomAttribute<StatDescription>();

                        if (neecComma)
                            value += $", ";

                        value += $"{description.Title} +" + this[s];
                        neecComma = true;
                    }
                    return value;
                case StatType.ElementResistance:


                    list = new List<Stat>();
                    foreach (KeyValuePair<Stat, int> pair in Values)
                    {
                        if (type.GetMember(pair.Key.ToString())[0].GetCustomAttribute<StatDescription>().Mode == StatType.ElementResistance) list.Add(pair.Key);
                    }

                    if (list.Count == 0)
                        return null;

                    bool ei;
                    bool hasAdv = false, hasDis = false;

                    foreach (Stat s in list)
                    {
                        if (this[s] > 0)
                            hasAdv = true;

                        if (this[s] < 0)
                            hasDis = true;
                    }

                    if (!hasAdv) // EV Online
                    {
                        ei = false;

                        if (list[0] != stat) return null;
                    }
                    else
                    {
                        if (!hasDis && list[0] != stat) return null;

                        ei = list[0] == stat;

                        if (!ei && list[1] != stat) return null; //Impossible to be false and have less than 2 stats.
                    }
                    

                    value = ei ? $"元素抵抗: " : $"元素削弱: ";

                    neecComma = false;


                    foreach (Stat s in list)
                    {
                        description = type.GetMember(s.ToString())[0].GetCustomAttribute<StatDescription>();

                        if ((this[s] > 0) != ei) continue;

                        if (neecComma)
                            value += $", ";

                        value += $"{description.Title} x" + Math.Abs(this[s]);
                        neecComma = true;
                    }

                    return value;
                default: return null;
            }
        }


        public string GetFormat(Stat stat)
        {
            Type type = stat.GetType();

            MemberInfo[] infos = type.GetMember(stat.ToString());

            StatDescription description = infos[0].GetCustomAttribute<StatDescription>();

            if (description == null) return null;

            switch (description.Mode)
            {
                case StatType.Default:
                    return string.Format(description.Format, this[stat]);
                case StatType.Min:
                    return this[description.MaxStat] == 0 ? (string.Format(description.Format, this[stat])) : null;
                case StatType.Max:
                case StatType.SpellPower:
                    return string.Format(description.Format, this[description.MinStat], this[stat]);
                case StatType.Percent:
                    return string.Format(description.Format, this[stat] / 100D);
                case StatType.Text:
                    return description.Format;
                case StatType.Time:
                    if (this[stat] < 0)
                        return "Permanent";

                    return Functions.ToString(TimeSpan.FromSeconds(this[stat]), true);
                default: return null;
            }
        }

        public bool Compare(Stats s2)
        {
            if (Values.Count != s2.Values.Count) return false;

            foreach (KeyValuePair<Stat, int> value in Values)
                if (s2[value.Key] != value.Value) return false;

            return true;
        }

        public void Clear()
        {
            Values.Clear();
        }

        public bool HasElementalWeakness()
        {
            return 
                this[Stat.FireResistance] <= 0 && this[Stat.IceResistance] <= 0 && this[Stat.LightningResistance] <= 0 && this[Stat.WindResistance] <= 0 && 
                this[Stat.HolyResistance] <= 0 && this[Stat.DarkResistance] <= 0 &&
                this[Stat.PhantomResistance] <= 0 && this[Stat.PhysicalResistance] <= 0;

        }

        public Stat GetWeaponElement()
        {
            switch ((Element)this[Stat.WeaponElement])
            {
                case Element.Fire:
                    return Stat.FireAttack;
                case Element.Ice:
                    return Stat.IceAttack;
                case Element.Lightning:
                    return Stat.LightningAttack;
                case Element.Wind:
                    return Stat.WindAttack;
                case Element.Holy:
                    return Stat.HolyAttack;
                case Element.Dark:
                    return Stat.DarkAttack;
                case Element.Phantom:
                    return Stat.PhantomAttack;
            }

            foreach (KeyValuePair<Stat, int> pair in Values)
            {
                switch (pair.Key)
                {
                    case Stat.FireAttack:
                        return Stat.FireAttack;
                    case Stat.IceAttack:
                        return Stat.IceAttack;
                    case Stat.LightningAttack:
                        return Stat.LightningAttack;
                    case Stat.WindAttack:
                        return Stat.WindAttack;
                    case Stat.HolyAttack:
                        return Stat.HolyAttack;
                    case Stat.DarkAttack:
                        return Stat.DarkAttack;
                    case Stat.PhantomAttack:
                        return Stat.PhantomAttack;
                }
            }

            return Stat.None;
        }

        public int GetWeaponElementValue()
        {
            return this[Stat.FireAttack] + this[Stat.IceAttack] + this[Stat.LightningAttack] + this[Stat.WindAttack] + this[Stat.HolyAttack] + this[Stat.DarkAttack] + this[Stat.PhantomAttack];
        }


        public int GetElementValue(Element element)
        {
            switch (element)
            {
                case Element.Fire:
                    return this[Stat.FireAttack];
                case Element.Ice:
                    return this[Stat.IceAttack];
                case Element.Lightning:
                    return this[Stat.LightningAttack];
                case Element.Wind:
                    return this[Stat.WindAttack];
                case Element.Holy:
                    return this[Stat.HolyAttack];
                case Element.Dark:
                    return this[Stat.DarkAttack];
                case Element.Phantom:
                    return this[Stat.PhantomAttack];
                default:
                    return 0;
            }

        }
        public int GetAffinityValue(Element element)
        {
            switch (element)
            {
                case Element.Fire:
                    return this[Stat.FireAffinity];
                case Element.Ice:
                    return this[Stat.IceAffinity];
                case Element.Lightning:
                    return this[Stat.LightningAffinity];
                case Element.Wind:
                    return this[Stat.WindAffinity];
                case Element.Holy:
                    return this[Stat.HolyAffinity];
                case Element.Dark:
                    return this[Stat.DarkAffinity];
                case Element.Phantom:
                    return this[Stat.PhantomAffinity];
                default:
                    return 0;
            }

        }
        public int GetResistanceValue(Element element)
        {
            switch (element)
            {
                case Element.Fire:
                    return this[Stat.FireResistance];
                case Element.Ice:
                    return this[Stat.IceResistance];
                case Element.Lightning:
                    return this[Stat.LightningResistance];
                case Element.Wind:
                    return this[Stat.WindResistance];
                case Element.Holy:
                    return this[Stat.HolyResistance];
                case Element.Dark:
                    return this[Stat.DarkResistance];
                case Element.Phantom:
                    return this[Stat.PhantomResistance];
                case Element.None:
                    return this[Stat.PhysicalResistance];
                default:
                    return 0;
            }

        }
        public Element GetAffinityElement()
        {
            List<Element> elements = new List<Element>();

            if (this[Stat.FireAffinity] > 0)
                elements.Add(Element.Fire);

            if (this[Stat.IceAffinity] > 0)
                elements.Add(Element.Ice);

            if (this[Stat.LightningAffinity] > 0)
                elements.Add(Element.Lightning);

            if (this[Stat.WindAffinity] > 0)
                elements.Add(Element.Wind);

            if (this[Stat.HolyAffinity] > 0)
                elements.Add(Element.Holy);

            if (this[Stat.DarkAffinity] > 0)
                elements.Add(Element.Dark);

            if (this[Stat.PhantomAffinity] > 0)
                elements.Add(Element.Phantom);

            if (elements.Count == 0) return Element.None;

            return elements[Globals.Random.Next(elements.Count)];
        }
    }

    public enum Stat
    {
        [StatDescription(Title = "基础生命", Format = "{0:+#0;-#0;#0}", Mode = StatType.None)]
        BaseHealth,
        [StatDescription(Title = "基础魔法", Format = "{0:+#0;-#0;#0}", Mode = StatType.None)]
        BaseMana,

        [StatDescription(Title = "生命", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Health,
        [StatDescription(Title = "魔法", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Mana,

        [StatDescription(Title = "物防", Format = "{0}-0", Mode = StatType.Min, MinStat = MinAC, MaxStat = MaxAC)]
        MinAC,
        [StatDescription(Title = "物防", Format = "{0}-{1}", Mode = StatType.Max, MinStat = MinAC, MaxStat = MaxAC)]
        MaxAC,
        [StatDescription(Title = "魔防", Format = "{0}-0", Mode = StatType.Min, MinStat = MinMR, MaxStat = MaxMR)]
        MinMR,
        [StatDescription(Title = "魔防", Format = "{0}-{1}", Mode = StatType.Max, MinStat = MinMR, MaxStat = MaxMR)]
        MaxMR,
        [StatDescription(Title = "破坏力", Format = "{0}-0", Mode = StatType.Min, MinStat = MinDC, MaxStat = MaxDC)]
        MinDC,
        [StatDescription(Title = "破坏力", Format = "{0}-{1}", Mode = StatType.Max, MinStat = MinDC, MaxStat = MaxDC)]
        MaxDC,
        [StatDescription(Title = "自然魔力", Format = "{0}-0", Mode = StatType.SpellPower, MinStat = MinMC, MaxStat = MaxMC)]
        MinMC,
        [StatDescription(Title = "自然魔力", Format = "{0}-{1}", Mode = StatType.SpellPower, MinStat = MinMC, MaxStat = MaxMC)]
        MaxMC,
        [StatDescription(Title = "精神魔力", Format = "{0}-0", Mode = StatType.SpellPower, MinStat = MinSC, MaxStat = MaxSC)]
        MinSC,
        [StatDescription(Title = "精神魔力", Format = "{0}-{1}", Mode = StatType.SpellPower, MinStat = MinSC, MaxStat = MaxSC)]
        MaxSC,

        [StatDescription(Title = "准确", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Accuracy,
        [StatDescription(Title = "敏捷", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Agility,
        [StatDescription(Title = "攻击速度", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        AttackSpeed,

        [StatDescription(Title = "光照范围", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Light,
        [StatDescription(Title = "力量", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Strength, //Also known as Inten (Intensity)
        [StatDescription(Title = "幸运", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Luck, //does nothing at the moment

        [StatDescription(Title = "火焰", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        FireAttack,
        [StatDescription(Title = "火焰", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        FireResistance,

        [StatDescription(Title = "寒冰", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        IceAttack,
        [StatDescription(Title = "寒冰", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        IceResistance,

        [StatDescription(Title = "雷电", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        LightningAttack,
        [StatDescription(Title = "雷电", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        LightningResistance,
        
        [StatDescription(Title = "风暴", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        WindAttack,
        [StatDescription(Title = "风暴", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        WindResistance,
        
        [StatDescription(Title = "神圣", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        HolyAttack,
        [StatDescription(Title = "神圣", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        HolyResistance,

        [StatDescription(Title = "暗黑", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        DarkAttack,
        [StatDescription(Title = "暗黑", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        DarkResistance,

        [StatDescription(Title = "幻影", Format = "{0:+#0;-#0;#0}", Mode = StatType.AttackElement)]
        PhantomAttack,
        [StatDescription(Title = "幻影", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        PhantomResistance,

        [StatDescription(Title = "舒适", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Comfort, //Regen Timer
        [StatDescription(Title = "生命窃取", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        LifeSteal,

        [StatDescription(Title = "经验增益", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        ExperienceRate,
        [StatDescription(Title = "物品爆率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        DropRate,
        [StatDescription(Title = "空", Mode = StatType.None)]
        None,
        [StatDescription(Title = "技能点提升率", Format = "x{0}", Mode = StatType.Default)]
        SkillRate,

        [StatDescription(Title = "捡拾范围", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        PickUpRadius,


        [StatDescription(Title = "完全愈合", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        Healing,
        [StatDescription(Title = "每刻度最大治疗量", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        HealingCap,

        [StatDescription(Title = "隐身", Mode = StatType.Text)]
        Invisibility,

        [StatDescription(Title = "属性: 火焰", Mode = StatType.Text)]
        FireAffinity,
        [StatDescription(Title = "属性: 寒冰", Mode = StatType.Text)]
        IceAffinity,
        [StatDescription(Title = "属性: 雷电", Mode = StatType.Text)]
        LightningAffinity,
        [StatDescription(Title = "属性: 风暴", Mode = StatType.Text)]
        WindAffinity,
        [StatDescription(Title = "属性: 神圣", Mode = StatType.Text)]
        HolyAffinity,
        [StatDescription(Title = "属性: 暗黑", Mode = StatType.Text)]
        DarkAffinity,
        [StatDescription(Title = "属性: 幻影", Mode = StatType.Text)]
        PhantomAffinity,

        [StatDescription(Title = "伤害反弹", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        ReflectDamage,

        [StatDescription(Mode = StatType.None)]
        WeaponElement,
        [StatDescription(Title = "暂时无敌.", Mode = StatType.Text)]
        Redemption,
        [StatDescription(Title = "生命", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        HealthPercent,

        [StatDescription(Title = "暴击率", Format = "{0:+#0;-#0;#0}%", Mode = StatType.Default)]
        CriticalChance,

        [StatDescription(Title = "增加 5% 售价", Format = "{0} 或更多", Mode = StatType.Default)]
        SaleBonus5,
        [StatDescription(Title = "增加 10% 售价", Format = "{0} 或更多", Mode = StatType.Default)]
        SaleBonus10,
        [StatDescription(Title = "增加 15% 售价", Format = "{0} 或更多", Mode = StatType.Default)]
        SaleBonus15,
        [StatDescription(Title = "增加 20% 售价", Format = "{0} 或更多", Mode = StatType.Default)]
        SaleBonus20,

        [StatDescription(Title = "伤害吸收", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MagicShield,
        [StatDescription(Title = "隐身", Mode = StatType.Text)]
        Cloak,
        [StatDescription(Title = "隐形伤害", Format = "{0} 每次", Mode = StatType.Default)]
        CloakDamage,

        [StatDescription(Title = "重新开始的代价", Format = "{0}", Mode = StatType.Default)]
        TheNewBeginning,

        [StatDescription(Title = "褐名, 大家可以自由攻击你", Mode = StatType.Text)]
        Brown,
        [StatDescription(Title = "PK 点:", Format = "{0}", Mode = StatType.Default)]
        PKPoint,


        [StatDescription(Title = "全服喊话没有等级限制", Mode = StatType.Text)]
        GlobalShout,
        [StatDescription(Title = "自然魔力", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MCPercent,

        [StatDescription(Title = "审判几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        JudgementOfHeaven,

        [StatDescription(Title = "透明", Mode = StatType.Text)]
        Transparency,

        [StatDescription(Title = "生命恢复", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        CelestialLight,

        [StatDescription(Title = "魔法转换", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        DarkConversion,

        [StatDescription(Title = "生命恢复", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        RenounceHPLost,

        [StatDescription(Title = "背包负重", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        BagWeight,
        [StatDescription(Title = "穿戴负重", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        WearWeight,
        [StatDescription(Title = "手腕负重", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        HandWeight,

        [StatDescription(Title = "金币增益", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        GoldRate,

        [StatDescription(Title = "旧持久", Mode = StatType.Time)]
        OldDuration,
        [StatDescription(Title = "有效猎币", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        AvailableHuntGold,
        [StatDescription(Title = "有效猎币最大值", Format = "{0:#0}", Mode = StatType.Default)]
        AvailableHuntGoldCap,
        [StatDescription(Title = "恢复冷却", Mode = StatType.Time)]
        ItemReviveTime,
        [StatDescription(Title = "最大精炼几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxRefineChance,

        [StatDescription(Title = "小伙伴背包空间", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        CompanionInventory,
        [StatDescription(Title = "小伙伴背包负重", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        CompanionBagWeight,
        [StatDescription(Title = "破坏力", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        DCPercent,
        [StatDescription(Title = "精神力", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        SCPercent,
        [StatDescription(Title = "小伙伴饥饿度", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)]
        CompanionHunger,

        [StatDescription(Title = "宠物 破坏力", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        PetDCPercent,

        [StatDescription(Title = "在地图上定位【Boss】级怪物", Mode = StatType.Text)]
        BossTracker,
        [StatDescription(Title = "在地图上定位玩家", Mode = StatType.Text)]
        PlayerTracker,

        [StatDescription(Title = "小伙伴经验倍率", Format = "x{0}", Mode = StatType.Default)]
        CompanionRate,

        [StatDescription(Title = "重量比例", Format = "x{0}", Mode = StatType.Default)]
        WeightRate,
        [StatDescription(Title = "最小物防和最小魔防得到了大幅提升.", Mode = StatType.Text)]
        Defiance,
        [StatDescription(Title = "你牺牲一半的体力换来进攻能力的提升.", Mode = StatType.Text)]
        Might,
        [StatDescription(Title = "魔法", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        ManaPercent,

        [StatDescription(Title = "召唤命令: @队伍召唤", Mode = StatType.Text)]
        RecallSet,

        [StatDescription(Title = "普通怪物基础经验倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MonsterExperience,

        [StatDescription(Title = "普通怪物基础金币倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MonsterGold,

        [StatDescription(Title = "普通怪物基础掉落倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MonsterDrop,

        [StatDescription(Title = "普通怪物基础伤害倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MonsterDamage,

        [StatDescription(Title = "普通怪物基础生命倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MonsterHealth,

        [StatDescription(Mode = StatType.None)]
        ItemIndex,

        [StatDescription(Title = "小伙伴捡拾能力提升.", Mode = StatType.Text)]
        CompanionCollection,
        [StatDescription(Title = "护身戒指", Mode = StatType.Text)]
        ProtectionRing,
        [StatDescription(Mode = StatType.None)]
        ClearRing,
        [StatDescription(Mode = StatType.None)]
        TeleportRing,

        [StatDescription(Title = "基础经验比例", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        BaseExperienceRate,

        [StatDescription(Title = "基础金币比例", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        BaseGoldRate,

        [StatDescription(Title = "基础掉落几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        BaseDropRate,

        [StatDescription(Title = "冰冻伤害", Format = "{0}", Mode = StatType.Default)]
        FrostBiteDamage,

        [StatDescription(Title = "普通怪物基础经验最大倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxMonsterExperience,

        [StatDescription(Title = "普通怪物基础金币最大倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxMonsterGold,

        [StatDescription(Title = "普通怪物基础掉落最大倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxMonsterDrop,

        [StatDescription(Title = "普通怪物基础伤害最大倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxMonsterDamage,

        [StatDescription(Title = "普通怪物基础生命最大倍率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        MaxMonsterHealth,

        [StatDescription(Title = "暴击伤害 (PvE)", Format = "x{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        CriticalDamage,

        [StatDescription(Title = "经验", Format = "{0}", Mode = StatType.Default)]
        Experience,

        [StatDescription(Title = "死亡后会掉落物品.", Mode = StatType.Text)]
        DeathDrops,

        [StatDescription(Title = "物理抗性", Format = "{0:+#0;-#0;#0}", Mode = StatType.ElementResistance)]
        PhysicalResistance,

        [StatDescription(Title = "每个碎片的成功几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        FragmentRate,

        [StatDescription(Title = "召唤地图的几率 ", Mode = StatType.Text)]
        MapSummoning,

        [StatDescription(Title = "最大冰冻伤害", Format = "{0}", Mode = StatType.Default)]
        FrostBiteMaxDamage,

        [StatDescription(Title = "麻痹几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        ParalysisChance,
        [StatDescription(Title = "减速几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        SlowChance,
        [StatDescription(Title = "沉默几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        SilenceChance,
        [StatDescription(Title = "格挡几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        BlockChance,
        [StatDescription(Title = "躲避几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        EvasionChance,

        [StatDescription(Mode = StatType.None)]
        IgnoreStealth,
        [StatDescription(Mode = StatType.None)]
        FootballArmourAction,

        [StatDescription(Title = "抗毒性", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)]
        PoisonResistance,

        [StatDescription(Title = "重生 ", Format = "{0}", Mode = StatType.Default)]
        Rebirth,



        [StatDescription(Title = "持久", Mode = StatType.Time)]
        Duration = 10000,



        [StatDescription(Title = "暴击减免", Format = "{0:+#0;-#0;#0}%", Mode = StatType.Default)] CritReduction = 10001, // 0x00002711
        [StatDescription(Title = "魔法速度", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)] MagicSpeed = 10002, // 0x00002712
        [StatDescription(Title = "爆伤减免", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] JMCriticalDamage = 10003, // 0x00002713
        [StatDescription(Title = "宠物生命", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] PetHPPercent = 10004, // 0x00002714
        [StatDescription(Title = "减免伤害", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] DamageReduction = 10005, // 0x00002715
        [StatDescription(Title = "附加伤害", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] DamageAdd = 10006, // 0x00002716
        //[StatDescription(Title = "蕴灵等级", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)] Yunling = 10007, // 0x00002717
        //[StatDescription(Title = "灵气值", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)] 灵气值 = 10008, // 0x00002718
        //[StatDescription(Title = "红毒", Format = "{0:+#0%;-#0%;#0%}概率使目标中红毒10秒.", Mode = StatType.Percent)] RedPoisonAdd = 10009, // 0x00002719
        //[StatDescription(Title = "绿毒", Format = "{0:+#0%;-#0%;#0%}概率使目标中绿毒10秒.", Mode = StatType.Percent)] BulePoisonAdd = 10010, // 0x0000271A
        //[StatDescription(Title = "炼器", Format = "等级{0:+#0;-#0;#0}", Mode = StatType.Default)] LianQi = 10011, // 0x0000271B
        //[StatDescription(Title = "开光次数", Format = "已开光{0:#0;#0;#0}次", Mode = StatType.Default)] Kaiguang = 10012, // 0x0000271C
        //[StatDescription(Title = "苍龙护体", Format = "等级{0:+#0;#0;#0}", Mode = StatType.Default)] JinengLEVEL = 10013, // 0x0000271D
        //[StatDescription(Title = "无视减免", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] 无视减免 = 10014, // 0x0000271E
        //[StatDescription(Title = "极限攻击", Format = "{0:+#0;-#0;#0}", Mode = StatType.Default)] 极限攻击 = 10015, // 0x0000271F
        //[StatDescription(Title = "技能等级提升几率", Format = "{0:+#0%;-#0%;#0%}", Mode = StatType.Percent)] BookUpgradeRate = 10016, // 0x00002720
    }

    public enum StatSource
    {
        None,
        Added,
        Refine,
        Enhancement, //Temporary Buff!?
        Other,
    }

    public enum StatType
    {
        None,
        Default,
        Min,
        Max,
        Percent,
        Text,
        AttackElement,
        ElementResistance,
        SpellPower,
        Time,
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class StatDescription : Attribute
    {
        public string Title { get; set; }
        public string Format { get; set; }
        public StatType Mode { get; set; }
        public Stat MinStat { get; set; }
        public Stat MaxStat { get; set; }
    }
}
