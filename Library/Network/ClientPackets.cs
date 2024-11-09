using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MirDB;

namespace Library.Network.ClientPackets
{
    [PacketMark(1001)]
    public sealed class NewAccount : Packet
    {
        public string EMailAddress { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string RealName { get; set; }
        public string Referral { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1002)]
    public sealed class ChangePassword : Packet
    {
        public string EMailAddress { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1003)]
    public sealed class RequestPasswordReset : Packet
    {
        public string EMailAddress { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1004)]
    public sealed class ResetPassword : Packet
    {
        public string ResetKey { get; set; }
        public string NewPassword { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1005)]
    public sealed class Activation : Packet
    {
        public string ActivationKey { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1006)]
    public sealed class RequestActivationKey : Packet
    {
        public string EMailAddress { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1007)]
    public sealed class SelectLanguage : Packet
    {
        public string Language { get; set; }
    }

    [PacketMark(1008)]
    public sealed class Login : Packet
    {
        public string EMailAddress { get; set; }
        public string Password { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1009)]
    public sealed class Logout : Packet { }

    [PacketMark(1010)]
    public sealed class NewCharacter : Packet
    {
        public string CharacterName { get; set; }
        public MirClass Class { get; set; }
        public MirGender Gender { get; set; }
        public int HairType { get; set; }
        public Color HairColour { get; set; }
        public Color ArmourColour { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1011)]
    public sealed class DeleteCharacter : Packet
    {
        public int CharacterIndex { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1012)]
    public sealed class StartGame : Packet
    {
        public int CharacterIndex { get; set; }
    }

    [PacketMark(1013)]
    public sealed class TownRevive : Packet { }

    [PacketMark(1014)]
    public sealed class Turn : Packet
    {
        public MirDirection Direction { get; set; }
    }

    [PacketMark(1015)]
    public sealed class Harvest : Packet
    {
        public MirDirection Direction { get; set; }
    }

    [PacketMark(1016)]
    public sealed class Move : Packet
    {
        public MirDirection Direction { get; set; }
        public int Distance { get; set; }
    }

    [PacketMark(1017)]
    public sealed class Mount : Packet { }

    [PacketMark(1018)]
    public sealed class Attack : Packet
    {
        public MirDirection Direction { get; set; }
        public MirAction Action { get; set; }
        public MagicType AttackMagic { get; set; }
    }

    [PacketMark(1019)]
    public sealed class Mining : Packet
    {
        public MirDirection Direction { get; set; }
    }

    [PacketMark(1020)]
    public sealed class Magic : Packet
    {
        public MirDirection Direction { get; set; }
        public MirAction Action { get; set; }
        public MagicType Type { get; set; }
        public uint Target { get; set; }
        public Point Location { get; set; }
    }

    [PacketMark(1021)]
    public sealed class ItemMove : Packet
    {
        public GridType FromGrid { get; set; }
        public GridType ToGrid { get; set; }
        public int FromSlot { get; set; }
        public int ToSlot { get; set; }
        public bool MergeItem { get; set; }
    }

    [PacketMark(1022)]
    public sealed class ItemSplit : Packet
    {
        public GridType Grid { get; set; }
        public int Slot { get; set; }
        public long Count { get; set; }
    }

    [PacketMark(1023)]
    public sealed class ItemDrop : Packet
    {
        public CellLinkInfo Link { get; set; }
    }

    [PacketMark(1024)]
    public sealed class GoldDrop : Packet
    {
        public long Amount { get; set; }
    }

    [PacketMark(1025)]
    public sealed class ItemUse : Packet
    {
        public CellLinkInfo Link { get; set; }
    }

    [PacketMark(1026)]
    public sealed class ItemLock : Packet
    {
        public GridType GridType { get; set; }
        public int SlotIndex { get; set; }
        public bool Locked { get; set; }
    }

    [PacketMark(1027)]
    public sealed class BeltLinkChanged : Packet
    {
        public int Slot { get; set; }
        public int LinkIndex { get; set; }
        public int LinkItemIndex { get; set; }
    }

    [PacketMark(1028)]
    public sealed class AutoPotionLinkChanged : Packet
    {
        public int Slot { get; set; }
        public int LinkIndex { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public bool Enabled { get; set; }
    }

    [PacketMark(1029)]
    public sealed class PickUp : Packet
    {
        public byte PickType { get; set; }
    }

    [PacketMark(1030)]
    public sealed class Chat : Packet
    {
        public string Text { get; set; }
    }

    [PacketMark(1031)]
    public sealed class NPCCall : Packet
    {
        public uint ObjectID { get; set; }
    }

    [PacketMark(1032)]
    public sealed class NPCButton : Packet
    {
        public int ButtonID { get; set; }
    }

    [PacketMark(1033)]
    public sealed class NPCBuy : Packet
    {
        public int Index { get; set; }
        public long Amount { get; set; }
        public bool GuildFunds { get; set; }
    }

    [PacketMark(1034)]
    public sealed class NPCSell : Packet
    {
        public List<CellLinkInfo> Links { get; set; }

    }

    [PacketMark(1035)]
    public sealed class NPCFragment : Packet
    {
        public List<CellLinkInfo> Links { get; set; }

    }

    [PacketMark(1036)]
    public sealed class NPCRepair : Packet
    {
        public List<CellLinkInfo> Links { get; set; }
        public bool Special { get; set; }
        public bool GuildFunds { get; set; }
    }

    [PacketMark(1037)]
    public sealed class NPCRefine : Packet
    {
        public RefineType RefineType { get; set; }
        public RefineQuality RefineQuality { get; set; }
        public List<CellLinkInfo> Ores { get; set; }
        public List<CellLinkInfo> Items { get; set; }
        public List<CellLinkInfo> Specials { get; set; }
    }

    [PacketMark(1038)]
    public sealed class NPCMasterRefine : Packet
    {
        public RefineType RefineType { get; set; }
        public List<CellLinkInfo> Fragment1s { get; set; }
        public List<CellLinkInfo> Fragment2s { get; set; }
        public List<CellLinkInfo> Fragment3s { get; set; }
        public List<CellLinkInfo> Stones { get; set; }
        public List<CellLinkInfo> Specials { get; set; }
    }

    [PacketMark(1039)]
    public sealed class NPCMasterRefineEvaluate : Packet
    {
        public RefineType RefineType { get; set; }
        public List<CellLinkInfo> Fragment1s { get; set; }
        public List<CellLinkInfo> Fragment2s { get; set; }
        public List<CellLinkInfo> Fragment3s { get; set; }
        public List<CellLinkInfo> Stones { get; set; }
        public List<CellLinkInfo> Specials { get; set; }
    }

    [PacketMark(1040)]
    public sealed class NPCRefinementStone : Packet
    {
        public List<CellLinkInfo> IronOres { get; set; }
        public List<CellLinkInfo> SilverOres { get; set; }
        public List<CellLinkInfo> DiamondOres { get; set; }
        public List<CellLinkInfo> GoldOres { get; set; }
        public List<CellLinkInfo> Crystal { get; set; }
        public long Gold { get; set; }
    }

    [PacketMark(1041)]
    public sealed class NPCClose : Packet
    {
    }

    [PacketMark(1042)]
    public sealed class NPCRefineRetrieve : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1043)]
    public sealed class NPCAccessoryLevelUp : Packet
    {
        public CellLinkInfo Target { get; set; }
        public List<CellLinkInfo> Links { get; set; }
    }

    [PacketMark(1044)]
    public sealed class NPCAccessoryUpgrade : Packet
    {
        public CellLinkInfo Target { get; set; }
        public RefineType RefineType { get; set; }
    }

    [PacketMark(1045)]
    public sealed class MagicKey : Packet
    {
        public MagicType Magic { get; set; }

        public SpellKey Set1Key { get; set; }
        public SpellKey Set2Key { get; set; }
        public SpellKey Set3Key { get; set; }
        public SpellKey Set4Key { get; set; }
    }

    [PacketMark(1046)]
    public sealed class MagicToggle : Packet
    {
        public MagicType Magic { get; set; }
        public bool CanUse { get; set; }
    }

    [PacketMark(1047)]
    public sealed class GroupSwitch : Packet
    {
        public bool Allow { get; set; }
    }

    [PacketMark(1048)]
    public sealed class GroupInvite : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1049)]
    public sealed class GroupRemove : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1050)]
    public sealed class GroupResponse : Packet
    {
        public bool Accept { get; set; }
    }

    [PacketMark(1051)]
    public sealed class Inspect : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1052)]
    public sealed class RankRequest : Packet
    {
        public RequiredClass Class { get; set; }
        public bool OnlineOnly { get; set; }
        public int StartIndex { get; set; }
    }

    [PacketMark(1053)]
    public sealed class ObserverRequest : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1054)]
    public sealed class ObservableSwitch : Packet
    {
        public bool Allow { get; set; }
    }

    [PacketMark(1055)]
    public sealed class Hermit : Packet
    {
        public Stat Stat { get; set; }
    }

    [PacketMark(1056)]
    public sealed class MarketPlaceHistory : Packet
    {
        public int Index { get; set; }
        public int Display { get; set; }
        public int PartIndex { get; set; }
    }

    [PacketMark(1057)]
    public sealed class MarketPlaceConsign : Packet
    {
        public CellLinkInfo Link { get; set; }

        public int Price { get; set; }

        public string Message { get; set; }
        public bool GuildFunds { get; set; }
    }

    [PacketMark(1058)]
    public sealed class MarketPlaceSearch : Packet
    {
        public string Name { get; set; }

        public bool ItemTypeFilter { get; set; }
        public ItemType ItemType { get; set; }

        public MarketPlaceSort Sort { get; set; }
    }

    [PacketMark(1059)]
    public sealed class MarketPlaceSearchIndex : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1060)]
    public sealed class MarketPlaceCancelConsign : Packet
    {
        public int Index { get; set; }
        public long Count { get; set; }
    }

    [PacketMark(1061)]
    public sealed class MarketPlaceBuy : Packet
    {
        public long Index { get; set; }
        public long Count { get; set; }
        public bool GuildFunds { get; set; }
    }

    [PacketMark(1062)]
    public sealed class MarketPlaceStoreBuy : Packet
    {
        public int Index { get; set; }
        public long Count { get; set; }
        public bool UseHuntGold { get; set; }
    }

    [PacketMark(1063)]
    public sealed class MailOpened : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1064)]
    public sealed class MailGetItem : Packet
    {
        public int Index { get; set; }
        public int Slot { get; set; }
    }

    [PacketMark(1065)]
    public sealed class MailDelete : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1066)]
    public sealed class MailSend : Packet
    {
        public List<CellLinkInfo> Links { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public long Gold { get; set; }
    }

    [PacketMark(1067)]
    public sealed class ChangeAttackMode : Packet
    {
        public AttackMode Mode { get; set; }
    }

    [PacketMark(1068)]
    public sealed class ChangePetMode : Packet
    {
        public PetMode Mode { get; set; }
    }

    [PacketMark(1069)]
    public sealed class GameGoldRecharge : Packet
    { }

    [PacketMark(1070)]
    public sealed class TradeRequest : Packet
    {
    }

    [PacketMark(1071)]
    public sealed class TradeRequestResponse : Packet
    {
        public bool Accept { get; set; }
    }

    [PacketMark(1072)]
    public sealed class TradeClose : Packet
    {

    }

    [PacketMark(1073)]
    public sealed class TradeAddGold : Packet
    {
        public long Gold { get; set; }
    }

    [PacketMark(1074)]
    public sealed class TradeAddItem : Packet
    {
        public CellLinkInfo Cell { get; set; }
    }

    [PacketMark(1075)]
    public sealed class TradeConfirm : Packet
    {

    }

    [PacketMark(1076)]
    public sealed class GuildCreate : Packet
    {
        public string Name { get; set; }
        public bool UseGold { get; set; }
        public int Members { get; set; }
        public int Storage { get; set; }
    }

    [PacketMark(1077)]
    public sealed class GuildEditNotice : Packet
    {
        public string Notice { get; set; }
    }

    [PacketMark(1078)]
    public sealed class GuildEditMember : Packet
    {
        public int Index { get; set; }
        public string Rank { get; set; }
        public GuildPermission Permission { get; set; }

    }

    [PacketMark(1079)]
    public sealed class GuildInviteMember : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1080)]
    public sealed class GuildKickMember : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1081)]
    public sealed class GuildTax : Packet
    {
        public long Tax { get; set; }
    }

    [PacketMark(1082)]
    public sealed class GuildIncreaseMember : Packet
    {

    }

    [PacketMark(1083)]
    public sealed class GuildIncreaseStorage : Packet
    {

    }

    [PacketMark(1084)]
    public sealed class GuildResponse : Packet
    {
        public bool Accept { get; set; }
    }

    [PacketMark(1085)]
    public sealed class GuildWar : Packet
    {
        public string GuildName { get; set; }
    }

    [PacketMark(1086)]
    public sealed class GuildRequestConquest : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1087)]
    public sealed class QuestAccept : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1088)]
    public sealed class QuestComplete : Packet
    {
        public int Index { get; set; }

        public int ChoiceIndex { get; set; }
    }

    [PacketMark(1089)]
    public sealed class QuestTrack : Packet
    {
        public int Index { get; set; }

        public bool Track { get; set; }
    }

    [PacketMark(1090)]
    public sealed class CompanionUnlock : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1091)]
    public sealed class CompanionAdopt : Packet
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }

    [PacketMark(1092)]
    public sealed class CompanionRetrieve : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1093)]
    public sealed class CompanionStore : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1094)]
    public sealed class MarriageResponse : Packet
    {
        public bool Accept { get; set; }
    }

    [PacketMark(1095)]
    public sealed class MarriageMakeRing : Packet
    {
        public int Slot { get; set; }
    }

    [PacketMark(1096)]
    public sealed class MarriageTeleport : Packet
    {

    }

    [PacketMark(1097)]
    public sealed class BlockAdd : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1098)]
    public sealed class BlockRemove : Packet
    {
        public int Index { get; set; }
    }

    [PacketMark(1099)]
    public sealed class HelmetToggle : Packet
    {
        public bool HideHelmet { get; set; }
    }

    [PacketMark(1100)]
    public sealed class GenderChange : Packet
    {
        public MirGender Gender { get; set; }
        public int HairType { get; set; }
        public Color HairColour { get; set; }
    }

    [PacketMark(1101)]
    public sealed class HairChange : Packet
    {
        public int HairType { get; set; }
        public Color HairColour { get; set; }
    }

    [PacketMark(1102)]
    public sealed class ArmourDye : Packet
    {
        public Color ArmourColour { get; set; }
    }

    [PacketMark(1103)]
    public sealed class NameChange : Packet
    {
        public string Name { get; set; }
    }

    [PacketMark(1104)]
    public sealed class FortuneCheck : Packet
    {
        public int ItemIndex { get; set; }
    }

    [PacketMark(1105)]
    public sealed class TeleportRing : Packet
    {
        public Point Location { get; set; }
        public int Index { get; set; }
    }

    [PacketMark(1106)]
    public sealed class JoinStarterGuild : Packet
    {

    }

    [PacketMark(1107)]
    public sealed class NPCAccessoryReset : Packet
    {
        public CellLinkInfo Cell { get; set; }
    }

    [PacketMark(1108)]
    public sealed class NPCWeaponCraft : Packet
    {
        public RequiredClass Class { get; set; }
        public CellLinkInfo Template { get; set; }
        public CellLinkInfo Yellow { get; set; }
        public CellLinkInfo Blue { get; set; }
        public CellLinkInfo Red { get; set; }
        public CellLinkInfo Purple { get; set; }
        public CellLinkInfo Green { get; set; }
        public CellLinkInfo Grey { get; set; }
    }

    [PacketMark(1109)]
    public sealed class CheckClientDb : Packet
    {
        public string Hash { get; set; }
    }

    [PacketMark(1110)]
    public sealed class UpgradeClient : Packet
    {
        public string FileKey { get; set; }
    }

    [PacketMark(1111)]
    public sealed class LoginSimple : Packet
    {
        public string EMailAddress { get; set; }
        public string Password { get; set; }
        public string CheckSum { get; set; }
    }

    [PacketMark(1112)]
    public sealed class AccountExpand : Packet
    {

    }

    [PacketMark(1113)]
    public sealed class AutoFightConfChanged : Packet
    {
        public AutoSetConf Slot { get; set; }

        public MagicType MagicIndex { get; set; }

        public int TimeCount { get; set; }

        public bool Enabled { get; set; }
    }

    [PacketMark(1114)]
    public sealed class SortBagItem : Packet { }

    [PacketMark(1115)]
    public sealed class PickUpC : Packet
    {
        public int ItemIdx { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
    }

    [PacketMark(1116)]
    public sealed class PickUpA : Packet
    {
        public int ItemIdx { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
    }

    [PacketMark(1117)]
    public sealed class PickUpS : Packet
    {
        public List<PickItemInfo> UserItems { get; set; }
        public List<PickItemInfo> CompanionItems { get; set; }
    }

    [PacketMark(1118)]
    public sealed class PktFilterItem : Packet
    {
        public List<string> FilterStr { get; set; }
    }

    [PacketMark(1119)]
    public sealed class Qiehuanxunzhaoguaiwumoshi : Packet
    {
        public bool Moshi01 { get; set; }
        public bool Moshi02 { get; set; }
    }

    [PacketMark(1120)]
    public sealed class SortStorageItem : Packet { }
}
