﻿namespace AOSharp.Common.GameData
{
    public enum Stat
    {
        Flags = 0x0,
        MaxHealth = 0x1,
        Mass = 0x2,
        AttackSpeed = 0x3,
        Breed = 0x4,
        Clan = 0x5,
        Team = 0x6,
        State = 0x7,
        TimeExist = 0x8,
        MapFlags = 0x9,
        ProfessionLevel = 0xA,
        PreviousHealth = 0xB,
        Mesh = 0xC,
        Anim = 0xD,
        Name = 0xE,
        Info = 0xF,
        Strength = 0x10,
        Agility = 0x11,
        Stamina = 0x12,
        Intelligence = 0x13,
        Sense = 0x14,
        Psychic = 0x15,
        AMS = 0x16,
        StaticInstance = 0x17,
        MaxMass = 0x18,
        StaticType = 0x19,
        Energy = 0x1A,
        Health = 0x1B,
        Height = 0x1C,
        DMS = 0x1D,
        Can = 0x1E,
        Face = 0x1F,
        HairMesh = 0x20,
        Side = 0x21,
        DeadTimer = 0x22,
        AccessCount = 0x23,
        AttackCount = 0x24,
        TitleLevel = 0x25,
        BackMesh = 0x26,
        ShoulderMesh = 0x27,
        AlienXP = 0x28,
        FabricType = 0x29,
        CATMesh = 0x2A,
        ParentType = 0x2B,
        ParentInstance = 0x2C,
        BeltSlots = 0x2D,
        BandolierSlots = 0x2E,
        Fatness = 0x2F,
        ClanLevel = 0x30,
        InsuranceTime = 0x31,
        AggDef = 0x33,
        XP = 0x34,
        IP = 0x35,
        Level = 0x36,
        InventoryId = 0x37,
        TimeSinceCreation = 0x38,
        LastXP = 0x39,
        Age = 0x3A,
        Sex = 0x3B,
        Profession = 0x3C,
        Cash = 0x3D,
        AlignmentClanTokens = 0x3E,
        Attitude = 0x3F,
        HeadMesh = 0x40,
        HairTexture = 0x41,
        HairColourRGB = 0x43,
        NumConstructedQuest = 0x44,
        MaxConstructedQuest = 0x45,
        SpeedPenalty = 0x46,
        ItemType = 0x48,
        RepairDifficulty = 0x49,
        Value = 0x4A,
        NanoStrain = 0x4B,
        EquipmentPage = 0x4C,
        RepairSkill = 0x4D,
        CurrentMass = 0x4E,
        Icon = 0x4F,
        PrimaryItemType = 0x50,
        PrimaryItemInstance = 0x51,
        SecondaryItemType = 0x52,
        SecondaryItemInstance = 0x53,
        UserType = 0x54,
        UserInstance = 0x55,
        AreaType = 0x56,
        AreaInstance = 0x57,
        DefaultPos = 0x58,
        Race = 0x59,
        ProjectileAC = 0x5A,
        MeleeAC = 0x5B,
        EnergyAC = 0x5C,
        ChemicalAC = 0x5D,
        RadiationAC = 0x5E,
        ColdAC = 0x5F,
        PoisonAC = 0x60,
        FireAC = 0x61,
        StateAction = 0x62,
        ItemAnim = 0x63,
        MartialArts = 0x64,
        MultiMelee = 0x65,
        _1hBlunt = 0x66,
        _1hEdged = 0x67,
        MeleeEnergy = 0x68,
        Skill2hEdged = 0x69,
        Piercing = 0x6A,
        _2hBlunt = 0x6B,
        SharpObject = 0x6C,
        Grenade = 0x6D,
        HeavyWeapons = 0x6E,
        Bow = 0x6F,
        Pistol = 0x70,
        Rifle = 0x71,
        MGSMG = 0x72,
        Shotgun = 0x73,
        AssaultRifle = 0x74,
        VehicleWater = 0x75,
        MeleeInit = 0x76,
        RangedInit = 0x77,
        PhysicalInit = 0x78,
        BowSpecialAttack = 0x79,
        SensoryImprovement = 0x7A,
        FirstAid = 0x7B,
        Treatment = 0x7C,
        MechanicalEngineering = 0x7D,
        ElectricalEngineering = 0x7E,
        MaterialMetamorphosis = 0x7F,
        BiologicalMetamorphosis = 0x80,
        PsychologicalModification = 0x81,
        MaterialCreation = 0x82,
        SpaceTime = 0x83,
        NanoPool = 0x84,
        RangedEnergy = 0x85,
        MultiRanged = 0x86,
        TrapDisarm = 0x87,
        Perception = 0x88,
        Adventuring = 0x89,
        Swimming = 0x8A,
        VehicleAir = 0x8B,
        MapNavigation = 0x8C,
        Tutoring = 0x8D,
        Brawl = 0x8E,
        Riposte = 0x8F,
        Dimach = 0x90,
        Parry = 0x91,
        SneakAttack = 0x92,
        FastAttack = 0x93,
        Burst = 0x94,
        NanoCInit = 0x95,
        FlingShot = 0x96,
        AimedShot = 0x97,
        BodyDevelopment = 0x98,
        DuckExp = 0x99,
        DodgeRanged = 0x9A,
        EvadeClsC = 0x9B,
        RunSpeed = 0x9C,
        QuantumFT = 0x9D,
        WeaponSmithing = 0x9E,
        Pharmaceuticals = 0x9F,
        NanoProgramming = 0xA0,
        ComputerLiteracy = 0xA1,
        Psychology = 0xA2,
        Chemistry = 0xA3,
        Concealment = 0xA4,
        BreakingEntry = 0xA5,
        VehicleGround = 0xA6,
        FullAuto = 0xA7,
        NanoResist = 0xA8,
        AlienLevel = 0xA9,
        HealthChangeBest = 0xAA,
        HealthChangeWorst = 0xAB,
        HealthChange = 0xAC,
        MoreFlags = 0xB1,
        AlienNextXP = 0xB2,
        NPCFlags = 0xB3,
        CurrentNCU = 0xB4,
        MaxNCU = 0xB5,
        Specialization = 0xB6,
        EffectIcon = 0xB7,
        BuildingType = 0xB8,
        BuildingInstance = 0xB9,
        CardOwnerType = 0xBA,
        CardOwnerInstance = 0xBB,
        BuildingComplexInst = 0xBC,
        ExitInstance = 0xBD,
        NextDoorInBuilding = 0xBE,
        LastConcretePlayfieldInstance = 0xBF,
        ExtenalPlayfieldInstance = 0xC0,
        ExtenalDoorInstance = 0xC1,
        InPlay = 0xC2,
        AccessKey = 0xC3,
        ConflictReputation = 0xC4,
        OrientationMode = 0xC5,
        SessionTime = 0xC6,
        RP = 0xC7,
        Conformity = 0xC8,
        Aggressiveness = 0xC9,
        Stability = 0xCA,
        Extroverty = 0xCB,
        Taunt = 0xCC,
        ReflectProjectileAC = 0xCD,
        ReflectMeleeAC = 0xCE,
        ReflectEnergyAC = 0xCF,
        ReflectChemicalAC = 0xD0,
        WeaponMesh = 0xD1,
        RechargeDelay = 0xD2,
        EquipDelay = 0xD3,
        MaxEnergy = 0xD4,
        TeamSide = 0xD5,
        CurrentNano = 0xD6,
        GmLevel = 0xD7,
        ReflectRadiationAC = 0xD8,
        ReflectColdAC = 0xD9,
        ReflectNanoAC = 0xDA,
        ReflectFireAC = 0xDB,
        CurrBodyLocation = 0xDC,
        MaxNanoEnergy = 0xDD,
        AccumulatedDamage = 0xDE,
        CanChangeClothes = 0xDF,
        Features = 0xE0,
        ReflectPoisonAC = 0xE1,
        ShieldProjectileAC = 0xE2,
        ShieldMeleeAC = 0xE3,
        ShieldEnergyAC = 0xE4,
        ShieldChemicalAC = 0xE5,
        ShieldRadiationAC = 0xE6,
        ShieldColdAC = 0xE7,
        ShieldNanoAC = 0xE8,
        ShieldFireAC = 0xE9,
        ShieldPoisonAC = 0xEA,
        BerserkMode = 0xEB,
        InsurancePercentage = 0xEC,
        ChangeSideCount = 0xED,
        AbsorbProjectileAC = 0xEE,
        AbsorbMeleeAC = 0xEF,
        AbsorbEnergyAC = 0xF0,
        AbsorbChemicalAC = 0xF1,
        AbsorbRadiationAC = 0xF2,
        AbsorbColdAC = 0xF3,
        AbsorbFireAC = 0xF4,
        AbsorbPoisonAC = 0xF5,
        AbsorbNanoAC = 0xF6,
        TemporarySkillReduction = 0xF7,
        BirthDate = 0xF8,
        LastSaved = 0xF9,
        SoundVolume = 0xFA,
        Pets = 0xFB,
        MetersWalked = 0xFC,
        QuestLevelsSolved = 0xFD,
        MonsterLevelsKilled = 0xFE,
        PvPLevelsKilled = 0xFF,
        MissionBits1 = 0x100,
        MissionBits2 = 0x101,
        ClanHierarchy = 0x104,
        QuestStat = 0x105,
        ClientActivated = 0x106,
        PersonalResearchLevel = 0x107,
        GlobalResearchLevel = 0x108,
        PersonalResearchGoal = 0x109,
        GlobalResearchGoal = 0x10A,
        TurnSpeed = 0x10B,
        LiquidType = 0x10C,
        GatherSound = 0x10D,
        CastSound = 0x10E,
        TravelSound = 0x10F,
        HitSound = 0x110,
        SecondaryItemTemplate = 0x111,
        EquippedWeapons = 0x112,
        XPKillRange = 0x113,
        AddAllOff = 0x114,
        AddAllDef = 0x115,
        ProjectileDamageModifier = 0x116,
        MeleeDamageModifier = 0x117,
        EnergyDamageModifier = 0x118,
        ChemicalDamageModifier = 0x119,
        RadiationDamageModifier = 0x11A,
        ItemHateValue = 0x11B,
        CriticalBonus = 0x11C,
        MaxDamage = 0x11D,
        MinDamage = 0x11E,
        AttackRange = 0x11F,
        HateValueModifier = 0x120,
        TrapDifficulty = 0x121,
        StatOne = 0x122,
        NumAttackEffects = 0x123,
        DefaultAttackType = 0x124,
        ItemSkill = 0x125,
        AttackDelay = 0x126,
        ItemOpposedSkill = 0x127,
        ItemSIS = 0x128,
        InteractionRadius = 0x129,
        Slot = 0x12A,
        LockDifficulty = 0x12B,
        Members = 0x12C,
        MinMembers = 0x12D,
        ClanPrice = 0x12E,
        ClanUpkeep = 0x12F,
        ClanType = 0x130,
        ClanInstance = 0x131,
        VoteCount = 0x132,
        MemberType = 0x133,
        MemberInstance = 0x134,
        GlobalClanType = 0x135,
        GlobalClanInstance = 0x136,
        ColdDamageModifier = 0x137,
        ClanUpkeepInterval = 0x138,
        TimeSinceUpkeep = 0x139,
        ClanFinalized = 0x13A,
        NanoDamageModifier = 0x13B,
        FireDamageModifier = 0x13C,
        PoisonDamageModifier = 0x13D,
        NPCostModifier = 0x13E,
        XPModifier = 0x13F,
        BreedLimit = 0x140,
        GenderLimit = 0x141,
        LevelLimit = 0x142,
        PlayerKilling = 0x143,
        TeamAllowed = 0x144,
        WeaponDisallowedType = 0x145,
        WeaponDisallowedInstance = 0x146,
        Taboo = 0x147,
        Compulsion = 0x148,
        SkillDisabled = 0x149,
        ClanItemType = 0x14A,
        ClanItemInstance = 0x14B,
        DebuffFormula = 0x14C,
        PvP_Rating = 0x14D,
        SavedXP = 0x14E,
        DamageType1 = 0x153,
        BrainType = 0x154,
        XPBonus = 0x155,
        HealInterval = 0x156,
        HealDelta = 0x157,
        MonsterTexture = 0x158,
        HasAlwaysLootable = 0x159,
        NextXP = 0x15E,
        SISCap = 0x160,
        AnimSet = 0x161,
        AttackType = 0x162,
        NanoFocusLevel = 0x163,
        MonsterData = 0x167,
        Scale = 0x168,
        HitEffectType = 0x169,
        ResurrectDest = 0x16A,
        NanoInterval = 0x16B,
        NanoDelta = 0x16C,
        ReclaimItem = 0x16D,
        GatherEffectType = 0x16E,
        VisualBreed = 0x16F,
        VisualProfession = 0x170,
        VisualSex = 0x171,
        RitualTargetInst = 0x172,
        SkillTimeOnSelectedTarget = 0x173,
        LastSaveXP = 0x174,
        ExtendedTime = 0x175,
        BurstRecharge = 0x176,
        FullAutoRecharge = 0x177,
        GatherAbstractAnim = 0x178,
        CastTargetAbstractAnim = 0x179,
        CastSelfAbstractAnim = 0x17A,
        CriticalIncrease = 0x17B,
        RangeIncreaserWeapon = 0x17C,
        NanoRange = 0x17D,
        SkillLockModifier = 0x17E,
        InterruptModifier = 0x17F,
        ACGEntranceStyles = 0x180,
        ChanceOfBreakOnSpellAttack = 0x181,
        ChanceOfBreakOnDebuff = 0x182,
        DieAnim = 0x183,
        TowerType = 0x184,
        Expansion = 0x185,
        LowresMesh = 0x186,
        CritialResistance = 0x187,
        SelectedTargetType = 0x18D,
        Corpse_Hash = 0x18E,
        AmmoName = 0x18F,
        Rotation = 0x190,
        CATAnim = 0x191,
        CATAnimFlags = 0x192,
        DisplayCATAnim = 0x193,
        DisplayCATMesh = 0x194,
        School = 0x195,
        NanoPoints = 0x197,
        TrainSkill = 0x198,
        TrainSkillCost = 0x199,
        NumFightingOpponents = 0x19A,
        MultipleCount = 0x19C,
        EffectType = 0x19D,
        ImpactEffectType = 0x19E,
        CorpseType = 0x19F,
        CorpseInstance = 0x1A0,
        CorpseAnimKey = 0x1A1,
        UnarmedTemplateInstance = 0x1A2,
        TracerEffectType = 0x1A3,
        AmmoType = 0x1A4,
        CharRadius = 0x1A5,
        ChanceOfUse = 0x1A6,
        CurrentState = 0x1A7,
        ArmourType = 0x1A8,
        RestModifier = 0x1A9,
        BuyModifier = 0x1AA,
        SellModifier = 0x1AB,
        CastEffectType = 0x1AC,
        NPCBrainState = 0x1AD,
        WaitState = 0x1AE,
        SelectedTarget = 0x1AF,
        ErrorCode = 0x1B0,
        OwnerInstance = 0x1B1,
        CharState = 0x1B2,
        ReadOnly = 0x1B3,
        DamageType2 = 0x1B4,
        CollideCheckInterval = 0x1B5,
        PlayfieldType = 0x1B6,
        NPCCommand = 0x1B7,
        InitiativeType = 0x1B8,
        CharTmp1 = 0x1B9,
        CharTmp2 = 0x1BA,
        CharTmp3 = 0x1BB,
        CharTmp4 = 0x1BC,
        NPCCommandArg = 0x1BD,
        NameTemplate = 0x1BE,
        DesiredTargetDistance = 0x1BF,
        VicinityRange = 0x1C0,
        NPCIsSurrendering = 0x1C1,
        StateMachine = 0x1C2,
        NPCSurrenderInstance = 0x1C3,
        NPCHasPatrolList = 0x1C4,
        NPCVicinityChars = 0x1C5,
        ProximityRangeOutdoors = 0x1C6,
        NPCFamily = 0x1C7,
        CommandRange = 0x1C8,
        NPCHatelistSize = 0x1C9,
        NPCNumPets = 0x1CA,
        EffectRed = 0x1CC,
        EffectGreen = 0x1CD,
        EffectBlue = 0x1CE,
        DurationModifier = 0x1D0,
        NPCCryForHelpRange = 0x1D1,
        PetReq1 = 0x1D3,
        PetReq2 = 0x1D4,
        PetReq3 = 0x1D5,
        MapOptions = 0x1D6,
        MapsA = 0x1D7,
        MapsB = 0x1D8,
        FixtureFlags = 0x1D9,
        FallDamage = 0x1DA,
        MaxReflectedProjectileDmg = 0x1DB,
        MaxReflectedMeleeDmg = 0x1DC,
        MaxReflectedEnergyDmg = 0x1DD,
        MaxReflectedChemicalDmg = 0x1DE,
        MaxReflectedRadiationDmg = 0x1DF,
        MaxReflectedColdDmg = 0x1E0,
        MaxReflectedNanoDmg = 0x1E1,
        MaxReflectedFireDmg = 0x1E2,
        MaxReflectedPoisonDmg = 0x1E3,
        ProximityRangeIndoors = 0x1E4,
        PetReqVal1 = 0x1E5,
        PetReqVal2 = 0x1E6,
        PetReqVal3 = 0x1E7,
        TargetFacing = 0x1E8,
        Backstab = 0x1E9,
        OriginatorType = 0x1EA,
        QuestInstance = 0x1EB,
        AnimPos = 0x1F4,
        AnimPlay = 0x1F5,
        AnimSpeed = 0x1F6,
        Tower_NPCHash = 0x1FF,
        PetType = 0x200,
        OnTowerCreation = 0x201,
        OwnedTowers = 0x202,
        TowerInstance = 0x203,
        AttackShield = 0x204,
        SpecialAttackShield = 0x205,
        NPCVicinityPlayers = 0x206,
        Rnd = 0x208,
        SocialStatus = 0x209,
        LastRnd = 0x20A,
        AttackDelayCap = 0x20B,
        RechargeDelayCap = 0x20C,
        PercentRemainingHealth = 0x20D,
        PercentRemainingNano = 0x20E,
        TargetDistance = 0x20F,
        TeamCloseness = 0x210,
        ExpansionPlayfield = 0x213,
        ShadowBreed = 0x214,
        DudChance = 0x216,
        HealMultiplier = 0x217,
        NanoDamageMultiplier = 0x218,
        NanoVulnerability = 0x219,
        AMSCap = 0x21A,
        ProcInitiative1 = 0x21B,
        ProcInitiative2 = 0x21C,
        ProcInitiative3 = 0x21D,
        ProcInitiative4 = 0x21E,
        FactionModifier = 0x21F,
        StackingLine2 = 0x222,
        StackingLine3 = 0x223,
        StackingLine4 = 0x224,
        StackingLine5 = 0x225,
        StackingLine6 = 0x226,
        StackingOrder = 0x227,
        ProcNano1 = 0x228,
        ProcNano2 = 0x229,
        ProcNano3 = 0x22A,
        ProcNano4 = 0x22B,
        ProcChance1 = 0x22C,
        ProcChance2 = 0x22D,
        ProcChance3 = 0x22E,
        ProcChance4 = 0x22F,
        OTArmedForces = 0x230,
        ClanSentinels = 0x231,
        OTMed = 0x232,
        ClanGaia = 0x233,
        OTTrans = 0x234,
        ClanVanguards = 0x235,
        GOS = 0x236,
        OTFollowers = 0x237,
        OTOperator = 0x238,
        OTUnredeemed = 0x239,
        ClanDevoted = 0x23A,
        ClanConserver = 0x23B,
        ClanRedeemed = 0x23C,
        SK = 0x23D,
        LastSK = 0x23E,
        NextSK = 0x23F,
        PlayerOptions = 0x240,
        LastPerkResetTime = 0x241,
        CurrentTime = 0x242,
        ShadowBreedTemplate = 0x243,
        NPCVicinityFamily = 0x244,
        NPCScriptAMSScale = 0x245,
        ApartmentsAllowed = 0x246,
        ApartmentsOwned = 0x247,
        ApartmentAccessCard = 0x248,
        MapsC = 0x249,
        MapsD = 0x24A,
        NumberOfTeamMembers = 0x24B,
        ActionCategory = 0x24C,
        PlayfieldProxy = 0x24D,
        UnsavedXP = 0x250,
        RegainXPPercentage = 0x251,
        ExtendedFlags = 0x256,
        NewbieHP = 0x258,
        HPLevelUp = 0x259,
        HPPerSkill = 0x25A,
        NewbieNP = 0x25B,
        NPLevelUp = 0x25C,
        NPPerSkill = 0x25D,
        MaxShopItems = 0x25E,
        PlayerID = 0x25F,
        ShopRent = 0x260,
        ShopFlags = 0x262,
        ShopLastUsed = 0x263,
        ShopType = 0x264,
        InvadersKilled = 0x267,
        KilledByInvaders = 0x268,
        HouseTemplate = 0x26C,
        PercentFireDamage = 0x26D,
        PercentColdDamage = 0x26E,
        PercentMeleeDamage = 0x26F,
        PercentProjectileDamage = 0x270,
        PercentPoisonDamage = 0x271,
        PercentRadiationDamage = 0x272,
        PercentEnergyDamage = 0x273,
        PercentChemicalDamage = 0x274,
        TotalDamage = 0x275,
        TrackProjectileDamage = 0x276,
        TrackMeleeDamage = 0x277,
        TrackEnergyDamage = 0x278,
        TrackChemicalDamage = 0x279,
        TrackRadiationDamage = 0x27A,
        TrackColdDamage = 0x27B,
        TrackPoisonDamage = 0x27C,
        TrackFireDamage = 0x27D,
        NPCSpellArg = 0x27E,
        NPCSpellRet = 0x27F,
        CityInstance = 0x280,
        DistanceToSpawnpoint = 0x281,
        AdvantageHash1 = 0x28B,
        AdvantageHash2 = 0x28C,
        AdvantageHash3 = 0x28D,
        AdvantageHash4 = 0x28E,
        AdvantageHash5 = 0x28F,
        ShopIndex = 0x290,
        ShopID = 0x291,
        IsVehicle = 0x292,
        DamageToNano = 0x293,
        AccountFlags = 0x294,
        DamageToNanoMultiplier = 0x295,
        MechData = 0x296,
        PointValue = 0x297,
        VehicleAC = 0x298,
        VehicleDamage = 0x299,
        VehicleHealth = 0x29A,
        VehicleSpeed = 0x29B,
        BattlestationSide = 0x29C,
        VP = 0x29D,
        BattlestationRep = 0x29E,
        PetState = 0x29F,
        PaidPoints = 0x2A0,
        VisualFlags = 0x2A1,
        PVPDuelKills = 0x2A2,
        PVPDuelDeaths = 0x2A3,
        PVPProfessionDuelKills = 0x2A4,
        PVPProfessionDuelDeaths = 0x2A5,
        PVPRankedSoloKills = 0x2A6,
        PVPRankedSoloDeaths = 0x2A7,
        PVPRankedTeamKills = 0x2A8,
        PVPRankedTeamDeaths = 0x2A9,
        PVPSoloScore = 0x2AA,
        PVPTeamScore = 0x2AB,
        PVPDuelScore = 0x2AC,
        ACGItemSeed = 0x2BC,
        ACGItemLevel = 0x2BD,
        ACGItemTemplateID = 0x2BE,
        ACGItemTemplateID2 = 0x2BF,
        ACGItemCategoryID = 0x2C0,
        HasKnubotData = 0x300,
        QuestBoothDifficulty = 0x320,
        QuestASMinimumRange = 0x321,
        QuestASMaximumRange = 0x322,
        VisualLODLevel = 0x378,
        TargetDistanceChange = 0x379,
        TideRequiredDynelID = 0x384,
        Type = 0x3E9,
        Instance = 0x3EA
    }
}