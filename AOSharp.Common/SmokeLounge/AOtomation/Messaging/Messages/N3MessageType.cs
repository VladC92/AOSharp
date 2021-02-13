﻿namespace SmokeLounge.AOtomation.Messaging.Messages
{
    public enum N3MessageType
    {
        KnubotNPCDescription = 0xA0C5A,
        AddTemplate = 0x52E2F0C,
        GridDestinationSelect = 0x639474D,
        CentralControllerState = 0x8536F65,
        WeatherControl = 0xC5A5D6D,
        PetToMaster = 0xD381F02,
        FlushRDBCaches = 0x1078735A,
        CentralControllerFullUpdate = 0x15253307,
        AcceptBSInvite = 0x166A435E,
        AddPet = 0x194E4F76,
        SetPos = 0x195E496E,
        ReflectAttack = 0x1C3A4F77,
        SpecialAttackWeapon = 0x1D3C0F1C,
        ClientContainerAddItem = 0x1F4D5F7E,
        MentorInvite = 0x2001377E,
        Action = 0x2049527C,
        Script = 0x204F4871,
        FormatFeedback = 0x206B4B73,
        KnubotAnswer = 0x2103247D,
        Quest = 0x212C487A,
        MineFullUpdate = 0x215B5678,
        LookAt = 0x2252445F,
        ShieldAttack = 0x25192476,
        CastNanoSpell = 0x25314D6D,
        ResearchUpdate = 0x253D0240,
        FollowTarget = 0x260F3671,
        RelocateDynels = 0x264B514B,
        Absorb = 0x264E5F61,
        Reload = 0x26515E61,
        KnubotCloseChatWindow = 0x270A4C62,
        SimpleCharFullUpdate = 0x271B3A6B,
        StartLogout = 0x28251F01,
        Attack = 0x28494070,
        TeamMemberInfo = 0x28784248,
        CreateQuest = 0x291F361B,
        FullCharacter = 0x29304349,
        LaserTagList = 0x2933154F,
        TrapDisarmed = 0x2A253F5F,
        Fov = 0x2A293D0F,
        Stat = 0x2B333D6E,
        QueueUpdate = 0x2C2F061C,
        KnubotRejectedItems = 0x2D212407,
        OrgInfoPacket = 0x2E2A4A6B,
        n3PlayfieldFullUpdate = 0x30161355,
        AreaFormula = 0x3129233B,
        InfromPlayer = 0x3301337A,
        WaypointPath = 0x33312042,
        Mail = 0x333B2867,
        ApplySpells = 0x342C1D1D,
        Bank = 0x343C287F,
        TemplateAction = 0x35505644,
        Trade = 0x36284F6E,
        Despawn = 0x36510078,
        DoorFullUpdate = 0x365A5071,
        CityAdvantages = 0x365E555B,
        HealthDamage = 0x3710256C,
        PickUp = 0x37136C6B,
        FightModeUpdate = 0x371D0542,
        Buff = 0x39343C68,
        KnubotTrade = 0x3A1B2C0C,
        ItemReplaced = 0x3A223B50,
        DropTemplate = 0x3A243F41,
        GridSelected = 0x3A322A4A,
        SimpleItemFullUpdate = 0x3B11256F,
        KnubotOpenChatWindow = 0x3B132D64,
        WeaponItemFullUpdate = 0x3B1D2268,
        SocialActionCmd = 0x3B290771,
        Raid = 0x3B3B2878,
        ShadowLevel = 0x3C1E2803,
        Clone = 0x3C265179,
        ServerPathPosDebugInfo = 0x3D746C70,
        Skill = 0x3E205660,
        LeaveBattle = 0x3F3A1914,
        AppearanceUpdate = 0x41624F0D,
        N3Teleport = 0x43197D22,
        PerkUpdate = 0x435F7023,
        SendScore = 0x44483B3A,
        Resurrect = 0x445F2A0B,
        UpdateClientVisual = 0x45072A2D,
        PlaySound = 0x455D2938,
        AttackInfo = 0x46002F16,
        TeamMember = 0x46312D2E,
        SpawnMech = 0x464D000A,
        QuestFullUpdate = 0x465A4061,
        ChestFullUpdate = 0x465A5D73,
        MarketSend = 0x470B2E14,
        DropDynel = 0x47483633,
        ContainerAddItem = 0x47537A24,
        InventoryUpdated = 0x485E7202,
        Visibility = 0x49222612,
        StopFight = 0x4A41203E,
        BattleOver = 0x4B062919,
        DoorStatusUpdate = 0x4C7D403B,
        TeamInvite = 0x4D2A313B,
        InfoPacket = 0x4D38242E,
        SpellList = 0x4D450114,
        RaidCmd = 0x4E525E58,
        InventoryUpdate = 0x4E536976,
        CorpseFullUpdate = 0x4F474E05,
        Feedback = 0x50544D19,
        CharSecSpecAttack = 0x51492120,
        BankCorpse = 0x52213420,
        GenericCmd = 0x52526858,
        ArriveAtBs = 0x540E3B27,
        CharDCMove = 0x54111123,
        ClientMoveItemToInventory = 0x5469373F,
        PlayfieldAllTowers = 0x55220726,
        KnubotFinishTrade = 0x55682B24,
        KnubotAnswerList = 0x55704D31,
        StopLogout = 0x56353038,
        CharInPlay = 0x570C2039,
        ShopUpdate = 0x58362220,
        MechInfo = 0x58574239,
        RemovePet = 0x58742A0F,
        PlayfieldAllCities = 0x59210126,
        TrapItemFullUpdate = 0x59313928,
        Inspect = 0x5A585F65,
        PlayfieldTowerUpdateClient = 0x5B1E052C,
        ServerPosDebugInfo = 0x5C240404,
        QuestAlternative = 0x5C436609,
        FullAuto = 0x5C4A493A,
        ChatCmd = 0x5c525a7b,
        MissedAttackInfo = 0x5C654B28,
        KnubotAppendText = 0x5D70532A,
        CharacterAction = 0x5E477770,
        Impulse = 0x5F4A4C6C,
        PlayfieldAnarchyF = 0x5F4B1A39,
        ChatText = 0x5F4B442A,
        GameTime = 0x5F52412E,
        SetWantedDirection = 0x60201D0E,
        AOTransportSignal = 0x62741E15,
        OrgServer = 0x64582A07,
        PetCommand = 0x6B333303,
        SetStat = 0x6E5F566E,
        SetName = 0x734E5A7B,
        StopMovingCmd = 0x742E2314,
        SpecialAttackInfo = 0x754F1115,
        GiveQuestToMembers = 0x77230927,
        KnubotStartTrade = 0x7864401D,
        GfxTrigger = 0x7A222202,
        NewLevel = 0x7F405A16,
        OrgClient = 0x7F4B3108,
        VendingMachineFullUpdate = 0x7F544905
    }
}