// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: message.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace SkillBridge.Message
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NUserInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"player")]
        public NPlayerInfo Player { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NPlayerInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"characters")]
        public global::System.Collections.Generic.List<NCharacterInfo> Characters { get; } = new global::System.Collections.Generic.List<NCharacterInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NCharacterInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"tid")]
        public int Tid { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(4, Name = @"type")]
        public CharacterType Type { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"class")]
        public CharacterClass Class { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"level")]
        public int Level { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public int mapId { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"entity")]
        public NEntity Entity { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"gold")]
        public long Gold { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<NItemInfo> Items { get; } = new global::System.Collections.Generic.List<NItemInfo>();

        [global::ProtoBuf.ProtoMember(11)]
        public NBagInfo Bag { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public byte[] Equips { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"quests")]
        public global::System.Collections.Generic.List<NQuestInfo> Quests { get; } = new global::System.Collections.Generic.List<NQuestInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NItemInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"count")]
        public int Count { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NBagInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int Unlocked { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] Items { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NVector3 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"x")]
        public int X { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"y")]
        public int Y { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"z")]
        public int Z { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NStatus : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type")]
        public StatusType Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"action")]
        public StatusAction Action { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"value")]
        public int Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StatusNotify : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"status")]
        public global::System.Collections.Generic.List<NStatus> Status { get; } = new global::System.Collections.Generic.List<NStatus>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NEntity : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"position")]
        public NVector3 Position { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"direction")]
        public NVector3 Direction { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"speed")]
        public int Speed { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NEntitySync : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id")]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"event")]
        public EntityEvent Event { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"entity")]
        public NEntity Entity { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NetMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public NetMessageRequest Request { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public NetMessageResponse Response { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NetMessageRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public UserRegisterRequest userRegister { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public UserLoginRequest userLogin { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public UserCreateCharacterRequest createChar { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public UserGameEnterRequest gameEnter { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public UserGameLeaveRequest gameLeave { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public MapCharacterEnterRequest mapCharacterEnter { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public MapEntitySyncRequest mapEntitySync { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public MapTeleportRequest mapTeleport { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public ItemBuyRequest itemBuy { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public ItemEquipRequest itemEquip { get; set; }

        [global::ProtoBuf.ProtoMember(100)]
        public StatusNotify statusNotify { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public QuestListRequest questList { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public QuestAcceptRequest questAccept { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public QuestSubmitRequest questSubmit { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NetMessageResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public UserRegisterResponse userRegister { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public UserLoginResponse userLogin { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public UserCreateCharacterResponse createChar { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public UserGameEnterResponse gameEnter { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public UserGameLeaveResponse gameLeave { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public MapCharacterEnterResponse mapCharacterEnter { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public MapCharacterLeaveResponse mapCharacterLeave { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public MapEntitySyncResponse mapEntitySync { get; set; }

        [global::ProtoBuf.ProtoMember(10)]
        public ItemBuyResponse itemBuy { get; set; }

        [global::ProtoBuf.ProtoMember(11)]
        public ItemEquipResponse itemEquip { get; set; }

        [global::ProtoBuf.ProtoMember(12)]
        public QuestListResponse questList { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        public QuestAcceptResponse questAccept { get; set; }

        [global::ProtoBuf.ProtoMember(14)]
        public QuestSubmitResponse questSubmit { get; set; }

        [global::ProtoBuf.ProtoMember(100)]
        public StatusNotify statusNotify { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserLoginRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"user")]
        [global::System.ComponentModel.DefaultValue("")]
        public string User { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"passward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Passward { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserLoginResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"userinfo")]
        public NUserInfo Userinfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserRegisterRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"user")]
        [global::System.ComponentModel.DefaultValue("")]
        public string User { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"passward")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Passward { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserRegisterResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserCreateCharacterRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(2, Name = @"class")]
        public CharacterClass Class { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserCreateCharacterResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"characters")]
        public global::System.Collections.Generic.List<NCharacterInfo> Characters { get; } = new global::System.Collections.Generic.List<NCharacterInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserGameEnterRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int characterIdx { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserGameEnterResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"character")]
        public NCharacterInfo Character { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserGameLeaveRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UserGameLeaveResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapCharacterEnterRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int mapId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapCharacterEnterResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int mapId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"characters")]
        public global::System.Collections.Generic.List<NCharacterInfo> Characters { get; } = new global::System.Collections.Generic.List<NCharacterInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapCharacterLeaveResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int characterId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapEntitySyncRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public NEntitySync entitySync { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapEntitySyncResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<NEntitySync> entitySyncs { get; } = new global::System.Collections.Generic.List<NEntitySync>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MapTeleportRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int teleporterId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemBuyRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int shopId { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int shopItenId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemBuyResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BagSaveRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public NBagInfo BagInfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BagSaveResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemEquipRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"slot")]
        public int Slot { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int itemId { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public bool isEquip { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ItemEquipResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NQuestInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"quest_id")]
        public int QuestId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"quest_guid")]
        public int QuestGuid { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"status")]
        public QuestStatus Status { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"targets", IsPacked = true)]
        public int[] Targets { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestListRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public QuestListType listType { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestListResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"quests")]
        public global::System.Collections.Generic.List<NQuestInfo> Quests { get; } = new global::System.Collections.Generic.List<NQuestInfo>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestAcceptRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"quest_id")]
        public int QuestId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestAcceptResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"quest")]
        public NQuestInfo Quest { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestSubmitRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"quest_id")]
        public int QuestId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestSubmitResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3, Name = @"quest")]
        public NQuestInfo Quest { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestAbandonRequest : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"quest_id")]
        public int QuestId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class QuestAbandonResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result")]
        public Result Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"errormsg")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Errormsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract(Name = @"RESULT")]
    public enum Result
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SUCCESS")]
        Success = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"FAILED")]
        Failed = 1,
    }

    [global::ProtoBuf.ProtoContract(Name = @"CHARACTER_TYPE")]
    public enum CharacterType
    {
        Player = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"NPC")]
        Npc = 1,
        Monster = 2,
    }

    [global::ProtoBuf.ProtoContract(Name = @"CHARACTER_CLASS")]
    public enum CharacterClass
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NONE")]
        None = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"WARRIOR")]
        Warrior = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"WIZARD")]
        Wizard = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"ARCHER")]
        Archer = 3,
    }

    [global::ProtoBuf.ProtoContract(Name = @"CHARACTER_STATE")]
    public enum CharacterState
    {
        [global::ProtoBuf.ProtoEnum(Name = @"IDLE")]
        Idle = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"MOVE")]
        Move = 1,
    }

    [global::ProtoBuf.ProtoContract(Name = @"ENTITY_EVENT")]
    public enum EntityEvent
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NONE")]
        None = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"IDLE")]
        Idle = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"MOVE_FWD")]
        MoveFwd = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"MOVE_BACK")]
        MoveBack = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"JUMP")]
        Jump = 4,
    }

    [global::ProtoBuf.ProtoContract(Name = @"ITEM_TYPE")]
    public enum ItemType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"NORMAL")]
        Normal = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"MATERIAL")]
        Material = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"TASK")]
        Task = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"EQUIP")]
        Equip = 3,
    }

    [global::ProtoBuf.ProtoContract(Name = @"EQUIP_SLOT")]
    public enum EquipSlot
    {
        [global::ProtoBuf.ProtoEnum(Name = @"WEAPON")]
        Weapon = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ACCESSORY")]
        Accessory = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"HELMET")]
        Helmet = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"CHEST")]
        Chest = 3,
        [global::ProtoBuf.ProtoEnum(Name = @"SHOULDER")]
        Shoulder = 4,
        [global::ProtoBuf.ProtoEnum(Name = @"PANTS")]
        Pants = 5,
        [global::ProtoBuf.ProtoEnum(Name = @"BOOTS")]
        Boots = 6,
        [global::ProtoBuf.ProtoEnum(Name = @"SLOT_MAX")]
        SlotMax = 7,
    }

    [global::ProtoBuf.ProtoContract(Name = @"STATUS_ACTION")]
    public enum StatusAction
    {
        [global::ProtoBuf.ProtoEnum(Name = @"UPDATE")]
        Update = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ADD")]
        Add = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"DELETE")]
        Delete = 2,
    }

    [global::ProtoBuf.ProtoContract(Name = @"STATUS_TYPE")]
    public enum StatusType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"MONEY")]
        Money = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"EXP")]
        Exp = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"SKILL_POINT")]
        SkillPoint = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"ITEM")]
        Item = 3,
    }

    [global::ProtoBuf.ProtoContract(Name = @"STATUS_SOURCE")]
    public enum StatusSource
    {
        [global::ProtoBuf.ProtoEnum(Name = @"UPDATE")]
        Update = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ADD")]
        Add = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"DELETE")]
        Delete = 2,
    }

    [global::ProtoBuf.ProtoContract(Name = @"QUEST_STATUS")]
    public enum QuestStatus
    {
        [global::ProtoBuf.ProtoEnum(Name = @"IN_PROGRESS")]
        InProgress = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"COMPLATED")]
        Complated = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"FINISHED")]
        Finished = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"FAILED")]
        Failed = 3,
    }

    [global::ProtoBuf.ProtoContract(Name = @"QUEST_LIST_TYPE")]
    public enum QuestListType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"ALL")]
        All = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"IN_PROGRESS")]
        InProgress = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"FINISHED")]
        Finished = 2,
    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006