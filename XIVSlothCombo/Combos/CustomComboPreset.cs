﻿using XIVSlothCombo.Attributes;
using XIVSlothCombo.Combos.PvE;
using XIVSlothCombo.Combos.PvP;

namespace XIVSlothCombo.Combos
{
    /// <summary> Combo presets. </summary>
    public enum CustomComboPreset
    {
        #region PvE Combos

        #region Misc

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
        AdvAny = 0,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
        AstAny = AdvAny + AST.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
        BlmAny = AdvAny + BLM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
        BrdAny = AdvAny + BRD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
        DncAny = AdvAny + DNC.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
        DohAny = AdvAny + DOH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
        DolAny = AdvAny + DOL.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
        DrgAny = AdvAny + DRG.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
        DrkAny = AdvAny + DRK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
        GnbAny = AdvAny + GNB.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
        MchAny = AdvAny + MCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
        MnkAny = AdvAny + MNK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
        NinAny = AdvAny + NIN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
        PldAny = AdvAny + PLD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
        RdmAny = AdvAny + RDM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
        RprAny = AdvAny + RPR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
        SamAny = AdvAny + SAM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
        SchAny = AdvAny + SCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
        SgeAny = AdvAny + SGE.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
        SmnAny = AdvAny + SMN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
        WarAny = AdvAny + WAR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
        WhmAny = AdvAny + WHM.JobID,

        [CustomComboInfo("Disabled", "This should not be used.", ADV.JobID)]
        Disabled = 99999,

        #endregion

        #region GLOBAL FEATURES

        [ReplaceSkill(All.Sprint)]
        [CustomComboInfo("Island Sanctuary Sprint Feature", "Replaces Sprint with Isle Sprint.\nOnly works at the Island Sanctuary. Icon does not change.\nDo not use with SimpleTweaks' Island Sanctuary Sprint fix.", ADV.JobID)]
        ALL_IslandSanctuary_Sprint = 100093,

        #region Global Tank Features
        [CustomComboInfo("Global Tank Features", "Features and options involving shared role actions for Tanks.\nCollapsing this category does NOT disable the features inside.", ADV.JobID)]
        ALL_Tank_Menu = 100099,

        [ReplaceSkill(All.LowBlow, PLD.ShieldBash)]
        [ParentCombo(ALL_Tank_Menu)]
        [CustomComboInfo("Tank: Interrupt Feature", "Replaces Low Blow (Stun) with Interject (Interrupt) when the target can be interrupted.\nPLDs can slot Shield Bash to have the feature to work with Shield Bash.", ADV.JobID)]
        ALL_Tank_Interrupt = 100000,

        [ReplaceSkill(All.Reprisal)]
        [ParentCombo(ALL_Tank_Menu)]
        [CustomComboInfo("Tank: Double Reprisal Protection", "Prevents the use of Reprisal when target already has the effect by replacing it with Stone.", ADV.JobID)]
        ALL_Tank_Reprisal = 100001,
        #endregion

        #region Global Healer Features
        [CustomComboInfo("Global Healer Features", "Features and options involving shared role actions for Healers.\nCollapsing this category does NOT disable the features inside.", ADV.JobID)]
        ALL_Healer_Menu = 100098,

        [ReplaceSkill(AST.Ascend, WHM.Raise, SCH.Resurrection, SGE.Egeiro)]
        [ConflictingCombos(AST_Raise_Alternative, SCH_Raise, SGE_Raise, WHM_Raise)]
        [ParentCombo(ALL_Healer_Menu)]
        [CustomComboInfo("Healer: Raise Feature", "Changes the class' Raise Ability into Swiftcast.", ADV.JobID)]
        ALL_Healer_Raise = 100010,
        #endregion

        #region Global Magical Ranged Features
        [CustomComboInfo("Global Magical Ranged Features", "Features and options involving shared role actions for Magical Ranged DPS.\nCollapsing this category does NOT disable the features inside.", ADV.JobID)]
        ALL_Caster_Menu = 100097,

        [ReplaceSkill(All.Addle)]
        [ParentCombo(ALL_Caster_Menu)]
        [CustomComboInfo("Magical Ranged DPS: Double Addle Protection", "Prevents the use of Addle when target already has the effect by replacing it with Fell Cleave.", ADV.JobID)]
        ALL_Caster_Addle = 100020,

        [ReplaceSkill(RDM.Verraise, SMN.Resurrection, BLU.AngelWhisper)]
        [ConflictingCombos(SMN_Raise, RDM_Raise)]
        [ParentCombo(ALL_Caster_Menu)]
        [CustomComboInfo("Magical Ranged DPS: Raise Feature", "Changes the class' Raise Ability into Swiftcast or Dualcast in the case of RDM.", ADV.JobID)]
        ALL_Caster_Raise = 100021,
        #endregion

        #region Global Melee Features
        [CustomComboInfo("Global Melee DPS Features", "Features and options involving shared role actions for Melee DPS.\nCollapsing this category does NOT disable the features inside.", ADV.JobID)]
        ALL_Melee_Menu = 100096,

        [ReplaceSkill(All.Feint)]
        [ParentCombo(ALL_Melee_Menu)]
        [CustomComboInfo("Melee DPS: Double Feint Protection", "Prevents the use of Feint when target already has the effect by replacing it with Fire.", ADV.JobID)]
        ALL_Melee_Feint = 100030,

        [ReplaceSkill(All.TrueNorth)]
        [ParentCombo(ALL_Melee_Menu)]
        [CustomComboInfo("Melee DPS: True North Protection", "Prevents the use of True North when its buff is already active by replacing it with Fire.", ADV.JobID)]
        ALL_Melee_TrueNorth = 100031,

        #endregion

        #region Global Ranged Physical Features
        [CustomComboInfo("Global Physical Ranged Features", "Features and options involving shared role actions for Physical Ranged DPS.\nCollapsing this category does NOT disable the features inside.", ADV.JobID)]
        ALL_Ranged_Menu = 100095,

        [ReplaceSkill(MCH.Tactician, BRD.Troubadour, DNC.ShieldSamba)]
        [ParentCombo(ALL_Ranged_Menu)]
        [CustomComboInfo("Physical Ranged DPS: Double Mitigation Protection", "Prevents the use of Tactician/Troubadour/Shield Samba when target already has one of those three effects.", ADV.JobID)]
        ALL_Ranged_Mitigation = 100040,

        [ReplaceSkill(All.FootGraze)]
        [ParentCombo(ALL_Ranged_Menu)]
        [CustomComboInfo("Physical Ranged DPS: Ranged Interrupt Feature", "Replaces Foot Graze with Head Graze when target can be interrupted.", ADV.JobID)]
        ALL_Ranged_Interrupt = 100041,


        #endregion

        //Non-gameplay Features
        //[CustomComboInfo("Output Combat Log", "Outputs your performed actions to the chat.", ADV.JobID)]
        //AllOutputCombatLog = 100094,

        // Last value = 100094

        #endregion

        // Jobs

        #region ASTROLOGIAN

        #region DPS
        [ReplaceSkill(AST.Malefic, AST.Malefic2, AST.Malefic3, AST.Malefic4, AST.FallMalefic, AST.Combust, AST.Combust2, AST.Combust3, AST.Gravity, AST.Gravity2)]
        [CustomComboInfo("DPS Feature", "Replaces Malefic or Combust with options below", AST.JobID)]
        AST_ST_DPS = 1004,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Combust Uptime Option", "Adds Combust to the DPS feature if it's not present on current target, or is about to expire.", AST.JobID)]
        AST_ST_DPS_CombustUptime = 1018,

        [ReplaceSkill(AST.Gravity, AST.Gravity2)]
        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("AoE DPS Feature", "Every option below (Lucid/AutoDraws/Astrodyne/etc) will also be added to Gravity", AST.JobID, 1, "", "")]
        AST_AoE_DPS = 1013,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Lightspeed Weave Option", "Adds Lightspeed", AST.JobID, 2, "", "")]
        AST_DPS_LightSpeed = 1020,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Lucid Dreaming Weave Option", "Adds Lucid Dreaming when MP drops below slider value", AST.JobID, 3, "", "")]
        AST_DPS_Lucid = 1008,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Divination Weave Option", "Adds Divination", AST.JobID, 4, "", "")]
        AST_DPS_Divination = 1016,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Card Draw Weave Option", "Draws your card", AST.JobID, 5, "", "")]
        AST_DPS_AutoDraw = 1011,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Card Play Weave Option", "Weaves your card (best used with Quick Target Cards)", AST.JobID, 6)]
        AST_DPS_AutoPlay = 1037,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Redraw Option", "Weaves Redraw if you pull a card with a seal you already have and you can use Redraw.", AST.JobID, 7)]
        AST_DPS_AutoPlay_Redraw = 1038,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Astrodyne Weave Option", "Adds Astrodyne when you have 3 seals", AST.JobID, 8, "", "")]
        AST_DPS_Astrodyne = 1009,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Minor Arcana Weave Option", "Adds Minor Arcana", AST.JobID, 9, "", "")]
        AST_DPS_AutoCrownDraw = 1012,

        [ParentCombo(AST_ST_DPS)]
        [CustomComboInfo("Lord of Crowns Weave Option", "Adds Lord Of Crowns", AST.JobID, 10, "", "")]
        AST_DPS_LazyLord = 1014,
        #endregion

        #region Healing
        [ReplaceSkill(AST.Benefic2)]
        [CustomComboInfo("Simple Heals (Single Target)", "", AST.JobID, 2)]
        AST_ST_SimpleHeals = 1023,

        [ParentCombo(AST_ST_SimpleHeals)]
        [CustomComboInfo("Essential Dignity Option", "Essential Dignity will be added when the target is at or below the value set", AST.JobID)]
        AST_ST_SimpleHeals_EssentialDignity = 1024,

        [ParentCombo(AST_ST_SimpleHeals)]
        [CustomComboInfo("Celestial Intersection Option", "Adds Celestial Intersection.", AST.JobID)]
        AST_ST_SimpleHeals_CelestialIntersection = 1025,

        [ParentCombo(AST_ST_SimpleHeals)]
        [CustomComboInfo("Aspected Benefic Option", "Adds Aspected Benefic & refreshes it if needed.", AST.JobID)]
        AST_ST_SimpleHeals_AspectedBenefic = 1027,

        [ParentCombo(AST_ST_SimpleHeals)]
        [CustomComboInfo("Esuna Option", "Applies Esuna to your target if there is a cleansable debuff.", AST.JobID)]
        AST_ST_SimpleHeals_Esuna = 1039,

        [ParentCombo(AST_ST_SimpleHeals)]
        [CustomComboInfo("Exaltation Feature", "Adds Exaltation.", AST.JobID)]
        AST_ST_SimpleHeals_Exaltation = 1028,

        [ReplaceSkill(AST.AspectedHelios)]
        [CustomComboInfo("Aspected Helios Feature", "Replaces Aspected Helios whenever you are under Aspected Helios regen with Helios", AST.JobID, 3, "", "")]
        AST_AoE_SimpleHeals_AspectedHelios = 1010,

        [ParentCombo(AST_AoE_SimpleHeals_AspectedHelios)]
        [CustomComboInfo("Celestial Opposition Option", "Adds Celestial Opposition", AST.JobID)]
        AST_AoE_SimpleHeals_CelestialOpposition = 1021,

        [ParentCombo(AST_AoE_SimpleHeals_AspectedHelios)]
        [CustomComboInfo("Lazy Lady Option", "Adds Lady of Crowns, if the card is drawn", AST.JobID)]
        AST_AoE_SimpleHeals_LazyLady = 1022,

        [ParentCombo(AST_AoE_SimpleHeals_AspectedHelios)]
        [CustomComboInfo("Horoscope Option", "Adds Horoscope.", AST.JobID)]
        AST_AoE_SimpleHeals_Horoscope = 1026,

        [ReplaceSkill(AST.Benefic2)]
        [CustomComboInfo("Benefic 2 Downgrade", "Changes Benefic 2 to Benefic when Benefic 2 is not unlocked or available.", AST.JobID, 4, "", "")]
        AST_Benefic = 1002,
        #endregion

        #region Utility
        [ReplaceSkill(All.Swiftcast)]
        [ConflictingCombos(ALL_Healer_Raise)]
        [CustomComboInfo("Alternative Raise Feature", "Changes Swiftcast to Ascend", AST.JobID, 5, "", "")]
        AST_Raise_Alternative = 1003,

        [Variant]
        [VariantParent(AST_ST_DPS_CombustUptime, AST_AoE_DPS)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", AST.JobID)]
        AST_Variant_SpiritDart = 1035,

        [Variant]
        [VariantParent(AST_ST_DPS)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", AST.JobID)]
        AST_Variant_Rampart = 1036,

        #endregion

        #region Cards
        [ReplaceSkill(AST.Play)]
        [CustomComboInfo("Draw on Play", "Play turns into Draw when no card is drawn, as well as the usual Play behavior.", AST.JobID, 6, "", "")]
        AST_Cards_DrawOnPlay = 1000,

        [ParentCombo(AST_Cards_DrawOnPlay)]
        [CustomComboInfo("Redraw Feature", "Sets Play to Redraw if you pull a card with a seal you already have and you can use Redraw.", AST.JobID)]
        AST_Cards_Redraw = 1032,

        [ReplaceSkill(AST.Draw)]
        [CustomComboInfo("Redraw on Draw", "Sets Draw to Redraw if you have the Clarifying Draw buff.", AST.JobID)]
        AST_Cards_RedrawStandalone = 1040,

        [ReplaceSkill(AST.Play)]
        //Works With AST_Cards_DrawOnPlay as a feature, or by itself if AST_Cards_DrawOnPlay is disabled.
        //Do not do ConflictingCombos with AST_Cards_DrawOnPlay
        [CustomComboInfo("Astrodyne on Play", "Play becomes Astrodyne when you have 3 seals.", AST.JobID, 18, "", "")]
        AST_Cards_AstrodyneOnPlay = 1015,

        [CustomComboInfo("Quick Target Cards", "Grabs a suitable target from the party list when you draw a card and targets them for you.", AST.JobID)]
        AST_Cards_QuickTargetCards = 1029,

        [ParentCombo(AST_Cards_QuickTargetCards)]
        [CustomComboInfo("Add Tanks/Healers to Auto-Target", "Targets a tank or healer if no DPS remain for quick target selection", AST.JobID)]
        AST_Cards_QuickTargetCards_TargetExtra = 1031,
        #endregion

        // Last value = 1039

        #endregion

        #region BLACK MAGE

        [ReplaceSkill(BLM.Fire)]
        [ConflictingCombos(BLM_Scathe_Xeno, BLM_ST_AdvancedMode)]
        [CustomComboInfo("Simple Mode - Single Target", "Replaces Fire with a full one-button single target rotation.\nThis is the ideal option for newcomers to the job.", BLM.JobID, -10, "", "")]
        BLM_ST_SimpleMode = 2012,

        #region Advanced ST

        [ReplaceSkill(BLM.Fire)]
        [ConflictingCombos(BLM_Scathe_Xeno, BLM_ST_SimpleMode)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replaces Fire with a full one-button single target rotation.\nThese features are ideal if you want to customize the rotation.", BLM.JobID, -9, "", "")]
        BLM_ST_AdvancedMode = 2021,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Thunder I/III Option", "Adds Thunder I/Thunder III when the debuff isn't present or is expiring.", BLM.JobID)]
        BLM_ST_Adv_Thunder = 2029,

        [ParentCombo(BLM_ST_Adv_Thunder)]
        [CustomComboInfo("Thundercloud Spender Option", "Spends Thundercloud as soon as possible rather than waiting until Thunder is expiring.", BLM.JobID)]
        BLM_ST_Adv_Thunder_ThunderCloud = 2030,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Umbral Soul Option", "Uses Transpose/Umbral Soul when no target is selected.", BLM.JobID, 10, "", "")]
        BLM_Adv_UmbralSoul = 2035,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Movement Options", "Choose options to be used during movement.", BLM.JobID)]
        BLM_Adv_Movement = 2036,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Triplecast/Swiftcast Option", "Adds Triplecast/Swiftcast to the rotation.", BLM.JobID, -8, "", "")]
        BLM_Adv_Casts = 2039,

        [ParentCombo(BLM_Adv_Casts)]
        [CustomComboInfo("Pool Triplecast Option", "Keep one Triplecast charge for movement.", BLM.JobID)]
        BLM_Adv_Triplecast_Pooling = 2040,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Cooldown Options", "Select which cooldowns to add to the rotation.", BLM.JobID, -8, "", "")]
        BLM_Adv_Cooldowns = 2042,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Opener Option", "Adds the Lv.90 opener." +
            "\nWill default to the Standard opener when nothing is selected.", BLM.JobID, -10, "", "")]
        BLM_Adv_Opener = 2043,

        [ParentCombo(BLM_ST_AdvancedMode)]
        [CustomComboInfo("Rotation Option", "Choose which rotation to use." +
            "\nWill default to the Standard rotation when nothing is selected.", BLM.JobID, -9, "", "")]
        BLM_Adv_Rotation = 2045,

        #endregion

        [ReplaceSkill(BLM.Blizzard2, BLM.HighBlizzard2)]
        [ConflictingCombos(BLM_AoE_AdvancedMode)]
        [CustomComboInfo("Simple Mode - AoE", "Replaces Blizzard II with a full one-button AoE rotation.\nThis is the ideal option for newcomers to the job.", BLM.JobID, -8, "", "")]
        BLM_AoE_SimpleMode = 2008,

        #region Advanced AoE

        [ReplaceSkill(BLM.Blizzard2, BLM.HighBlizzard2)]
        [ConflictingCombos(BLM_AoE_SimpleMode)]
        [CustomComboInfo("Advanced Mode - AoE", "Replaces Blizzard II with a full one-button AoE rotation.\nThese features are ideal if you want to customize the rotation.", BLM.JobID, -8, "", "")]
        BLM_AoE_AdvancedMode = 2054,

        [ParentCombo(BLM_AoE_AdvancedMode)]
        [CustomComboInfo("Thunder Uptime Option", "Adds Thunder II/Thunder IV during Umbral Ice.", BLM.JobID, 1, "", "")]
        BLM_AoE_Adv_ThunderUptime = 2055,

        [ParentCombo(BLM_AoE_Adv_ThunderUptime)]
        [CustomComboInfo("Uptime in Astral Fire", "Maintains uptime during Astral Fire.", BLM.JobID, 1, "", "")]
        BLM_AoE_Adv_ThunderUptime_AstralFire = 2056,

        [ParentCombo(BLM_AoE_AdvancedMode)]
        [CustomComboInfo("Foul Option", "Adds Foul when available during Astral Fire.", BLM.JobID, 2, "", "")]
        BLM_AoE_Adv_Foul = 2044,

        [ParentCombo(BLM_AoE_AdvancedMode)]
        [CustomComboInfo("Umbral Soul Option", "Use Transpose/Umbral Soul when no target is selected.", BLM.JobID, 99, "", "")]
        BLM_AoE_Adv_UmbralSoul = 2049,

        [ParentCombo(BLM_AoE_AdvancedMode)]
        [CustomComboInfo("Cooldown Options", "Select which cooldowns to add to the rotation.", BLM.JobID, 1, "", "")]
        BLM_AoE_Adv_Cooldowns = 2052,

        #endregion

        #region Variant

        [Variant]
        [VariantParent(BLM_ST_SimpleMode, BLM_ST_AdvancedMode, BLM_AoE_SimpleMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", BLM.JobID)]
        BLM_Variant_Rampart = 2032,

        [Variant]
        [CustomComboInfo("Raise Option", "Turn Swiftcast into Variant Raise whenever you have the Swiftcast buff.", BLM.JobID)]
        BLM_Variant_Raise = 2033,

        [Variant]
        [VariantParent(BLM_ST_SimpleMode, BLM_ST_AdvancedMode, BLM_AoE_SimpleMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", BLM.JobID)]
        BLM_Variant_Cure = 2034,

        #endregion

        #region Miscellaneous
        [ReplaceSkill(BLM.Transpose)]
        [CustomComboInfo("Umbral Soul/Transpose Feature", "Replaces Transpose with Umbral Soul when Umbral Soul is available.", BLM.JobID)]
        BLM_UmbralSoul = 2001,

        [ReplaceSkill(BLM.LeyLines)]
        [CustomComboInfo("Between the Ley Lines Feature", "Replaces Ley Lines with Between the Lines when Ley Lines is active.", BLM.JobID)]
        BLM_Between_The_LeyLines = 2002,

        [ReplaceSkill(BLM.Blizzard, BLM.Freeze)]
        [CustomComboInfo("Blizzard I/III Feature", "Replaces Blizzard I with Blizzard III when out of Umbral Ice." +
            "\nReplaces Freeze with Blizzard II when synced below Lv.40.", BLM.JobID)]
        BLM_Blizzard_1to3 = 2003,

        [ReplaceSkill(BLM.Scathe)]
        [ConflictingCombos(BLM_ST_SimpleMode, BLM_ST_AdvancedMode)]
        [CustomComboInfo("Xenoglossy Feature", "Replaces Scathe with Xenoglossy when available.", BLM.JobID)]
        BLM_Scathe_Xeno = 2004,

        [ReplaceSkill(BLM.Fire)]
        [CustomComboInfo("Fire I/III Feature", "Replaces Fire I with Fire III outside of Astral Fire or when Firestarter is up.", BLM.JobID)]
        BLM_Fire_1to3 = 2005,

        [ReplaceSkill(BLM.AetherialManipulation)]
        [CustomComboInfo("Aetherial Manipulation Feature", "Replaces Aetherial Manipulation with Between the Lines when you are out of active Ley Lines and standing still.", BLM.JobID)]
        BLM_Aetherial_Manipulation = 2046,
        #endregion

        // Last value = 2057

        #endregion

        #region BLUE MAGE

        [BlueInactive(BLU.SongOfTorment, BLU.Bristle)]
        [ReplaceSkill(BLU.SongOfTorment)]
        [CustomComboInfo("Buffed Song of Torment", "Turns Song of Torment into Bristle so Song of Torment is buffed.", BLU.JobID)]
        BLU_BuffedSoT = 70000,

        [BlueInactive(BLU.Whistle, BLU.Tingle, BLU.MoonFlute, BLU.JKick, BLU.TripleTrident, BLU.Nightbloom, BLU.RoseOfDestruction, BLU.FeatherRain, BLU.Bristle, BLU.GlassDance, BLU.Surpanakha, BLU.MatraMagic, BLU.ShockStrike, BLU.PhantomFlurry)]
        [ReplaceSkill(BLU.MoonFlute)]
        [ConflictingCombos(BLU_NewMoonFluteOpener)]
        [CustomComboInfo("Moon Flute Opener", "Puts the Full Moon Flute Opener on Moon Flute or Whistle.", BLU.JobID)]
        BLU_Opener = 70001,

        [BlueInactive(BLU.MoonFlute, BLU.Tingle, BLU.ShockStrike, BLU.Whistle, BLU.FinalSting)]
        [ReplaceSkill(BLU.FinalSting)]
        [CustomComboInfo("Final Sting Combo Feature", "Turns Final Sting into the buff combo of: Moon Flute, Tingle, Whistle, Final Sting. Will use any primals off cooldown before casting Final Sting.", BLU.JobID)]
        BLU_FinalSting = 70002,

        [BlueInactive(BLU.RoseOfDestruction, BLU.FeatherRain, BLU.GlassDance, BLU.JKick)]
        [ParentCombo(BLU_FinalSting)]
        [CustomComboInfo("Off-cooldown Primal Additions", "Adds any Primals that are off cooldown to the Final Sting Combo Feature.", BLU.JobID)]
        BLU_Primals = 70003,

        [BlueInactive(BLU.RamsVoice, BLU.Ultravibration)]
        [ReplaceSkill(BLU.Ultravibration)]
        [CustomComboInfo("Ram's Voice into Ultravibration", "Turns Ultravibration into Ram's Voice if Deep Freeze isn't on the target. Will swiftcast Ultravibration if available.", BLU.JobID)]
        BLU_Ultravibrate = 70005,

        [BlueInactive(BLU.Offguard, BLU.BadBreath, BLU.Devour)]
        [ReplaceSkill(BLU.Devour, BLU.Offguard, BLU.BadBreath)]
        [CustomComboInfo("Tank Debuff Feature", "Puts Devour, Off-Guard, Lucid Dreaming, and Bad Breath into one button when under Tank Mimicry.", BLU.JobID)]
        BLU_DebuffCombo = 70006,

        [BlueInactive(BLU.MagicHammer)]
        [ReplaceSkill(BLU.MagicHammer)]
        [CustomComboInfo("Addle/Magic Hammer Debuff Feature", "Turns Magic Hammer into Addle when off CD.", BLU.JobID)]
        BLU_Addle = 70007,

        [BlueInactive(BLU.FeatherRain, BLU.ShockStrike, BLU.RoseOfDestruction, BLU.GlassDance)]
        [ReplaceSkill(BLU.FeatherRain)]
        [CustomComboInfo("Primal Feature", "Turns Feather Rain into any Primals that are off CD. \nWill cause primals to desync from Moon Flute burst phases if used on CD.", BLU.JobID)]
        BLU_PrimalCombo = 70008,

        [BlueInactive(BLU.BlackKnightsTour, BLU.WhiteKnightsTour)]
        [ReplaceSkill(BLU.BlackKnightsTour, BLU.WhiteKnightsTour)]
        [CustomComboInfo("Knight's Tour Feature", "Turns Black Knight's Tour or White Knight's Tour into its counterpart when the enemy is under the effect of the spell's debuff.", BLU.JobID)]
        BLU_KnightCombo = 70009,

        [BlueInactive(BLU.PeripheralSynthesis, BLU.MustardBomb)]
        [ReplaceSkill(BLU.PeripheralSynthesis)]
        [CustomComboInfo("Peripheral Synthesis into Mustard Bomb", "Turns Peripheral Synthesis into Mustard Bomb when target is under the effect of Lightheaded.", BLU.JobID)]
        BLU_LightHeadedCombo = 70010,

        [BlueInactive(BLU.BasicInstinct)]
        [ParentCombo(BLU_FinalSting)]
        [CustomComboInfo("Solo Mode", "Uses Basic Instinct if you're in an instance and on your own.", BLU.JobID)]
        BLU_SoloMode = 70011,

        [BlueInactive(BLU.HydroPull)]
        [ParentCombo(BLU_Ultravibrate)]
        [CustomComboInfo("Hydro Pull Setup", "Uses Hydro Pull before using Ram's Voice.", BLU.JobID)]
        BLU_HydroPull = 70012,

        [BlueInactive(BLU.JKick)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("J Kick Option", "Adds J Kick to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_JKick = 70013,

        [BlueInactive(BLU.SeaShanty)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Sea Shanty Option", "Adds Sea Shanty to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_SeaShanty = 70024,

        [BlueInactive(BLU.WingedRepropbation)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Winged Reprobration Option", "Adds Winged Reprobation to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_WingedReprobation = 70025,

        [BlueInactive(BLU.PerpetualRay, BLU.SharpenedKnife)]
        [CustomComboInfo("Perpetual Ray into Sharpened Knife Feature", "Turns Perpetual Ray into Sharpened Knife when target is stunned and in melee range.", BLU.JobID)]
        BLU_PerpetualRayStunCombo = 70014,

        [BlueInactive(BLU.FeatherRain, BLU.ShockStrike, BLU.RoseOfDestruction, BLU.GlassDance)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Moon Flute Burst Pooling Option", "Holds spells if Moon Flute burst is about to occur and spells are off cooldown.", BLU.JobID)]
        BLU_PrimalCombo_Pool = 70015,

        [BlueInactive(BLU.SonicBoom, BLU.SharpenedKnife)]
        [CustomComboInfo("Sonic Boom Melee Feature", "Turns Sonic Boom into Sharpened Knife when in melee range.", BLU.JobID)]
        BLU_MeleeCombo = 70016,

        [BlueInactive(BLU.MatraMagic)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Matra Magic Option", "Adds Matra Magic to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_Matra = 70017,

        [BlueInactive(BLU.Surpanakha)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Surpanakha Option", "Adds Surpanakha to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_Suparnakha = 70018,

        [BlueInactive(BLU.PhantomFlurry)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Phantom Flurry Option", "Adds Phantom Flurry to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_PhantomFlurry = 70019,

        [BlueInactive(BLU.Nightbloom, BLU.Bristle)]
        [ParentCombo(BLU_PrimalCombo)]
        [CustomComboInfo("Nightbloom Option", "Adds Nightbloom to the Primal Feature.", BLU.JobID)]
        BLU_PrimalCombo_Nightbloom = 70020,

        [ReplaceSkill(BLU.MoonFlute)]
        [BlueInactive(BLU.Whistle, BLU.Tingle, BLU.RoseOfDestruction, BLU.MoonFlute, BLU.JKick, BLU.TripleTrident, BLU.Nightbloom, BLU.WingedRepropbation, BLU.SeaShanty, BLU.BeingMortal, BLU.ShockStrike, BLU.Surpanakha, BLU.MatraMagic, BLU.PhantomFlurry, BLU.Bristle)]
        [ConflictingCombos(BLU_Opener)]
        [CustomComboInfo("New BLU Moon Flute Opener (Level 80 Edition)", "Turns Moon Flute into a full opener (level 80 update)", BLU.JobID)]
        BLU_NewMoonFluteOpener = 70021,

        [BlueInactive(BLU.BreathOfMagic, BLU.MortalFlame)]
        [ParentCombo(BLU_NewMoonFluteOpener)]
        [CustomComboInfo("DoT Opener", "Changes the opener to apply either Mortal Flame or Breath of Magic instead of using Winged Reprobation", BLU.JobID)]
        BLU_NewMoonFluteOpener_DoTOpener = 70022,

        [ReplaceSkill(BLU.DeepClean)]
        [BlueInactive(BLU.PeatPelt, BLU.DeepClean)]
        [CustomComboInfo("Peat Clean", "Changes Deep Clean to Peat Pelt if current target is not inflicted with Begrimed.", BLU.JobID)]
        BLU_PeatClean = 70023,

        // Last value = 70023

        #endregion

        #region BARD

        [ReplaceSkill(BRD.HeavyShot, BRD.BurstShot)]
        [ConflictingCombos(BRD_ST_SimpleMode)]
        [CustomComboInfo("Heavy Shot into Straight Shot Feature", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced.", BRD.JobID)]
        BRD_StraightShotUpgrade = 3001,

        [ConflictingCombos(BRD_ST_SimpleMode)]
        [ParentCombo(BRD_StraightShotUpgrade)]
        [CustomComboInfo("DoT Maintenance Option", "Enabling this option will make Heavy Shot into Straight Shot refresh your DoTs on your current.", BRD.JobID)]
        BRD_DoTMaintainance = 3002,

        [ReplaceSkill(BRD.IronJaws)]
        [ConflictingCombos(BRD_IronJaws_Alternate)]
        [CustomComboInfo("Iron Jaws Feature", "Iron Jaws is replaced with Caustic Bite/Stormbite if one or both are not up.\nAlternates between the two if Iron Jaws isn't available.", BRD.JobID)]
        BRD_IronJaws = 3003,

        [ReplaceSkill(BRD.IronJaws)]
        [ConflictingCombos(BRD_IronJaws)]
        [CustomComboInfo("Iron Jaws Alternate Feature", "Iron Jaws is replaced with Caustic Bite/Stormbite if one or both are not up.\nIron Jaws will only show up when debuffs are about to expire.", BRD.JobID)]
        BRD_IronJaws_Alternate = 3004,

        [ReplaceSkill(BRD.BurstShot, BRD.QuickNock)]
        [ConflictingCombos(BRD_ST_SimpleMode)]
        [CustomComboInfo("Burst Shot/Quick Nock to Apex Arrow Feature", "Replaces Burst Shot and Quick Nock with Apex Arrow when gauge is full and Blast Arrow when you are Blast Arrow ready.", BRD.JobID)]
        BRD_Apex = 3005,

        [ReplaceSkill(BRD.Bloodletter)]
        [ConflictingCombos(BRD_ST_SimpleMode)]
        [CustomComboInfo("Single Target oGCD Feature", "All oGCD's on Bloodletter (+ Songs rotation) depending on their CD.", BRD.JobID)]
        BRD_ST_oGCD = 3006,

        [ReplaceSkill(BRD.RainOfDeath)]
        [ConflictingCombos(BRD_AoE_Combo)]
        [CustomComboInfo("AoE oGCD Feature", "All AoE oGCD's on Rain of Death depending on their CD.", BRD.JobID)]
        BRD_AoE_oGCD = 3007,

        [ReplaceSkill(BRD.QuickNock, BRD.Ladonsbite)]
        [ConflictingCombos(BRD_AoE_SimpleMode)]
        [CustomComboInfo("AoE Combo Feature", "Replaces Quick Nock/Ladonsbite with Shadowbite when ready.", BRD.JobID)]
        BRD_AoE_Combo = 3008,

        [ReplaceSkill(BRD.HeavyShot, BRD.BurstShot)]
        [ConflictingCombos(BRD_StraightShotUpgrade, BRD_DoTMaintainance, BRD_Apex, BRD_ST_oGCD, BRD_IronJawsApex)]
        [CustomComboInfo("Simple Bard Feature", "Adds every single target ability to one button,\nIf there are DoTs on target, Simple Bard will try to maintain their uptime.", BRD.JobID)]
        BRD_ST_SimpleMode = 3009,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Bard DoTs Option", "This option will make Simple Bard apply DoTs if none are present on the target.", BRD.JobID)]
        BRD_Simple_DoT = 3010,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Bard Songs Option", "This option adds the Bard's Songs to the Simple Bard Feature.", BRD.JobID)]
        BRD_Simple_Song = 3011,

        [ParentCombo(BRD_AoE_oGCD)]
        [CustomComboInfo("Songs Feature", "Adds Songs onto AoE oGCD Feature.", BRD.JobID)]
        BRD_oGCDSongs = 3012,

        [CustomComboInfo("Bard Buffs Feature", "Adds Raging Strikes and Battle Voice onto Barrage.", BRD.JobID)]
        BRD_Buffs = 3013,

        [ReplaceSkill(BRD.WanderersMinuet)]
        [CustomComboInfo("One Button Songs Feature", "Add Mage's Ballad and Army's Paeon to Wanderer's Minuet depending on cooldowns.", BRD.JobID)]
        BRD_OneButtonSongs = 3014,

        [ReplaceSkill(BRD.QuickNock, BRD.Ladonsbite)]
        [CustomComboInfo("Simple AoE Bard Feature", "Weaves oGCDs onto Quick Nock/Ladonsbite.", BRD.JobID)]
        BRD_AoE_SimpleMode = 3015,

        [ParentCombo(BRD_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Bard Song Option", "Weave Songs on the Simple AoE.", BRD.JobID)]
        BRD_AoE_Simple_Songs = 3016,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Buffs Option", "Adds buffs onto the Simple Bard feature.", BRD.JobID)]
        BRD_Simple_Buffs = 3017,

        [ParentCombo(BRD_Simple_Buffs)]
        [CustomComboInfo("Simple Buffs - Radiant Option", "Adds Radiant Finale to the Simple Buffs feature.", BRD.JobID)]
        BRD_Simple_BuffsRadiant = 3018,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple No Waste Option", "Adds enemy health checking on mobs for buffs, DoTs and Songs.\nThey will not be reapplied if less than specified.", BRD.JobID)]
        BRD_Simple_NoWaste = 3019,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Interrupt Option", "Uses interrupt during the rotation if applicable.", BRD.JobID)]
        BRD_Simple_Interrupt = 3020,

        [CustomComboInfo("Disable Apex Arrow Feature", "Removes Apex Arrow from Simple Bard and AoE Feature.", BRD.JobID)]
        BRD_RemoveApexArrow = 3021,

        //[ConflictingCombos(BardoGCDSingleTargetFeature)]
        //[ParentCombo(SimpleBardFeature)]
        //[CustomComboInfo("Simple Opener", "Adds the optimum opener to simple bard.\nThis conflicts with pretty much everything outside of simple bard options due to the nature of the opener.", BRD.JobID)]
        //BardSimpleOpener = 3022,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Pooling Option", "Pools Bloodletter charges to allow for optimum burst phases.", BRD.JobID)]
        BRD_Simple_Pooling = 3023,

        [ConflictingCombos(BRD_ST_SimpleMode)]
        [ParentCombo(BRD_IronJaws)]
        [CustomComboInfo("Iron Jaws Apex Option", "Adds Apex and Blast Arrow to Iron Jaws when available.", BRD.JobID)]
        BRD_IronJawsApex = 3024,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Simple Raging Jaws Option", "Enable the snapshotting of DoTs, within the remaining time of Raging Strikes below:", BRD.JobID)]
        BRD_Simple_RagingJaws = 3025,

        [ParentCombo(BRD_Simple_DoT)]
        [CustomComboInfo("Opener Only Option", "Until the first auto-refresh you can DoT new targets automatically.", BRD.JobID)]
        BRD_Simple_DoTOpener = 3026,

        [ParentCombo(BRD_AoE_Simple_Songs)]
        [CustomComboInfo("Exclude Wanderer's Minuet Option", "Dont use Wanderer's Minuet.", BRD.JobID)]
        BRD_AoE_Simple_SongsExcludeWM = 3027,

        [ParentCombo(BRD_ST_SimpleMode)]
        [CustomComboInfo("Second Wind Option", "Uses Second Wind when below set HP percentage.", BRD.JobID)]
        BRD_ST_SecondWind = 3028,

        [ParentCombo(BRD_AoE_SimpleMode)]
        [CustomComboInfo("Second Wind Option", "Uses Second Wind when below set HP percentage.", BRD.JobID)]
        BRD_AoE_SecondWind = 3029,

        [Variant]
        [VariantParent(BRD_ST_SimpleMode, BRD_AoE_SimpleMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", BRD.JobID)]
        BRD_Variant_Rampart = 3030,

        [Variant]
        [VariantParent(BRD_ST_SimpleMode, BRD_AoE_SimpleMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", BRD.JobID)]
        BRD_Variant_Cure = 3031,

        // Last value = 3031

        #endregion

        #region DANCER

        #region Single Target Multibutton
        [ReplaceSkill(DNC.Cascade)]
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Single Target Multibutton Feature", "Single target combo with Fan Dances and Esprit use.", DNC.JobID)]
        DNC_ST_MultiButton = 4000,

        [ParentCombo(DNC_ST_MultiButton)]
        [CustomComboInfo("ST Esprit Overcap Option", "Adds Saber Dance above the set Esprit threshold.", DNC.JobID)]
        DNC_ST_EspritOvercap = 4001,

        [ParentCombo(DNC_ST_MultiButton)]
        [CustomComboInfo("Fan Dance Overcap Protection Option", "Adds Fan Dance 1 when Fourfold Feathers are full.", DNC.JobID)]
        DNC_ST_FanDanceOvercap = 4003,

        [ParentCombo(DNC_ST_MultiButton)]
        [CustomComboInfo("Fan Dance Option", "Adds Fan Dance 3/4 when available.", DNC.JobID)]
        DNC_ST_FanDance34 = 4004,
        #endregion

        #region AoE Multibutton
        [ReplaceSkill(DNC.Windmill)]
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("AoE Multibutton Feature", "AoE combo with Fan Dances and Esprit use.", DNC.JobID)]
        DNC_AoE_MultiButton = 4010,

        [ParentCombo(DNC_AoE_MultiButton)]
        [CustomComboInfo("AoE Esprit Overcap Option", "Adds Saber Dance above the set Esprit threshold.", DNC.JobID)]
        DNC_AoE_EspritOvercap = 4011,

        [ParentCombo(DNC_AoE_MultiButton)]
        [CustomComboInfo("AoE Fan Dance Overcap Protection Option", "Adds Fan Dance 2 when Fourfold Feathers are full.", DNC.JobID)]
        DNC_AoE_FanDanceOvercap = 4013,

        [ParentCombo(DNC_AoE_MultiButton)]
        [CustomComboInfo("AoE Fan Dance Option", "Adds Fan Dance 3/4 when available.", DNC.JobID)]
        DNC_AoE_FanDance34 = 4014,
        #endregion

        #region Dance Features
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Dance Features", "Features and options involving Standard Step and Technical Step.\nCollapsing this category does NOT disable the features inside.", DNC.JobID)]
        DNC_Dance_Menu = 4020,

        #region Combined Dance Feature
        [ReplaceSkill(DNC.StandardStep)]
        [ParentCombo(DNC_Dance_Menu)]
        [ConflictingCombos(DNC_DanceStepCombo, DNC_DanceComboReplacer, DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Combined Dance Feature", "Standard And Technical Dance on one button (SS)." +
        "\nStandard > Technical." +
        "\nThis combos out into Tillana and Starfall Dance.", DNC.JobID)]
        DNC_CombinedDances = 4022,

        [ParentCombo(DNC_CombinedDances)]
        [CustomComboInfo("Devilment Plus Option", "Adds Devilment right after Technical finish.", DNC.JobID)]
        DNC_CombinedDances_Devilment = 4023,

        [ParentCombo(DNC_CombinedDances)]
        [CustomComboInfo("Flourish Plus Option", "Adds Flourish to the Combined Dance Feature.", DNC.JobID)]
        DNC_CombinedDances_Flourish = 4024,
        #endregion

        [ParentCombo(DNC_Dance_Menu)]
        [ConflictingCombos(DNC_DanceStepCombo, DNC_CombinedDances, DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Custom Dance Step Feature",
        "Change custom actions into dance steps while dancing." +
        "\nThis helps ensure you can still dance with combos on, without using auto dance." +
        "\nYou can change the respective actions by inputting action IDs below for each dance step." +
        "\nThe defaults are Cascade, Flourish, Fan Dance and Fan Dance II. If set to 0, they will reset to these actions." +
        "\nYou can get Action IDs with Garland Tools by searching for the action and clicking the cog.", DNC.JobID)]
        DNC_DanceComboReplacer = 4025,
        #endregion

        #region Flourishing Features
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Flourishing Features", "Features and options involving Fourfold Feathers and Flourish." +
        "\nCollapsing this category does NOT disable the features inside.", DNC.JobID)]
        DNC_FlourishingFeatures_Menu = 4030,

        [ReplaceSkill(DNC.Flourish)]
        [ParentCombo(DNC_FlourishingFeatures_Menu)]
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Flourishing Fan Dance Feature", "Replace Flourish with Fan Dance 3 & 4 during weave-windows, when Flourish is on cooldown.", DNC.JobID)]
        DNC_FlourishingFanDances = 4032,
        #endregion

        #region Fan Dance Combo Features
        [ParentCombo(DNC_FlourishingFeatures_Menu)]
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Fan Dance Combo Feature", "Options for Fan Dance combos." +
        "\nFan Dance 3 takes priority over Fan Dance 4.", DNC.JobID)]
        DNC_FanDanceCombos = 4033,

        [ReplaceSkill(DNC.FanDance1)]
        [ParentCombo(DNC_FanDanceCombos)]
        [CustomComboInfo("Fan Dance 1 -> 3 Option", "Changes Fan Dance 1 to Fan Dance 3 when available.", DNC.JobID)]
        DNC_FanDance_1to3_Combo = 4034,

        [ReplaceSkill(DNC.FanDance1)]
        [ParentCombo(DNC_FanDanceCombos)]
        [CustomComboInfo("Fan Dance 1 -> 4 Option", "Changes Fan Dance 1 to Fan Dance 4 when available.", DNC.JobID)]
        DNC_FanDance_1to4_Combo = 4035,

        [ReplaceSkill(DNC.FanDance2)]
        [ParentCombo(DNC_FanDanceCombos)]
        [CustomComboInfo("Fan Dance 2 -> 3 Option", "Changes Fan Dance 2 to Fan Dance 3 when available.", DNC.JobID)]
        DNC_FanDance_2to3_Combo = 4036,

        [ReplaceSkill(DNC.FanDance2)]
        [ParentCombo(DNC_FanDanceCombos)]
        [CustomComboInfo("Fan Dance 2 -> 4 Option", "Changes Fan Dance 2 to Fan Dance 4 when available.", DNC.JobID)]
        DNC_FanDance_2to4_Combo = 4037,
        #endregion

        // Devilment --> Starfall
        [ReplaceSkill(DNC.Devilment)]
        [ConflictingCombos(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Devilment to Starfall Feature", "Change Devilment into Starfall Dance after use.", DNC.JobID)]
        DNC_Starfall_Devilment = 4038,

        [ReplaceSkill(DNC.StandardStep, DNC.TechnicalStep)]
        [ConflictingCombos(DNC_CombinedDances, DNC_DanceComboReplacer)]
        [CustomComboInfo("Dance Step Combo Feature", "Change Standard Step and Technical Step into each dance step, while dancing." +
        "\nWorks with Simple Dancer and Simple Dancer AoE.", DNC.JobID)]
        DNC_DanceStepCombo = 4039,

        #region Simple Dancer (Single Target)
        [ReplaceSkill(DNC.Cascade)]
        [ConflictingCombos(DNC_ST_MultiButton, DNC_AoE_MultiButton, DNC_CombinedDances, DNC_DanceComboReplacer, DNC_FlourishingFeatures_Menu, DNC_Starfall_Devilment)]
        [CustomComboInfo("Simple Dancer (Single Target) Feature", "Single button, single target. Includes songs, flourishes and overprotections." +
        "\nConflicts with all other non-simple toggles, except 'Dance Step Combo'.", DNC.JobID)]
        DNC_ST_SimpleMode = 4050,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Interrupt Option", "Includes an interrupt in the rotation (if applicable to your current target).", DNC.JobID, 5, "", "")]
        DNC_ST_Simple_Interrupt = 4051,

        [ParentCombo(DNC_ST_SimpleMode)]
        [ConflictingCombos(DNC_ST_Simple_StandardFill)]
        [CustomComboInfo("Simple Standard Dance Option", "Includes Standard Step (and all steps) in the rotation.", DNC.JobID, 1, "", "")]
        DNC_ST_Simple_SS = 4052,

        [ParentCombo(DNC_ST_SimpleMode)]
        [ConflictingCombos(DNC_ST_Simple_SS)]
        [CustomComboInfo("Simple Standard Fill Option", "Adds ONLY Standard dance steps and Standard Finish to the rotation." +
        "\nStandard Step itself must be initiated manually when using this option.", DNC.JobID, 1, "", "")]
        DNC_ST_Simple_StandardFill = 4061,

        [ParentCombo(DNC_ST_SimpleMode)]
        [ConflictingCombos(DNC_ST_Simple_TechFill)]
        [CustomComboInfo("Simple Technical Dance Option", "Includes Technical Step, all dance steps and Technical Finish in the rotation.", DNC.JobID, 2, "", "")]
        DNC_ST_Simple_TS = 4053,

        [ParentCombo(DNC_ST_SimpleMode)]
        [ConflictingCombos(DNC_ST_Simple_TS)]
        [CustomComboInfo("Simple Tech Fill Option", "Adds ONLY Technical dance steps and Technical Finish to the rotation." +
        "\nTechnical Step itself must be initiated manually when using this option.", DNC.JobID, 2, "", "")]
        DNC_ST_Simple_TechFill = 4054,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Tech Devilment Option", "Includes Devilment in the rotation." +
        "\nWill activate only during Technical Finish if you're Lv70 or above." +
        "\nWill be used on cooldown below Lv70.", DNC.JobID, 2, "", "")]
        DNC_ST_Simple_Devilment = 4055,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Saber Dance Option", "Includes Saber Dance in the rotation when at or over the Esprit threshold.", DNC.JobID, 3, "", "")]
        DNC_ST_Simple_SaberDance = 4063,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Flourish Option", "Includes Flourish in the rotation.", DNC.JobID, 3, "", "")]
        DNC_ST_Simple_Flourish = 4056,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Feathers Option", "Expends a feather in the next available weave window when capped." +
        "\nWeaves feathers where possible during Technical Finish." +
        "\nWeaves feathers outside of burst when target is below set HP percentage (Set to 0 to disable)." +
        "\nWeaves feathers whenever available when under Lv.70.", DNC.JobID, 4, "", "")]
        DNC_ST_Simple_Feathers = 4057,

        /*
        [ParentCombo(DNC_ST_Simple_Feathers)]
        [CustomComboInfo("Simple Feather Pooling Option", "Expends a feather in the next available weave window when capped." +
        "\nWeaves feathers where possible during Technical Finish." +
        "\nWeaves feathers outside of burst when target is below set HP percentage.", DNC.JobID, 4, "", "")]
        DNC_ST_Simple_FeatherPooling = 4058,
        */

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Panic Heals Option", "Includes Curing Waltz and Second Wind in the rotation when available and your HP is below the set percentages.", DNC.JobID, 5, "", "")]
        DNC_ST_Simple_PanicHeals = 4059,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Improvisation Option", "Includes Improvisation in the rotation when available.", DNC.JobID, 5, "", "")]
        DNC_ST_Simple_Improvisation = 4060,

        [ParentCombo(DNC_ST_SimpleMode)]
        [CustomComboInfo("Simple Peloton Opener Option", "Uses Peloton when you are out of combat, do not already have the Peloton buff and are performing Standard Step with greater than 5s remaining of your dance." +
        "\nWill not override Dance Step Combo Feature.", DNC.JobID, 5, "", "")]
        DNC_ST_Simple_Peloton = 4062,
        #endregion

        #region Simple Dancer (AoE)
        [ReplaceSkill(DNC.Windmill)]
        [ConflictingCombos(DNC_ST_MultiButton, DNC_AoE_MultiButton, DNC_CombinedDances, DNC_DanceComboReplacer, DNC_FlourishingFeatures_Menu, DNC_Starfall_Devilment)]
        [CustomComboInfo("Simple Dancer (AoE) Feature", "Single button, AoE. Includes songs, flourishes and overprotections." +
        "\nConflicts with all other non-simple toggles, except 'Dance Step Combo'.", DNC.JobID)]
        DNC_AoE_SimpleMode = 4070,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Interrupt Option", "Includes an interrupt in the AoE rotation (if your current target can be interrupted).", DNC.JobID)]
        DNC_AoE_Simple_Interrupt = 4071,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [ConflictingCombos(DNC_AoE_Simple_StandardFill)]
        [CustomComboInfo("Simple AoE Standard Dance Option", "Includes Standard Step (and all steps) in the AoE rotation.", DNC.JobID, 1, "", "")]
        DNC_AoE_Simple_SS = 4072,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [ConflictingCombos(DNC_AoE_Simple_SS)]
        [CustomComboInfo("Simple AoE Standard Fill Option", "Adds ONLY Standard dance steps and Standard Finish to the AoE rotation." +
        "\nStandard Step itself must be initiated manually when using this option.", DNC.JobID, 2, "", "")]
        DNC_AoE_Simple_StandardFill = 4081,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [ConflictingCombos(DNC_AoE_Simple_TechFill)]
        [CustomComboInfo("Simple AoE Technical Dance Option", "Includes Technical Step, all dance steps and Technical Finish in the AoE rotation.", DNC.JobID, 3, "", "")]
        DNC_AoE_Simple_TS = 4073,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [ConflictingCombos(DNC_AoE_Simple_TS)]
        [CustomComboInfo("Simple AoE Tech Fill Option", "Adds ONLY Technical dance steps and Technical Finish to the AoE rotation." +
        "\nTechnical Step itself must be initiated manually when using this option.", DNC.JobID, 4, "", "")]
        DNC_AoE_Simple_TechFill = 4074,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Tech Devilment Option", "Includes Devilment in the AoE rotation." +
        "\nWill activate only during Technical Finish if you're Lv70 or above." +
        "\nWill be used on cooldown below Lv70.", DNC.JobID, 5, "", "")]
        DNC_AoE_Simple_Devilment = 4075,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Saber Dance Option", "Includes Saber Dance in the AoE rotation when at or over the Esprit threshold.", DNC.JobID, 6, "", "")]
        DNC_AoE_Simple_SaberDance = 4082,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Flourish Option", "Includes Flourish in the AoE rotation.", DNC.JobID, 6, "", "")]
        DNC_AoE_Simple_Flourish = 4076,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Feathers Option", "Expends a feather in the next available weave window when capped." +
        "\nWeaves feathers where possible during Technical Finish." +
        "\nWeaves feathers whenever available when under Lv.70.", DNC.JobID, 7, "", "")]
        DNC_AoE_Simple_Feathers = 4077,

        /*
        [ParentCombo(DNC_AoE_Simple_Feathers)]
        [CustomComboInfo("Simple AoE Feather Pooling Option", "Expends a feather in the next available weave window when capped.", DNC.JobID, 8, "", "")]
        DNC_AoE_Simple_FeatherPooling = 4078,
        */

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Panic Heals Option", "Includes Curing Waltz and Second Wind in the AoE rotation when available and your HP is below the set percentages.", DNC.JobID, 9, "", "")]
        DNC_AoE_Simple_PanicHeals = 4079,

        [ParentCombo(DNC_AoE_SimpleMode)]
        [CustomComboInfo("Simple AoE Improvisation Option", "Includes Improvisation in the AoE rotation when available.", DNC.JobID, 10, "", "")]
        DNC_AoE_Simple_Improvisation = 4080,
        #endregion

        #region Variant
        [Variant]
        [VariantParent(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", DNC.JobID)]
        DNC_Variant_Rampart = 4083,

        [Variant]
        [VariantParent(DNC_ST_SimpleMode, DNC_AoE_SimpleMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", DNC.JobID)]
        DNC_Variant_Cure = 4084,


        #endregion

        // Last value = 4084

        #endregion

        #region DARK KNIGHT

        [ParentCombo(DRK_SouleaterCombo)]
        [CustomComboInfo("Buffs on Main Combo", "Collection of buffs to add to the main combo", DRK.JobID)]
        DRK_MainComboBuffs_Group = 5098,

        [ConflictingCombos(DRK_oGCD)]
        [ParentCombo(DRK_SouleaterCombo)]
        [CustomComboInfo("Cooldowns on Main Combo", "Collection of cooldowns to add to the main combo", DRK.JobID)]
        DRK_MainComboCDs_Group = 5099,

        [ReplaceSkill(DRK.Souleater)]
        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain. \nIf all sub options are selected will turn into a full one button rotation (Advanced Dark Knight)", DRK.JobID)]
        DRK_SouleaterCombo = 5000,

        [ReplaceSkill(DRK.StalwartSoul)]
        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain.", DRK.JobID)]
        DRK_StalwartSoulCombo = 5001,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Bloodspiller Feature", "Adds Bloodspiller when Delirium is active.", DRK.JobID)]
        DRK_Bloodspiller = 5002,

        [ReplaceSkill(DRK.StalwartSoul)]
        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Dark Knight Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", DRK.JobID)]
        DRK_Overcap = 5003,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Living Shadow Feature", "Living Shadow will now be on main combo if its not on cooldown and you have gauge for it.", DRK.JobID)]
        DRK_LivingShadow = 5004,

        [ParentCombo(DRK_SouleaterCombo)]
        [CustomComboInfo("Edge of Shadow Overcap Feature", "Uses Edge of Shadow if you are above 8,500 mana or Darkside is about to expire (10sec or less)", DRK.JobID)]
        DRK_ManaOvercap = 5005,

        [ReplaceSkill(DRK.CarveAndSpit, DRK.AbyssalDrain)]
        [ConflictingCombos(DRK_MainComboCDs_Group)]
        [CustomComboInfo("oGCD Feature", "Adds Living Shadow > Salted Earth > Carve And Spit > Salt And Darkness to Carve And Spit and Abysal Drain", DRK.JobID)]
        DRK_oGCD = 5006,

        [ParentCombo(DRK_oGCD)]
        [CustomComboInfo("Shadowbringer oGCD Feature", "Adds Shadowbringer to oGCD Feature ", DRK.JobID)]
        DRK_Shadowbringer_oGCD = 5007,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Plunge Feature", "Adds Plunge onto main combo whenever its available and Darkside is up.", DRK.JobID)]
        DRK_Plunge = 5008,

        [ParentCombo(DRK_Bloodspiller)]
        [CustomComboInfo("Delayed Bloodspiller Feature", "Delays Bloodspiller by 2 GCDs when Delirium is used during even windows, uses it regularly during odd windows. Useful for feeding into raid buffs at level 90.", DRK.JobID)]
        DRK_DelayedBloodspiller = 5010,

        [ParentCombo(DRK_SouleaterCombo)]
        [CustomComboInfo("Unmend Uptime Feature", "Replace Souleater Combo Feature with Unmend when you are out of range.", DRK.JobID)]
        DRK_RangedUptime = 5011,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Abyssal Drain Feature", "Adds abyssal drain to the AoE combo when you fall below 60 percent hp.", DRK.JobID)]
        DRK_AoE_AbyssalDrain = 5013,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("AoE Shadowbringer Feature", "Adds Shadowbringer to the AoE combo.", DRK.JobID)]
        DRK_AoE_Shadowbringer = 5014,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Flood of Shadow Overcap Feature", "Uses Flood of Shadow if you are above 8.5k mana or Darkside is about to expire (10sec or less)", DRK.JobID)]
        DRK_AoE_ManaOvercap = 5015,

        [ParentCombo(DRK_SouleaterCombo)]
        [CustomComboInfo("Blood Gauge Overcap Feature", "Adds Bloodspiller onto main combo when at 80 blood gauge or higher", DRK.JobID)]
        DRK_BloodGaugeOvercap = 5016,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Shadowbringer Feature", "Adds Shadowbringer on main combo while Darkside is up. Will use all stacks on cooldown.", DRK.JobID)]
        DRK_Shadowbringer = 5019,

        [ParentCombo(DRK_ManaOvercap)]
        [CustomComboInfo("Edge of Shadow Burst Option", "Uses Edge of Shadow until chosen MP limit is reached during minute window bursts.", DRK.JobID)]
        DRK_EoSPooling = 5020,

        [ParentCombo(DRK_Shadowbringer)]
        [CustomComboInfo("Shadowbringer Burst Option", "Pools Shadowbringer to use during even minute window bursts.", DRK.JobID)]
        DRK_ShadowbringerBurst = 5021,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Carve and Spit Feature", "Adds Carve and Spit on main combo while Darkside is up.", DRK.JobID)]
        DRK_CarveAndSpit = 5022,

        [ParentCombo(DRK_Plunge)]
        [CustomComboInfo("Melee Plunge Option", "Uses Plunge when under Darkside and in the target ring (1 yalm).\nWill use as many stacks as selected in the above slider.", DRK.JobID)]
        DRK_MeleePlunge = 5023,

        [ParentCombo(DRK_MainComboCDs_Group)]
        [CustomComboInfo("Salted Earth Feature", "Adds Salted Earth on main combo while Darkside is up, will use Salt and Darkness if unlocked.", DRK.JobID)]
        DRK_SaltedEarth = 5024,

        [ParentCombo(DRK_MainComboBuffs_Group)]
        [CustomComboInfo("Delirium on Cooldown", "Adds Delirium to main combo on cooldown and when Darkside is up. Will also spend 50 blood gauge if Delirium is nearly ready to protect from overcap.", DRK.JobID)]
        DRK_Delirium = 5025,

        [ParentCombo(DRK_MainComboBuffs_Group)]
        [CustomComboInfo("Blood Weapon on Cooldown", "Adds Blood Weapon to main combo on cooldown and when Darkside is up.", DRK.JobID)]
        DRK_BloodWeapon = 5026,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Blood Weapon Option", "Adds Blood Weapon to AoE combo on cooldown and when Darkside is up.", DRK.JobID)]
        DRK_AoE_BloodWeapon = 5027,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Delirium Option", "Adds Deliriun to AoE combo on cooldown and when Darkside is up.", DRK.JobID)]
        DRK_AoE_Delirium = 5028,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Salted Earth Option", "Adds Salted Earth and Salt and Darkness to AoE on cooldown and when Darkside is up.", DRK.JobID)]
        DRK_AoE_SaltedEarth = 5029,

        [ParentCombo(DRK_StalwartSoulCombo)]
        [CustomComboInfo("Living Shadow Option", "Adds Living Shadow to AoE on cooldown and when Darkside is up.", DRK.JobID)]
        DRK_AoE_LivingShadow = 5030,

        [Variant]
        [VariantParent(DRK_SouleaterCombo, DRK_StalwartSoulCombo)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", DRK.JobID)]
        DRK_Variant_SpiritDart = 5031,

        [Variant]
        [VariantParent(DRK_SouleaterCombo, DRK_StalwartSoulCombo)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", DRK.JobID)]
        DRK_Variant_Cure = 5032,

        [Variant]
        [VariantParent(DRK_SouleaterCombo, DRK_StalwartSoulCombo)]
        [CustomComboInfo("Ultimatum Option", "Use Variant Ultimatum on cooldown.", DRK.JobID)]
        DRK_Variant_Ultimatum = 5033,

        // Last value = 5033

        #endregion

        #region DRAGOON

        [ReplaceSkill(DRG.TrueThrust)]
        [ConflictingCombos(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Simple Mode - Single Target", "Replaces True Thrust with a full one-button single target rotation.\nThis is the ideal option for newcomers to the job.", DRG.JobID)]
        DRG_ST_SimpleMode = 6001,

        #region Advanced ST Dragoon

        [ReplaceSkill(DRG.TrueThrust)]
        [ConflictingCombos(DRG_ST_SimpleMode)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replaces True Thrust with a full one-button single target rotation.\nThese features are ideal if you want to customize the rotation.", DRG.JobID, 1, "", "")]
        DRG_ST_AdvancedMode = 6100,

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Level 88+ Opener", "Adds the Balance opener to the rotation.\nOPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 1, "", "")]
        DRG_ST_Opener = 6101,

        #region Buffs ST

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Buffs Option", "Adds various buffs to the rotation.", DRG.JobID, 2, "", "")]
        DRG_ST_Buffs = 6102,

        [ParentCombo(DRG_ST_Buffs)]
        [CustomComboInfo("Battle Litany Option", "Adds Battle Litany to the rotation.", DRG.JobID)]
        DRG_ST_Litany = 6103,

        [ParentCombo(DRG_ST_Buffs)]
        [CustomComboInfo("Lance Charge Option", "Adds Lance Charge to the rotation.", DRG.JobID)]
        DRG_ST_Lance = 6104,

        [ParentCombo(DRG_ST_Buffs)]
        [CustomComboInfo("Dragon Sight Option", "Adds Dragon Sight to the rotation.\nOPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID)]
        DRG_ST_DragonSight = 6105,

        #endregion

        #region Cooldowns ST

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Cooldowns Option", "Adds various cooldowns to the rotation.", DRG.JobID, 3, "", "")]
        DRG_ST_CDs = 6106,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Life Surge Option", "Adds Life Surge, while under Dragon Sight and Lance Charge buffs, to the rotation.", DRG.JobID, -8, "", "")]
        DRG_ST_LifeSurge = 6107,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Dragonfire Dive Option", "Adds Dragonfire Dive to the rotation.", DRG.JobID, -7, "", "")]
        DRG_ST_Dives_Dragonfire = 6108,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Spineshatter Dive Option", "Adds Spineshatter Dive to the rotation.", DRG.JobID, -7, "", "")]
        DRG_ST_Dives_Spineshatter = 6109,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Stardiver Option", "Adds Stardiver to the rotation.", DRG.JobID, -7, "", "")]
        DRG_ST_Stardiver = 6110,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("High Jump Option", "Adds High Jump/Jump to the rotation.", DRG.JobID, -6, "", "")]
        DRG_ST_HighJump = 6111,

        [ParentCombo(DRG_ST_HighJump)]
        [CustomComboInfo("Mirage Dive Option", "Adds Mirage Dive to the rotation.", DRG.JobID)]
        DRG_ST_Mirage = 6112,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Geirskogul and Nastrond Option", "Adds Geirskogul and Nastrond to the rotation.", DRG.JobID, -5, "", "")]
        DRG_ST_GeirskogulNastrond = 6113,

        [ParentCombo(DRG_ST_CDs)]
        [CustomComboInfo("Wyrmwind Thrust Option", "Adds Wyrmwind Thrust to the rotation.", DRG.JobID, -4, "", "")]
        DRG_ST_Wyrmwind = 6114,

        #endregion

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Optimized Rotation Option", "Uses optimzed use of Geirskogul and (High) Jump/Mirage Dive", DRG.JobID, 4, "", "")]
        DRG_ST_Optimized_Rotation = 6115,

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Ranged Uptime Option", "Adds Piercing Talon to the rotation when you are out of melee range.", DRG.JobID, 5, "", "")]
        DRG_ST_RangedUptime = 6116,

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the rotation.", DRG.JobID, 6, "", "")]
        DRG_ST_ComboHeals = 6117,

        [ParentCombo(DRG_ST_AdvancedMode)]
        [CustomComboInfo("Dynamic True North Option", "Adds True North before Chaos Thrust/Chaotic Spring, Fang And Claw and Wheeling Thrust when you are not in the correct position for the enhanced potency bonus.", DRG.JobID, 7, "", "")]
        DRG_TrueNorthDynamic = 6118,

        #endregion

        [ReplaceSkill(DRG.DoomSpike)]
        [ConflictingCombos(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Simple Mode - AoE", "Replaces Doom Spike with a full one-button AoE rotation.\nThis is the ideal option for newcomers to the job.", DRG.JobID, 3, "", "")]
        DRG_AOE_SimpleMode = 6200,

        #region Advanced AoE Dragoon

        [ReplaceSkill(DRG.DoomSpike)]
        [ConflictingCombos(DRG_AOE_SimpleMode)]
        [CustomComboInfo("Advanced Mode - AoE", "Replaces Doom Spike with a full one-button AoE rotation.\nThese features are ideal if you want to customize the rotation.", DRG.JobID, 4, "", "")]
        DRG_AOE_AdvancedMode = 6201,

        #region Buffs AoE

        [ParentCombo(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Buffs AoE Option", "Adds Lance Charge and Battle Litany to the rotation.", DRG.JobID, -2, "", "")]
        DRG_AoE_Buffs = 6202,

        [ParentCombo(DRG_AoE_Buffs)]
        [CustomComboInfo("Battle Litany AoE Option", "Adds Battle Litany to the rotation.", DRG.JobID, 36, "", "")]
        DRG_AoE_Litany = 6203,

        [ParentCombo(DRG_AoE_Buffs)]
        [CustomComboInfo("Lance Charge AoE Option", "Adds Lance Charge to the rotation.", DRG.JobID, 36, "", "")]
        DRG_AoE_Lance = 6204,

        [ParentCombo(DRG_AoE_Buffs)]
        [CustomComboInfo("Dragon Sight AoE Option", "Adds Dragon Sight to the rotation.\nOPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID)]
        DRG_AoE_DragonSight = 6205,

        #endregion

        #region CDs AoE

        [ParentCombo(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Cooldowns Option", "Adds various cooldowns to the rotation.", DRG.JobID, -1, "", "")]
        DRG_AoE_CDs = 6206,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Life Surge Option", "Adds Life Surge, while under proper buffs, onto proper GCDs, to the rotation.", DRG.JobID)]
        DRG_AoE_LifeSurge = 6207,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Spineshatter Dive Option", "Adds Spineshatter Dive to the rotation.", DRG.JobID)]
        DRG_AoE_Spineshatter_Dive = 6208,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Dragonfire Dive Option", "Adds Dragonfire Dive to the rotation.", DRG.JobID)]
        DRG_AoE_Dragonfire_Dive = 6209,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Stardiver Option", "Adds Stardiver to the rotation when under at least 1 buff", DRG.JobID, -7, "", "")]
        DRG_AoE_Stardiver = 6210,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("High Jump Option", "Adds High Jump to the rotation.", DRG.JobID)]
        DRG_AoE_HighJump = 6211,

        [ParentCombo(DRG_AoE_HighJump)]
        [CustomComboInfo("Mirage Dive Option", "Adds Mirage Dive to the rotation.", DRG.JobID)]
        DRG_AoE_Mirage = 6212,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Geirskogul and Nastrond Option", "Adds Geirskogul and Nastrond to the rotation.", DRG.JobID)]
        DRG_AoE_GeirskogulNastrond = 6213,

        [ParentCombo(DRG_AoE_CDs)]
        [CustomComboInfo("Wyrmwind Option", "Adds Wyrmwind Thrust to the rotation.", DRG.JobID)]
        DRG_AoE_Wyrmwind = 6214,

        #endregion

        [ParentCombo(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Optimized Rotation Option", "Uses optimzed use of Geirskogul and (High) Jump/Mirage Dive", DRG.JobID)]
        DRG_AoE_Optimized_Rotation = 6215,

        [ParentCombo(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Ranged Uptime Option", "Adds Piercing Talon to the rotation when you are out of melee range.", DRG.JobID, 98, "", "")]
        DRG_AoE_RangedUptime = 6216,

        [ParentCombo(DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the rotation.", DRG.JobID, 99, "", "")]
        DRG_AoE_ComboHeals = 6217,

        #endregion

        [ReplaceSkill(DRG.Jump, DRG.HighJump)]
        [CustomComboInfo("Jump to Mirage Dive", "Replace (High) Jump with Mirage Dive when Dive Ready.", DRG.JobID, 5)]
        DRG_Jump = 6300,

        [ReplaceSkill(DRG.Stardiver)]
        [CustomComboInfo("Stardiver Feature", "Turns Stardiver into Nastrond during Life of the Dragon, and Geirskogul outside of Life of the Dragon.", DRG.JobID, 6, "", "")]
        DRG_StardiverFeature = 6301,

        [ReplaceSkill(DRG.LanceCharge)]
        [CustomComboInfo("Lance Charge to Battle Litany Feature", "Turns Lance Charge into Battle Litany when the former is on cooldown.", DRG.JobID, 7, "", "")]
        DRG_BurstCDFeature = 6302,

        [ParentCombo(DRG_BurstCDFeature)]
        [CustomComboInfo("Dragon Sight Option", "Adds Dragon Sight to Lance Charge, will take precedence over Battle Litany.", DRG.JobID, 8, "", "")]
        DRG_BurstCDFeature_DragonSight = 6303,

        [Variant]
        [VariantParent(DRG_ST_AdvancedMode, DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", DRG.JobID)]
        DRG_Variant_Cure = 6304,

        [Variant]
        [VariantParent(DRG_ST_AdvancedMode, DRG_AOE_AdvancedMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", DRG.JobID)]
        DRG_Variant_Rampart = 6305,


        // Last value = 6117 - 6215 - 6305

        #endregion

        #region GUNBREAKER

        [CustomComboInfo("Skill Speed Support Feature", "Allows for features to support various skill speed rotations.", GNB.JobID, 0)]
        GNB_ST_SkSSupport = 7000,

        #region ST
        [ReplaceSkill(GNB.KeenEdge)]
        [CustomComboInfo("Advanced Gunbreaker Feature", "Replace Keen Edge with its combo chain and uses Burst Strike to prevent ammo overcap.", GNB.JobID)]
        GNB_ST_MainCombo = 7001,

        #region Gnashing Fang
        [ParentCombo(GNB_ST_MainCombo)]
        [CustomComboInfo("Gnashing Fang and Continuation on Main Combo Option", "Adds Gnashing Fang to the main combo. Gnashing Fang must be started manually and the combo will finish it off.", GNB.JobID)]
        GNB_ST_Gnashing = 7002,

        [ParentCombo(GNB_ST_Gnashing)]
        [CustomComboInfo("Gnashing Fang Starter Option", "Begins Gnashing Fang to the main combo.", GNB.JobID)]
        GNB_ST_GnashingFang_Starter = 7003,
        #endregion

        #region Cooldowns
        [ParentCombo(GNB_ST_MainCombo)]
        [CustomComboInfo("Cooldowns on Main Combo Option", "Adds various cooldowns to the main combo when under No Mercy or when No Mercy is on cooldown.", GNB.JobID)]
        GNB_ST_MainCombo_CooldownsGroup = 7004,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Double Down on Main Combo Option", "Adds Double Down to the main combo when under No Mercy buff.", GNB.JobID)]
        GNB_ST_DoubleDown = 7005,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Danger Zone/Blasting Zone on Main Combo Option", "Adds Danger Zone/Blasting Zone to the main combo.", GNB.JobID)]
        GNB_ST_BlastingZone = 7006,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Bloodfest on Main Combo Option", "Adds Bloodfest to the main combo when ammo is 0.", GNB.JobID)]
        GNB_ST_Bloodfest = 7007,

        [ConflictingCombos(GNB_NoMercy_Cooldowns)]
        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("No Mercy on Main Combo Option", "Adds No Mercy to the main combo when at full ammo.", GNB.JobID)]
        GNB_ST_NoMercy = 7008,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Bow Shock on Main Combo Option", "Adds Bow Shock to the main combo.", GNB.JobID)]
        GNB_ST_BowShock = 7009,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Sonic Break on Main Combo Option", "Adds Sonic Break to the main combo.", GNB.JobID)]
        GNB_ST_SonicBreak = 7010,

        [ParentCombo(GNB_ST_MainCombo_CooldownsGroup)]
        [CustomComboInfo("Burst Strike on Main Combo Option", "Adds Burst Strike and Hypervelocity (when available) to the main combo when under No Mercy and Gnashing Fang is over.", GNB.JobID)]
        GNB_ST_BurstStrike = 7011,
        #endregion

        #region Rough Divide
        [ParentCombo(GNB_ST_MainCombo)]
        [CustomComboInfo("Rough Divide Option", "Adds Rough Divide to the main combo whenever it's available.", GNB.JobID)]
        GNB_ST_RoughDivide = 7012,

        [ParentCombo(GNB_ST_RoughDivide)]
        [CustomComboInfo("Melee Rough Divide Option", "Uses Rough Divide when under No Mercy, burst cooldowns when available, not moving, and in the target ring (1 yalm).\nWill use as many stacks as selected in the above slider.", GNB.JobID)]
        GNB_ST_MeleeRoughDivide = 7013,
        #endregion

        [ParentCombo(GNB_ST_MainCombo)]
        [CustomComboInfo("Lightning Shot Uptime Option", "Adds Lightning Shot to the main combo when you are out of range.", GNB.JobID)]
        GNB_ST_RangedUptime = 7014,
        #endregion

        #region Gnashing Fang
        [ReplaceSkill(GNB.GnashingFang)]
        [CustomComboInfo("Gnashing Fang Continuation Combo Feature", "Adds Continuation to Gnashing Fang.", GNB.JobID)]
        GNB_GF_Continuation = 7200,

        [ParentCombo(GNB_GF_Continuation)]
        [CustomComboInfo("No Mercy on Gnashing Fang Option", "Adds No Mercy to Gnashing Fang when it's ready.", GNB.JobID)]
        GNB_GF_NoMercy = 7201,

        [ParentCombo(GNB_GF_Continuation)]
        [CustomComboInfo("Double Down on Gnashing Fang Option", "Adds Double Down to Gnashing Fang when No Mercy buff is up.", GNB.JobID)]
        GNB_GF_DoubleDown = 7202,

        [ParentCombo(GNB_GF_Continuation)]
        [CustomComboInfo("Cooldowns on Gnashing Fang Option", "Adds Bloodfest/Sonic Break/Bow Shock/Blasting Zone on Gnashing Fang, order dependent on No Mercy buff.\nBurst Strike and Hypervelocity added if there's charges while No Mercy buff is up.", GNB.JobID)]
        GNB_GF_Cooldowns = 7203,
        #endregion

        #region AoE
        [ReplaceSkill(GNB.DemonSlice)]
        [CustomComboInfo("Advanced Gunbreaker AoE Feature", "Replace Demon Slice with its combo chain.", GNB.JobID)]
        GNB_AoE_MainCombo = 7300,

        [ConflictingCombos(GNB_NoMercy_Cooldowns)]
        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("No Mercy AoE Option", "Adds No Mercy to the AoE combo when it's available.", GNB.JobID)]
        GNB_AoE_NoMercy = 7301,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Bow Shock on AoE Option", "Adds Bow Shock onto the AoE combo when it's off cooldown.", GNB.JobID)]
        GNB_AoE_BowShock = 7302,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Bloodfest AoE Option", "Adds Bloodfest to the AoE combo when it's available. Will dump Ammo through Fated Circle to prepare for Bloodfest.", GNB.JobID)]
        GNB_AoE_Bloodfest = 7303,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Double Down AoE Option", "Adds Double Down to the AoE combo when it's available and there is 2 or more ammo.", GNB.JobID)]
        GNB_AoE_DoubleDown = 7304,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Danger Zone on AoE Option", "Adds Danger Zone to the AoE combo when it's off cooldown.", GNB.JobID)]
        GNB_AOE_DangerZone = 7305,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Sonic Break on AoE Option", "Adds Sonic Break to the AoE combo when it's off cooldown.", GNB.JobID)]
        GNB_AOE_SonicBreak = 7306,

        [ParentCombo(GNB_AoE_MainCombo)]
        [CustomComboInfo("Ammo Overcap Option", "Adds Fated Circle to the AoE combo when about to overcap.", GNB.JobID)]
        GNB_AOE_Overcap = 7307,
        #endregion

        #region Burst Strike
        [ReplaceSkill(GNB.BurstStrike)]
        [CustomComboInfo("Burst Strike Features", "Collection of Burst Strike related features.", GNB.JobID)]
        GNB_BS = 7400,

        [ParentCombo(GNB_BS)]
        [CustomComboInfo("Burst Strike Continuation Feature", "Adds Hypervelocity on Burst Strike.", GNB.JobID)]
        GNB_BS_Continuation = 7401,

        [ParentCombo(GNB_BS)]
        [CustomComboInfo("Burst Strike to Bloodfest Feature", "Replace Burst Strike with Bloodfest if you have no powder gauge.", GNB.JobID)]
        GNB_BS_Bloodfest = 7402,

        [ParentCombo(GNB_BS)]
        [CustomComboInfo("Double Down on Burst Strike Feature", "Adds Double Down to Burst Strike when under No Mercy and ammo is above 2.", GNB.JobID)]
        GNB_BS_DoubleDown = 7403,
        #endregion

        #region No Mercy
        [ConflictingCombos(GNB_ST_NoMercy, GNB_AoE_NoMercy)]
        [ReplaceSkill(GNB.NoMercy)]
        [CustomComboInfo("Cooldowns on No Mercy Feature", "Adds Cooldowns to No Mercy when No Mercy is on cooldown.", GNB.JobID)]
        GNB_NoMercy_Cooldowns = 7500,

        [ParentCombo(GNB_NoMercy_Cooldowns)]
        [CustomComboInfo("Double Down Option", "Adds Double Down to No Mercy when No Mercy is on cooldown.", GNB.JobID)]
        GNB_NoMercy_Cooldowns_DD = 7501,

        [ParentCombo(GNB_NoMercy_Cooldowns)]
        [CustomComboInfo("Sonic Break/Bow Shock Option", "Adds Sonic Break and Bow Shock to No Mercy when No Mercy is on cooldown.", GNB.JobID)]
        GNB_NoMercy_Cooldowns_SonicBreakBowShock = 7502,
        #endregion

        [CustomComboInfo("Aurora Protection Feature", "Locks out Aurora if Aurora's effect is on the target.", GNB.JobID, 0, "", "")]
        GNB_AuroraProtection = 7600,

        [Variant]
        [VariantParent(GNB_ST_MainCombo, GNB_AoE_MainCombo)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", GNB.JobID)]
        GNB_Variant_SpiritDart = 7033,

        [Variant]
        [VariantParent(GNB_ST_MainCombo, GNB_AoE_MainCombo)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", GNB.JobID)]
        GNB_Variant_Cure = 7034,

        [Variant]
        [VariantParent(GNB_ST_MainCombo, GNB_AoE_MainCombo)]
        [CustomComboInfo("Ultimatum Option", "Use Variant Ultimatum on cooldown.", GNB.JobID)]
        GNB_Variant_Ultimatum = 7035,

        // Last value = 7600

        #endregion

        #region MACHINIST

        #region Simple ST

        [ReplaceSkill(MCH.SplitShot)]
        [ConflictingCombos(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Simple Mode - Single Target", "Replaces Split Shot with a one-button full single target rotation.\nThis is ideal for newcomers to the job.", MCH.JobID)]
        MCH_ST_SimpleMode = 8001,

        #endregion

        #region Advanced ST

        [ReplaceSkill(MCH.SplitShot, MCH.HeatedSplitShot)]
        [ConflictingCombos(MCH_ST_SimpleMode)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replaces Split Shot with a one-button full single target rotation.\nThese features are ideal if you want to customize the rotation.", MCH.JobID)]
        MCH_ST_AdvancedMode = 8100,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [ConflictingCombos(MCH_GaussRoundRicochet, MCH_Heatblast_GaussRound)]
        [CustomComboInfo("Level 100 Opener Option", "Uses the Balance opener.", MCH.JobID)]
        MCH_ST_Adv_Opener = 8101,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Hot Shot / Air Anchor Option", "Adds Hot Shot/Air Anchor to the rotation.", MCH.JobID)]
        MCH_ST_Adv_AirAnchor = 8102,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Reassemble Option", "Adds Reassemble to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Reassemble = 8103,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [ConflictingCombos(MCH_GaussRoundRicochet, MCH_Heatblast_GaussRound)]
        [CustomComboInfo("Gauss Round / Ricochet \nDouble Check / Checkmate option", "Adds Gauss Round and Ricochet or Double Check and Checkmate to the rotation. Will prevent overcapping.", MCH.JobID)]
        MCH_ST_Adv_GaussRicochet = 8104,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Hypercharge Option", "Adds Hypercharge to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Hypercharge = 8105,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Heat Blast / Blazing Shot Option", "Adds Heat Blast or Blazing Shot to the rotation", MCH.JobID)]
        MCH_ST_Adv_Heatblast = 8106,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Rook Autoturret/Automaton Queen Option", "Adds Rook Autoturret or Automaton Queen to the rotation.", MCH.JobID)]
        MCH_Adv_TurretQueen = 8107,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Wildfire Option", "Adds Wildfire to the rotation.", MCH.JobID)]
        MCH_ST_Adv_WildFire = 8108,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Drill Option", "Adds Drill to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Drill = 8109,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Barrel Stabilizer Option", "Adds Barrel Stabilizer to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Stabilizer = 8110,

        [ParentCombo(MCH_ST_Adv_Stabilizer)]
        [CustomComboInfo("Full Metal Field Option", "Adds Full Metal Field to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Stabilizer_FullMetalField = 8111,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Chain Saw Option", "Adds Chain Saw to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Chainsaw = 8112,

        [ParentCombo(MCH_ST_Adv_Chainsaw)]
        [CustomComboInfo("Excavator Option", "Adds Excavator to the rotation.", MCH.JobID)]
        MCH_ST_Adv_Excavator = 8116,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Rook / Queen Overdrive Option", "Adds Rook or Queen Overdrive to the rotation.", MCH.JobID)]
        MCH_ST_Adv_QueenOverdrive = 8115,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Head Graze Option", "Uses Head Graze to interrupt during the rotation, where applicable.", MCH.JobID)]
        MCH_ST_Adv_Interrupt = 8113,

        [ParentCombo(MCH_ST_AdvancedMode)]
        [CustomComboInfo("Second Wind Option", "Use Second Wind when below the set HP percentage.", MCH.JobID)]
        MCH_ST_Adv_SecondWind = 8114,

        #endregion

        #region Simple AoE

        [ReplaceSkill(MCH.SpreadShot)]
        [ConflictingCombos(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Simple Mode - AoE", "Replaces Spread Shot with a one-button full single target rotation.\nThis is ideal for newcomers to the job.", MCH.JobID)]
        MCH_AoE_SimpleMode = 8200,

        #endregion

        #region Advanced AoE

        [ReplaceSkill(MCH.SpreadShot, MCH.Scattergun)]
        [ConflictingCombos(MCH_AoE_SimpleMode)]
        [CustomComboInfo("Advanced Mode - AoE", "Replaces Spread Shot with a one-button full single target rotation.\nThese features are ideal if you want to customize the rotation.", MCH.JobID)]
        MCH_AoE_AdvancedMode = 8300,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Reassemble Option", "Adds Reassemble to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Reassemble = 8301,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [ConflictingCombos(MCH_GaussRoundRicochet, MCH_Heatblast_GaussRound)]
        [CustomComboInfo("Gauss Round / Ricochet \nDouble Check / Checkmate option", "Adds Gauss Round and Ricochet or Double Check and Checkmate to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_GaussRicochet = 8302,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Hypercharge Option", "Adds Hypercharge to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Hypercharge = 8303,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Rook Autoturret/Automaton Queen Option", "Adds Rook Autoturret or Automaton Queen to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Queen = 8304,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Flamethrower Option", "Adds Flamethrower to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_FlameThrower = 8305,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Bioblaster Option", "Adds Bioblaster to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Bioblaster = 8306,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Barrel Stabilizer Option", "Adds Barrel Stabilizer to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Stabilizer = 8307,

        [ParentCombo(MCH_AoE_Adv_Stabilizer)]
        [CustomComboInfo("Full Metal Field Option", "Adds Full Metal Field to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Stabilizer_FullMetalField = 8308,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Chain Saw Option", "Adds Chain Saw to the the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Chainsaw = 8309,

        [ParentCombo(MCH_AoE_Adv_Chainsaw)]
        [CustomComboInfo("Excavator Option", "Adds Excavator to the rotation.", MCH.JobID)]
        MCH_AoE_Adv_Excavator = 8310,

        [ParentCombo(MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Second Wind Option", "Use Second Wind when below the set HP percentage.", MCH.JobID)]
        MCH_AoE_Adv_SecondWind = 8399,

        #endregion

        #region Variant

        [Variant]
        [VariantParent(MCH_ST_AdvancedMode, MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", MCH.JobID)]
        MCH_Variant_Rampart = 8039,

        [Variant]
        [VariantParent(MCH_ST_AdvancedMode, MCH_AoE_AdvancedMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", MCH.JobID)]
        MCH_Variant_Cure = 8040,

        #endregion

        [ReplaceSkill(MCH.RookAutoturret, MCH.AutomatonQueen)]
        [CustomComboInfo("Overdrive Feature", "Replace Rook Autoturret and Automaton Queen with Overdrive while active.", MCH.JobID)]
        MCH_Overdrive = 8002,

        [ReplaceSkill(MCH.GaussRound, MCH.Ricochet)]
        [ConflictingCombos(MCH_ST_Adv_Opener, MCH_ST_Adv_GaussRicochet, MCH_AoE_Adv_GaussRicochet, MCH_Heatblast_GaussRound)]
        [CustomComboInfo("Gauss Round / Ricochet \nDouble Check / Checkmate Feature", "Replace Gauss Round and Ricochet or Double Check and Checkmate with one or the other depending on which has more charges.", MCH.JobID)]
        MCH_GaussRoundRicochet = 8003,

        [ReplaceSkill(MCH.Drill, MCH.AirAnchor, MCH.HotShot)]
        [CustomComboInfo("Drill/Air Anchor (Hot Shot) Feature", "Replace Drill and Air Anchor (Hot Shot) with one or the other (or Chain Saw) depending on which is on cooldown.", MCH.JobID)]
        MCH_HotShotDrillChainsaw = 8004,

        [ReplaceSkill(MCH.Heatblast)]
        [CustomComboInfo("Single Button Heat Blast Feature", "Turns Heat Blast into Hypercharge when at or above 50 heat.", MCH.JobID)]
        MCH_Heatblast = 8006,

        [ParentCombo(MCH_Heatblast)]
        [CustomComboInfo("Barrel Option", "Adds Barrel Stabilizer to the feature when below 50 Heat Gauge.", MCH.JobID)]
        MCH_Heatblast_AutoBarrel = 8052,

        [ParentCombo(MCH_Heatblast)]
        [CustomComboInfo("Wildfire Option", "Adds Wildfire to the feature when at or above 50 heat.", MCH.JobID)]
        MCH_Heatblast_Wildfire = 8015,

        [ParentCombo(MCH_Heatblast)]
        [ConflictingCombos(MCH_ST_Adv_Opener, MCH_ST_Adv_GaussRicochet, MCH_AoE_Adv_GaussRicochet, MCH_GaussRoundRicochet)]
        [CustomComboInfo("Gauss Round / Ricochet \nDouble Check / Checkmate Option", "Switches between Heat Blast and either Gauss Round and Ricochet or Double Check and Checkmate, depending on cooldown timers.", MCH.JobID)]
        MCH_Heatblast_GaussRound = 8016,

        [ReplaceSkill(MCH.AutoCrossbow)]
        [CustomComboInfo("Single Button Auto Crossbow Feature", "Turns Auto Crossbow into Hypercharge when at or above 50 heat.", MCH.JobID)]
        MCH_AutoCrossbow = 8018,

        [ParentCombo(MCH_AutoCrossbow)]
        [CustomComboInfo("Barrel Option", "Adds Barrel Stabilizer to the feature when below 50 Heat Gauge.", MCH.JobID)]
        MCH_AutoCrossbow_AutoBarrel = 8019,

        [ParentCombo(MCH_AutoCrossbow)]
        [CustomComboInfo("Gauss Round / Ricochet\n Double Check / Checkmate Option", "Switches between Auto Crossbow and either Gauss Round and Ricochet or Double Check and Checkmate, depending on cooldown timers.", MCH.JobID)]
        MCH_AutoCrossbow_GaussRound = 8020,

        [ReplaceSkill(MCH.Dismantle)]
        [CustomComboInfo("Physical Ranged DPS: Double Dismantle Protection", "Prevents the use of Dismantle when target already has the effect.", MCH.JobID)]
        All_PRanged_Dismantle = 8042,

        [ReplaceSkill(MCH.Dismantle)]
        [CustomComboInfo("Dismantle - Tactician", "Swap dismantle with tactician when dismantle is on cooldown.", MCH.JobID)]
        MCH_DismantleTactician = 8058,

        // Last value = 8058

        #endregion

        #region MONK

        [ReplaceSkill(MNK.ArmOfTheDestroyer)]
        [CustomComboInfo("Arm of the Destroyer Combo", "Replaces Arm Of The Destroyer with its combo chain.", MNK.JobID)]
        MNK_AoE_SimpleMode = 9000,

        [ReplaceSkill(MNK.DragonKick)]
        [CustomComboInfo("Dragon Kick --> Bootshine Feature", "Replaces Dragon Kick with Bootshine if both a form and Leaden Fist are up.", MNK.JobID)]
        MNK_DragonKick_Bootshine = 9001,

        [ReplaceSkill(MNK.TrueStrike)]
        [CustomComboInfo("Twin Snakes Feature", "Replaces True Strike with Twin Snakes if Disciplined Fist is not applied or is less than 6 seconds from falling off.", MNK.JobID)]
        MNK_TwinSnakes = 9011,

        [ReplaceSkill(MNK.Bootshine)]
        [ConflictingCombos(MNK_ST_SimpleMode)]
        [CustomComboInfo("Basic Rotation", "Basic Monk Combo on one button", MNK.JobID)]
        MNK_BasicCombo = 9002,

        [ReplaceSkill(MNK.PerfectBalance)]
        [CustomComboInfo("Perfect Balance Feature", "Perfect Balance becomes Masterful Blitz while you have 3 Beast Chakra.", MNK.JobID)]
        MNK_PerfectBalance = 9003,

        [ReplaceSkill(MNK.DragonKick)]
        [CustomComboInfo("Bootshine Balance Feature", "Replaces Dragon Kick with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID)]
        MNK_BootshineBalance = 9004,

        [ReplaceSkill(MNK.HowlingFist, MNK.Enlightenment)]
        [CustomComboInfo("Howling Fist/OriginalHook(SteeledMeditation) Feature", "Replaces Howling Fist/Enlightenment with OriginalHook(SteeledMeditation) when the Fifth Chakra is not open.", MNK.JobID)]
        MNK_HowlingFistMeditation = 9005,

        [ReplaceSkill(MNK.Bootshine)]
        [ConflictingCombos(MNK_BasicCombo)]
        [CustomComboInfo("Bootshine Combo", "Replace Bootshine with its combo chain. \nIf all sub options are selected will turn into a full one button rotation (Simple Monk). Slider values can be used to control Disciplined Fist + Demolish uptime.", MNK.JobID, -2, "", "")]
        MNK_ST_SimpleMode = 9006,

        [ReplaceSkill(MNK.MasterfulBlitz)]
        [CustomComboInfo("Perfect Balance Feature Plus", "All of the (optimal?) Blitz combos on Masterful Blitz when Perfect Balance is active", MNK.JobID)]
        MNK_PerfectBalance_Plus = 9007,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("Masterful Blitz on Main Combo", "Adds Masterful Blitz to the main combo", MNK.JobID)]
        MNK_ST_Simple_MasterfulBlitz = 9008,

        [ParentCombo(MNK_AoE_SimpleMode)]
        [CustomComboInfo("Masterful Blitz to AoE Combo", "Adds Masterful Blitz to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_MasterfulBlitz = 9009,

        [ReplaceSkill(MNK.RiddleOfFire)]
        [CustomComboInfo("Riddle of Fire/Brotherhood Feature", "Replaces Riddle of Fire with Brotherhood when Riddle of Fire is on cooldown.", MNK.JobID)]
        MNK_Riddle_Brotherhood = 9012,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("CDs on Main Combo", "Adds various CDs to the main combo when under Riddle of Fire or when Riddle of Fire is on cooldown.", MNK.JobID)]
        MNK_ST_Simple_CDs = 9013,

        [ParentCombo(MNK_ST_Simple_CDs)]
        [CustomComboInfo("Riddle of Wind on Main Combo", "Adds Riddle of Wind to the main combo.", MNK.JobID)]
        MNK_ST_Simple_CDs_RiddleOfWind = 9014,

        [ParentCombo(MNK_ST_Simple_CDs)]
        [CustomComboInfo("Perfect Balance on Main Combo", "Adds Perfect Balance to the main combo.", MNK.JobID)]
        MNK_ST_Simple_CDs_PerfectBalance = 9015,

        [ParentCombo(MNK_ST_Simple_CDs)]
        [CustomComboInfo("Brotherhood on Main Combo", "Adds Brotherhood to the main combo.", MNK.JobID)]
        MNK_ST_Simple_CDs_Brotherhood = 9016,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("OriginalHook(SteeledMeditation) on Main Combo", "Adds OriginalHook(SteeledMeditation) spender to the main combo.", MNK.JobID)]
        MNK_ST_Simple_Meditation = 9017,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("Lunar Solar Opener", "Start with the Lunar Solar Opener on the main combo. Requires level 68 for Riddle of Fire.\nA 1.93/1.94 GCD is highly recommended.", MNK.JobID)]
        MNK_ST_Simple_LunarSolarOpener = 9018,

        [ParentCombo(MNK_AoE_SimpleMode)]
        [CustomComboInfo("CDs on AoE Combo", "Adds various CDs to the AoE combo when under Riddle of Fire or when Riddle of Fire is on cooldown.", MNK.JobID)]
        MNK_AoE_Simple_CDs = 9019,

        [ParentCombo(MNK_AoE_Simple_CDs)]
        [CustomComboInfo("Riddle of Wind on AoE Combo", "Adds Riddle of Wind to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_CDs_RiddleOfWind = 9020,

        [ParentCombo(MNK_AoE_Simple_CDs)]
        [CustomComboInfo("Perfect Balance on AoE Combo", "Adds Perfect Balance to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_CDs_PerfectBalance = 9021,

        [ParentCombo(MNK_AoE_Simple_CDs)]
        [CustomComboInfo("Brotherhood on AoE Combo", "Adds Brotherhood to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_CDs_Brotherhood = 9022,

        [ParentCombo(MNK_AoE_SimpleMode)]
        [CustomComboInfo("OriginalHook(SteeledMeditation) on AoE Combo", "Adds OriginalHook(SteeledMeditation) to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_Meditation = 9023,

        [ParentCombo(MNK_AoE_SimpleMode)]
        [CustomComboInfo("Thunderclap on AoE Combo", "Adds Thunderclap when out of combat to the AoE combo.", MNK.JobID)]
        MNK_AoE_Simple_Thunderclap = 9024,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("Thunderclap on Main Combo", "Adds Thunderclap when out of combat to the main combo.", MNK.JobID)]
        MNK_ST_Simple_Thunderclap = 9025,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo, using them when below the HP Percentage threshold.", MNK.JobID)]
        MNK_ST_ComboHeals = 9026,

        [ParentCombo(MNK_AoE_SimpleMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo, using them when below the HP Percentage threshold.", MNK.JobID)]
        MNK_AoE_ComboHeals = 9027,

        [ParentCombo(MNK_ST_Simple_Meditation)]
        [CustomComboInfo("Mediation Uptime Feature", "Replaces Main Combo with Mediation when you are out of range and out of opener/burst.", MNK.JobID)]
        MNK_ST_Meditation_Uptime = 9028,

        [ParentCombo(MNK_ST_SimpleMode)]
        [CustomComboInfo("Dynamic True North Option", "Adds True North to the main combo right before positionals if you aren't in the correct position for their bonuses.", MNK.JobID)]
        MNK_TrueNorthDynamic = 9029,

        [Variant]
        [VariantParent(MNK_ST_SimpleMode, MNK_AoE_SimpleMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", MNK.JobID)]
        MNK_Variant_Cure = 9030,

        [Variant]
        [VariantParent(MNK_ST_SimpleMode, MNK_AoE_SimpleMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", MNK.JobID)]
        MNK_Variant_Rampart = 9031,

        // Last value = 9031

        #endregion

        #region NINJA

        [ReplaceSkill(NIN.SpinningEdge)]
        [ConflictingCombos(NIN_ArmorCrushCombo, NIN_ST_AdvancedMode, NIN_KassatsuChiJin, NIN_KassatsuTrick)]
        [CustomComboInfo("Simple Mode - Single Target", "Replaces Spinning Edge with a one-button full single target rotation.\nThis is the ideal option for newcomers to the job.", NIN.JobID)]
        NIN_ST_SimpleMode = 10000,

        [ParentCombo(NIN_ST_SimpleMode)]
        [CustomComboInfo("Balance Opener Option", "Starts with the Balance opener.\nDoes pre-pull first, if you enter combat before hiding the opener will fail.\nLikewise, moving during TCJ will cause the opener to fail too.\nRequires you to be out of combat with majority of your cooldowns available for it to work.", NIN.JobID)]
        NIN_ST_SimpleMode_BalanceOpener = 10001,

        [ReplaceSkill(NIN.DeathBlossom)]
        [ConflictingCombos(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Simple Mode - AoE", "Turns Death Blossom into a one-button full AoE rotation.", NIN.JobID)]
        NIN_AoE_SimpleMode = 10002,

        [ReplaceSkill(NIN.SpinningEdge)]
        [ConflictingCombos(NIN_ST_SimpleMode)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replace Spinning Edge with a one-button full single target rotation.\nThese features are ideal if you want to customize the rotation.", NIN.JobID)]
        NIN_ST_AdvancedMode = 10003,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Throwing Dagger Uptime Option", "Adds Throwing Dagger to Advanced Mode if out of melee range.", NIN.JobID)]
        NIN_ST_AdvancedMode_RangedUptime = 10004,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Mug Option", "Adds Mug to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Mug = 10005,

        [ConflictingCombos(NIN_ST_AdvancedMode_Mug_AlignBefore)]
        [ParentCombo(NIN_ST_AdvancedMode_Mug)]
        [CustomComboInfo("Align Mug with Trick Attack Option", "Only uses Mug whilst the target has Trick Attack, otherwise will use on cooldown.", NIN.JobID)]
        NIN_ST_AdvancedMode_Mug_AlignAfter = 10006,

        [ConflictingCombos(NIN_ST_AdvancedMode_Mug_AlignAfter)]
        [ParentCombo(NIN_ST_AdvancedMode_Mug)]
        [CustomComboInfo("Use Mug before Trick Attack Option", "Aligns Mug with Trick Attack but weaves it at least 1 GCD before Trick Attack.", NIN.JobID)]
        NIN_ST_AdvancedMode_Mug_AlignBefore = 10007,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Trick Attack Option", "Adds Trick Attack to Advanced Mode.", NIN.JobID)] //Has Config
        NIN_ST_AdvancedMode_TrickAttack = 10008,

        [ParentCombo(NIN_ST_AdvancedMode_TrickAttack)]
        [CustomComboInfo("Save Cooldowns Before Trick Attack Option", "Stops using abilities with longer cooldowns up to 15 seconds before Trick Attack comes off cooldown.", NIN.JobID)] //HasConfig
        NIN_ST_AdvancedMode_TrickAttack_Cooldowns = 10009,

        [ParentCombo(NIN_ST_AdvancedMode_TrickAttack)]
        [CustomComboInfo("Delayed Trick Attack Option", "Waits at least 8 seconds into combat before using Trick Attack.", NIN.JobID)]
        NIN_ST_AdvancedMode_TrickAttack_Delayed = 10010,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Ninjitsu Option", "Adds Ninjitsu to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus = 10011,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Hold 1 Charge", "Prevent using both charges of Mudra.", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus_ChargeHold = 10012,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Fuma Shuriken", "Spends Mudra charges on Fuma Shuriken (only before Raiton is available).", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus_FumaShuriken = 10013,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Raiton", "Spends Mudra charges on Raiton.", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus_Raiton = 10014,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Suiton", "Spends Mudra charges on Suiton.", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus_Suiton = 10015,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Huton", "Spends Mudra charges on Huton.", NIN.JobID)]
        NIN_ST_AdvancedMode_Ninjitsus_Huton = 10016,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Assassinate/Dream Within a Dream Option", "Adds Assassinate and Dream Within a Dream to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_AssassinateDWAD = 10017,

        [ConflictingCombos(NIN_KassatsuTrick, NIN_KassatsuChiJin)]
        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Kassatsu Option", "Adds Kassatsu to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Kassatsu = 10018,

        [ParentCombo(NIN_ST_AdvancedMode_Kassatsu)]
        [CustomComboInfo($"Use Hyosho Ranryu Option", "Spends Kassatsu on Hyosho Ranryu.", NIN.JobID)]
        NIN_ST_AdvancedMode_Kassatsu_HyoshoRaynryu = 10019,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Armor Crush Option", "Adds Armor Crush to Advanced Mode.", NIN.JobID)] //Has Config
        NIN_ST_AdvancedMode_ArmorCrush = 10020,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Huraijin Option", "Adds Huraijin to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Huraijin = 10021,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Bhavacakra Option", "Adds Bhavacakra to Advanced Mode.", NIN.JobID)] //Has Config
        NIN_ST_AdvancedMode_Bhavacakra = 10022,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Ten Chi Jin Option", "Adds Ten Chi Jin (the cooldown) to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_TCJ = 10023,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Meisui Option", "Adds Meisui to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Meisui = 10024,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Bunshin Option", "Adds Bunshin to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Bunshin = 10025,

        [ParentCombo(NIN_ST_AdvancedMode_Bunshin)]
        [CustomComboInfo("Phantom Kamaitachi Option", "Adds Phantom Kamaitachi to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Bunshin_Phantom = 10026,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Raiju Option", "Adds Fleeting/Forked Raiju to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Raiju = 10027,

        [ParentCombo(NIN_ST_AdvancedMode_Raiju)]
        [CustomComboInfo("Forked Raiju Gap-Closer Option", "Uses Forked Raiju when out of range.", NIN.JobID)]
        NIN_ST_AdvancedMode_Raiju_Forked = 10028,

        [ConflictingCombos(NIN_KassatsuChiJin, NIN_KassatsuTrick)]
        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Balance Opener Option", "Starts with the Balance opener.\nDoes pre-pull first, if you enter combat before hiding the opener will fail.\nLikewise, moving during TCJ will cause the opener to fail too.\nRequires you to be out of combat with majority of your cooldowns available for it to work.", NIN.JobID)]
        NIN_ST_AdvancedMode_BalanceOpener = 10029,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("True North Option", "Adds True North to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_TrueNorth = 10030,

        [ParentCombo(NIN_ST_AdvancedMode_TrueNorth)]
        [CustomComboInfo("Use Before Armor Crush Only Option", "Only triggers the use of True North before Armor Crush.", NIN.JobID)]
        NIN_ST_AdvancedMode_TrueNorth_ArmorCrush = 10031,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Second Wind Option", "Adds Second Wind to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_SecondWind = 10032,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Shade Shift Option", "Adds Shade Shift to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_ShadeShift = 10033,

        [ParentCombo(NIN_ST_AdvancedMode)]
        [CustomComboInfo("Bloodbath Option", "Adds Bloodbath to Advanced Mode.", NIN.JobID)]
        NIN_ST_AdvancedMode_Bloodbath = 10034,

        [ReplaceSkill(NIN.DeathBlossom)]
        [ConflictingCombos(NIN_AoE_SimpleMode)]
        [CustomComboInfo("Advanced Mode - AoE", "Replace Death Blossom with a one-button full AoE rotation.\nThese features are ideal if you want to customize the rotation.", NIN.JobID)]
        NIN_AoE_AdvancedMode = 10035,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Assassinate/Dream Within a Dream Option", "Adds Assassinate/Dream Within a Dream to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_AssassinateDWAD = 10036,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Ninjitsu Option", "Adds Ninjitsu to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Ninjitsus = 10037,

        [ParentCombo(NIN_AoE_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Hold 1 Charge", "Prevent using both charges of Mudra.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Ninjitsus_ChargeHold = 10038,

        [ParentCombo(NIN_AoE_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Katon", "Spends Mudra charges on Katon.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Ninjitsus_Katon = 10039,

        [ParentCombo(NIN_AoE_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Doton", "Spends Mudra charges on Doton.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Ninjitsus_Doton = 10040,

        [ParentCombo(NIN_AoE_AdvancedMode_Ninjitsus)]
        [CustomComboInfo("Use Huton", "Spends Mudra charges on Huton.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Ninjitsus_Huton = 10041,

        [ConflictingCombos(NIN_KassatsuTrick, NIN_KassatsuChiJin)]
        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Kassatsu Option", "Adds Kassatsu to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Kassatsu = 10042,

        [ParentCombo(NIN_AoE_AdvancedMode_Kassatsu)]
        [CustomComboInfo("Goka Mekkyaku Option", "Adds Goka Mekkyaku to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_GokaMekkyaku = 10043,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Huraijin Option", "Adds Huraijin to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Huraijin = 10044,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Hellfrog Medium Option", "Adds Hellfrog Medium to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_HellfrogMedium = 10045,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Ten Chi Jin Option", "Adds Ten Chi Jin (the cooldown) to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_TCJ = 10046,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Meisui Option", "Adds Meisui to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Meisui = 10047,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Bunshin Option", "Adds Bunshin to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Bunshin = 10048,

        [ParentCombo(NIN_AoE_AdvancedMode_Bunshin)]
        [CustomComboInfo("Phantom Kamaitachi Option", "Adds Phantom Kamaitachi to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Bunshin_Phantom = 10049,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Second Wind Option", "Adds Second Wind to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_SecondWind = 10050,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Shade Shift Option", "Adds Shade Shift to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_ShadeShift = 10051,

        [ParentCombo(NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Bloodbath Option", "Adds Bloodbath to Advanced Mode.", NIN.JobID)]
        NIN_AoE_AdvancedMode_Bloodbath = 10052,

        [ReplaceSkill(NIN.ArmorCrush)]
        [ConflictingCombos(NIN_ST_SimpleMode)]
        [CustomComboInfo("Armor Crush Combo Feature", "Replace Armor Crush with its combo chain.", NIN.JobID)]
        NIN_ArmorCrushCombo = 10053,

        [ConflictingCombos(NIN_ST_AdvancedMode_BalanceOpener, NIN_ST_AdvancedMode_BalanceOpener, NIN_ST_AdvancedMode_Kassatsu, NIN_AoE_AdvancedMode_Kassatsu, NIN_KassatsuChiJin)]
        [ReplaceSkill(NIN.Kassatsu)]
        [CustomComboInfo("Kassatsu to Trick Feature", "Replaces Kassatsu with Trick Attack while Suiton or Hidden is up.\nCooldown tracking plugin recommended.", NIN.JobID)]
        NIN_KassatsuTrick = 10054,

        [ReplaceSkill(NIN.TenChiJin)]
        [CustomComboInfo("Ten Chi Jin to Meisui Feature", "Replaces Ten Chi Jin (the move) with Meisui while Suiton is up.\nCooldown tracking plugin recommended.", NIN.JobID)]
        NIN_TCJMeisui = 10055,

        [ConflictingCombos(NIN_ST_AdvancedMode_BalanceOpener, NIN_ST_AdvancedMode_BalanceOpener, NIN_KassatsuTrick, NIN_ST_AdvancedMode_Kassatsu, NIN_AoE_AdvancedMode_Kassatsu)]
        [ReplaceSkill(NIN.Chi)]
        [CustomComboInfo("Kassatsu Chi/Jin Feature", "Replaces Chi with Jin while Kassatsu is up if you have Enhanced Kassatsu.", NIN.JobID)]
        NIN_KassatsuChiJin = 10056,

        [ReplaceSkill(NIN.Hide)]
        [CustomComboInfo("Hide to Mug/Trick Attack Feature", "Replaces Hide with Mug while in combat and Trick Attack whilst Hidden.", NIN.JobID)]
        NIN_HideMug = 10057,

        [ReplaceSkill(NIN.Huraijin)]
        [CustomComboInfo("Huraijin / Raiju Feature", "Replaces Huraijin with Forked and Fleeting Raiju when available.", NIN.JobID)]
        NIN_HuraijinRaiju = 10059,

        [ParentCombo(NIN_HuraijinRaiju)]
        [CustomComboInfo("Huraijin / Raiju Feature Option 1", "Replaces Huraijin with Fleeting Raiju when available.", NIN.JobID)]
        NIN_HuraijinRaiju_Fleeting = 10060,

        [ParentCombo(NIN_HuraijinRaiju)]
        [CustomComboInfo("Huraijin / Raiju Feature Option 2", "Replaces Huraijin with Forked Raiju when available.", NIN.JobID)]
        NIN_HuraijinRaiju_Forked = 10061,

        [ReplaceSkill(NIN.Ten, NIN.Chi, NIN.Jin)]
        [CustomComboInfo("Simple Mudras Feature", "Simplify the mudra casting to avoid failing.", NIN.JobID)]
        NIN_Simple_Mudras = 10062,

        [ReplaceSkill(NIN.TenChiJin)]
        [ParentCombo(NIN_TCJMeisui)]
        [CustomComboInfo("Ten Chi Jin Feature", "Turns Ten Chi Jin (the move) into Ten, Chi, and Jin.", NIN.JobID)]
        NIN_TCJ = 10063,

        [ReplaceSkill(NIN.Huraijin)]
        [CustomComboInfo("Huraijin / Armor Crush Combo Feature", "Replace Huraijin with Armor Crush after using Gust Slash.", NIN.JobID)]
        NIN_HuraijinArmorCrush = 10064,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus_Raiton)]
        [CustomComboInfo("Raiton Uptime Option", "Adds Raiton as an uptime feature.", NIN.JobID)]
        NIN_ST_AdvancedMode_Raiton_Uptime = 10065,

        [ParentCombo(NIN_ST_AdvancedMode_Bunshin_Phantom)]
        [CustomComboInfo("Phantom Kamaitachi Uptime Option", "Adds Phantom Kamaitachi as an uptime feature.", NIN.JobID)]
        NIN_ST_AdvancedMode_Phantom_Uptime = 10066,

        [ParentCombo(NIN_ST_AdvancedMode_Ninjitsus_Suiton)]
        [CustomComboInfo("Suiton Uptime Option", "Adds Suiton as an uptime feature.", NIN.JobID)]
        NIN_ST_AdvancedMode_Suiton_Uptime = 10067,

        [ParentCombo(NIN_ST_AdvancedMode_TrueNorth_ArmorCrush)]
        [CustomComboInfo("Dynamic True North Option", "Adds True North before Armor Crush when you are not in the correct position for the enhanced potency bonus.", NIN.JobID)]
        NIN_ST_AdvancedMode_TrueNorth_ArmorCrush_Dynamic = 10068,

        [Variant]
        [VariantParent(NIN_ST_SimpleMode, NIN_ST_AdvancedMode, NIN_AoE_SimpleMode, NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", NIN.JobID)]
        NIN_Variant_Cure = 10069,

        [Variant]
        [VariantParent(NIN_ST_SimpleMode, NIN_ST_AdvancedMode, NIN_AoE_SimpleMode, NIN_AoE_AdvancedMode)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", NIN.JobID)]
        NIN_Variant_Rampart = 10070,

        // Last value = 10070

        #endregion

        #region PALADIN

        //// Last value = 11032

        [ConflictingCombos(PLD_ST_AdvancedMode)]
        [ReplaceSkill(PLD.FastBlade)]
        [CustomComboInfo("Simple Mode - Single Target", $"Replaces Fast Blade with a one-button full single target rotation.\nThis is ideal for newcomers to the job.", PLD.JobID)]
        PLD_ST_SimpleMode = 11000,

        [ConflictingCombos(PLD_AoE_AdvancedMode)]
        [ReplaceSkill(PLD.TotalEclipse)]
        [CustomComboInfo("Simple Mode - AoE", $"Replaces Total Eclipse with a one-button full AoE rotation.\nThis is ideal for newcomers to the job.", PLD.JobID)]
        PLD_AoE_SimpleMode = 11001,

        [ConflictingCombos(PLD_ST_SimpleMode)]
        [ReplaceSkill(PLD.FastBlade)]
        [CustomComboInfo("Advanced Mode - Single Target", $"Replaces Fast Blade with a one-button full single target rotation.\nThese features are ideal if you want to customize the rotation.", PLD.JobID)]
        PLD_ST_AdvancedMode = 11002,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Fight or Flight Option", "Adds Fight or Flight to Advanced Mode.", PLD.JobID)]
        PLD_ST_AdvancedMode_FoF = 11003,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Shield Lob Option", "Adds Shield Lob to Advanced Mode if out of range.", PLD.JobID)]
        PLD_ST_AdvancedMode_ShieldLob = 11004,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Circle of Scorn Option", "Adds Circle of Scorn to Advanced Mode.", PLD.JobID)]
        PLD_ST_AdvancedMode_CircleOfScorn = 11005,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Spirits Within / Expiacion Option", "Adds Spirits Within / Expiacion to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_SpiritsWithin = 11006,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Sheltron / Holy Sheltron Option", "Adds Sheltron / Holy Sheltron to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Sheltron = 11007,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Goring Blade Option", "Adds Goring Blade to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_GoringBlade = 11008,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Holy Spirit Option", "Adds Holy Spirit to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_HolySpirit = 11009,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Requiescat Option", "Adds Requiescat to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Requiescat = 11010,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Intervene Option", "Adds Intervene to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Intervene = 11011,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Atonement Option", "Adds Atonement to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Atonement = 11012,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Confiteor Option", "Adds Confiteor to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Confiteor = 11013,

        [ParentCombo(PLD_ST_AdvancedMode)]
        [CustomComboInfo("Blades of Faith/Truth/Valor Option", "Adds Blades of Faith/Truth/Valor to Advanced Mode", PLD.JobID)]
        PLD_ST_AdvancedMode_Blades = 11014,

        [ConflictingCombos(PLD_AoE_SimpleMode)]
        [ReplaceSkill(PLD.TotalEclipse)]
        [CustomComboInfo("Advanced Mode - AoE", $"Replaces Total Eclipse with a one-button full AoE rotation.\nThese features are ideal if you want to customize the rotation.", PLD.JobID)]
        PLD_AoE_AdvancedMode = 11015,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Fight or Flight Option", "Adds Fight or Flight to Advanced Mode.", PLD.JobID)]
        PLD_AoE_AdvancedMode_FoF = 11016,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Spirits Within / Expiacion Option", "Adds Spirits Within / Expiacion to Advanced Mode", PLD.JobID)]
        PLD_AoE_AdvancedMode_SpiritsWithin = 11017,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Circle of Scorn Option", "Adds Circle of Scorn to Advanced Mode.", PLD.JobID)]
        PLD_AoE_AdvancedMode_CircleOfScorn = 11018,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Requiescat Option", "Adds Requiescat to Advanced Mode.", PLD.JobID)]
        PLD_AoE_AdvancedMode_Requiescat = 11019,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Holy Circle Option", "Adds Holy Circle to Advanced Mode.", PLD.JobID)]
        PLD_AoE_AdvancedMode_HolyCircle = 11020,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Confiteor Option", "Adds Confiteor to Advanced Mode", PLD.JobID)]
        PLD_AoE_AdvancedMode_Confiteor = 11021,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Blades of Faith/Truth/Valor Option", "Adds Blades of Faith/Truth/Valor to Advanced Mode", PLD.JobID)]
        PLD_AoE_AdvancedMode_Blades = 11022,

        [ParentCombo(PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Sheltron / Holy Sheltron Option", "Adds Sheltron / Holy Sheltron to Advanced Mode", PLD.JobID)]
        PLD_AoE_AdvancedMode_Sheltron = 11023,


        [ReplaceSkill(PLD.Requiescat)]
        [CustomComboInfo("Requiescat Spender Option", "Replaces Requiescat with the selected option while having stacks of \"Requiescat\"", PLD.JobID)]
        PLD_Requiescat_Options = 11024,

        [ReplaceSkill(PLD.SpiritsWithin, PLD.Expiacion)]
        [CustomComboInfo("Spirits Within / Expiacion / Circle of Scorn Feature", "Replaces Spirits Within / Expiacion with Circle of Scorn when off cooldown.", PLD.JobID)]
        PLD_SpiritsWithin = 11025,

        [Variant]
        [VariantParent(PLD_ST_SimpleMode, PLD_ST_AdvancedMode, PLD_AoE_SimpleMode, PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", PLD.JobID)]
        PLD_Variant_SpiritDart = 11030,

        [Variant]
        [VariantParent(PLD_ST_SimpleMode, PLD_ST_AdvancedMode, PLD_AoE_SimpleMode, PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", PLD.JobID)]
        PLD_Variant_Cure = 11031,

        [Variant]
        [VariantParent(PLD_ST_SimpleMode, PLD_ST_AdvancedMode, PLD_AoE_SimpleMode, PLD_AoE_AdvancedMode)]
        [CustomComboInfo("Ultimatum Option", "Use Variant Ultimatum on cooldown.", PLD.JobID)]
        PLD_Variant_Ultimatum = 11032,

        //// Last value = 11032

        #endregion

        #region REAPER

        #region Single Target (Slice) Combo Section
        [ReplaceSkill(RPR.Slice, RPR.Harpe)]
        [CustomComboInfo("Slice Combo Feature", "Replace Slice with its combo chain.\nIf all sub options are toggled will turn into a full one button rotation (Advanced Reaper)", RPR.JobID)]
        RPR_ST_SliceCombo = 12001,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Positional Preference", "Choose positional order for all positional related features.\nSupports turning Slice/Shadow of Death into all positionals or Slice and Shadow of Death being two separate positionals.", RPR.JobID)]
        ReaperPositionalConfigST = 12000,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Soul Slice Option", "Adds Soul Slice to Slice Combo when Soul Gauge is 50 or less and when current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_ST_SliceCombo_SoulSlice = 12002,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Shadow Of Death Option", "Adds Shadow of Death to Slice Combo if Death's Design is not present on current target, or is about to expire.", RPR.JobID)]
        RPR_ST_SliceCombo_SoD = 12003,

        [ParentCombo(RPR_ST_SliceCombo_SoD)]
        [CustomComboInfo("Double SoD Enshroud Option", "Uses Shadow of Death twice during the first of the two Enshroud Bursts during the 2-minute windows (Double Enshroud Burst).", RPR.JobID)]
        RPR_ST_SliceCombo_SoD_Double = 12004,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Stun Option", "Adds Leg Sweep to main combo when target is performing an interruptible cast.", RPR.JobID)]
        RPR_ST_SliceCombo_Stun = 12005,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo at 65%% and 40%% HP, respectively.", RPR.JobID)]
        RPR_ST_SliceCombo_ComboHeals = 12006,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Ranged Filler Option", "Replaces the combo chain with Harpe (or Harvest Moon, if available) when outside of melee range. Will not override Communio.", RPR.JobID)]
        RPR_ST_SliceCombo_RangedFiller = 12007,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Enshroud Option", "Adds Enshroud to the combo when at 50 Shroud or greater and when current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_ST_SliceCombo_Enshroud = 12008,

        [ParentCombo(RPR_ST_SliceCombo_Enshroud)]
        [CustomComboInfo("Enshroud Burst (Double Enshroud) Option", "Uses Enshroud at 50 Shroud during Arcane Circle (mimics the 2-minute Double Enshroud window) and will use Enshroud for odd minute bursts.\nBelow level 88, will use Enshroud at 50 gauge.", RPR.JobID)]
        RPR_ST_SliceCombo_EnshroudPooling = 12009,

        [ParentCombo(RPR_ST_SliceCombo_GibbetGallows)]
        [CustomComboInfo("Lemure's Slice Option", "Adds Lemure's Slice to the combo when there are 2 Void Shroud charges.", RPR.JobID, 1, "", "")]
        RPR_ST_SliceCombo_GibbetGallows_Lemure = 12010,

        [ParentCombo(RPR_ST_SliceCombo_GibbetGallows)]
        [CustomComboInfo("Communio Finisher Option", "Adds Communio to the combo when there is 1 charge of Lemure Shroud left.", RPR.JobID, 1, "", "")]
        RPR_ST_SliceCombo_GibbetGallows_Communio = 12011,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Arcane Circle Option", "Adds Arcane Circle to the combo when available and when current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_ST_SliceCombo_ArcaneCircle = 12012,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Plentiful Harvest Option", "Adds Plentiful Harvest to the combo when available.", RPR.JobID)]
        RPR_ST_SliceCombo_PlentifulHarvest = 12013,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Gibbet and Gallows Option", "Adds Gibbet and Gallows to the combo when current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_ST_SliceCombo_GibbetGallows = 12014,

        [ParentCombo(RPR_ST_SliceCombo_GibbetGallows)]
        [CustomComboInfo("Void/Cross Reaping Option", "Adds Void Reaping and Cross Reaping to the to the the combo during Enshroud.\n(Disabling this may stop the one-button combo working during enshroud)", RPR.JobID)]
        RPR_ST_SliceCombo_GibbetGallows_VoidCross = 12065,

        [ReplaceSkill(RPR.ShadowOfDeath)]
        [ParentCombo(RPR_ST_SliceCombo_GibbetGallows)]
        [CustomComboInfo("Gibbet and Gallows on SoD Option", "Adds Gibbet and Gallows to Shadow of Death as well if chosen in positional preferences.", RPR.JobID)]
        RPR_ST_SliceCombo_GibbetGallows_OnSoD = 12015,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Gluttony and Blood Stalk Option", "Adds Gluttony and Blood Stalk to the combo when target is afflicted with Death's Design, and the skills are off cooldown and < 50 soul.", RPR.JobID)]
        RPR_ST_SliceCombo_GluttonyBloodStalk = 12016,

        [ParentCombo(RPR_ST_SliceCombo_GibbetGallows_Communio)]
        [CustomComboInfo("Communio Movement Option", "Uses Shadow of Death instead of Communio when moving.", RPR.JobID)]
        RPR_ST_SliceCombo_GibbetGallows_Communio_Movement = 12017,

        [ParentCombo(RPR_ST_SliceCombo)]
        [CustomComboInfo("Level 90 Opener Option", "Adds the Level 90 Opener to the main combo. Choose which Opener to use below.", RPR.JobID, -1, "", "")]
        RPR_ST_SliceCombo_Opener = 12018,
        #endregion

        #region AoE (Scythe) Combo Section
        [ReplaceSkill(RPR.SpinningScythe)]
        [CustomComboInfo("Scythe Combo Feature", "Replace Spinning Scythe with its combo chain.\nIf all sub options are toggled will turn into a full one button rotation (Simple AoE)", RPR.JobID)]
        RPR_AoE_ScytheCombo = 12020,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Positional Preference", "Choose positional order for all positional related features.\nSupports turning Slice/Shadow of Death into all positionals or Slice and Shadow of Death being two separate positionals.", RPR.JobID)]
        ReaperPositionalConfigAoE = 12030,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Soul Scythe Option", "Adds Soul Scythe to AoE combo when Soul Gauge is 50 or less and current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_AoE_ScytheCombo_SoulScythe = 12021,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Whorl Of Death Option", "Adds Whorl of Death to AoE combo if Death's Design is not present on current target, or is about to expire.", RPR.JobID)]
        RPR_AoE_ScytheCombo_WoD = 12022,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Guillotine Option", "Adds Guillotine to AoE combo when under Soul Reaver and when current target is afflicted with Death's Design.\nWill use Grim Reaping during Enshroud.", RPR.JobID)]
        RPR_AoE_ScytheCombo_Guillotine = 12023,

        [ParentCombo(RPR_AoE_ScytheCombo_Guillotine)]
        [CustomComboInfo("Grim Reaping Option", "Adds Grim Reaping to the to the AoE combo during Enshroud.", RPR.JobID)]
        RPR_AoE_ScytheCombo_Guillotine_GrimReaping = 12066,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Arcane Circle Option", "Adds Arcane Circle to AoE combo when off cooldown.", RPR.JobID)]
        RPR_AoE_ScytheCombo_ArcaneCircle = 12024,

        [ParentCombo(RPR_AoE_ScytheCombo_ArcaneCircle)]
        [CustomComboInfo("Plentiful Harvest Option", "Adds Plentiful Harvest to AoE combo when off cooldown and ready.", RPR.JobID)]
        RPR_AoE_ScytheCombo_PlentifulHarvest = 12025,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Enshroud Option", "Adds Enshroud to the AoE combo when at 50 Shroud and greater and when current target is afflicted with Death's Design.", RPR.JobID)]
        RPR_AoE_ScytheCombo_Enshroud = 12026,

        [ParentCombo(RPR_AoE_ScytheCombo_Guillotine)]
        [CustomComboInfo("Lemure's Scythe Option", "Adds Lemure's Scythe to the AoE combo when there are 2 Void Shrouds.", RPR.JobID, 1, "", "")]
        RPR_AoE_ScytheCombo_Lemure = 12027,

        [ParentCombo(RPR_AoE_ScytheCombo_Guillotine)]
        [CustomComboInfo("Communio Finisher Option", "Adds Communio to the AoE combo when there is 1 Lemure Shroud left.", RPR.JobID, 2, "", "")]
        RPR_AoE_ScytheCombo_Communio = 12028,

        [ParentCombo(RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Gluttony and Grim Swathe Option", "Adds Gluttony and Grim Swathe to the AoE combo when current target is afflicted with Death's Design and Soul Gauge < 50.", RPR.JobID)]
        RPR_AoE_ScytheCombo_GluttonyGrimSwathe = 12029,
        #endregion

        #region Blood Stalk/Grim Swathe Combo Section
        [ReplaceSkill(RPR.BloodStalk, RPR.GrimSwathe)]
        [CustomComboInfo("Gluttony on Blood Stalk/Grim Swathe Feature", "Blood Stalk and Grim Swathe will turn into Gluttony when it is available.", RPR.JobID)]
        RPR_GluttonyBloodSwathe = 12041,

        [ParentCombo(RPR_GluttonyBloodSwathe)]
        [CustomComboInfo("Gibbet and Gallows/Guillotine on Blood Stalk/Grim Swathe Feature", "Adds Gibbet and Gallows on Blood Stalk.\nAdds Guillotine on Grim Swathe.", RPR.JobID)]
        RPR_GluttonyBloodSwathe_BloodSwatheCombo = 12040,

        [ParentCombo(RPR_GluttonyBloodSwathe)]
        [CustomComboInfo("Enshroud Combo Option", "Adds Enshroud combo (Void/Cross Reaping, Communio, and Lemure's Slice) on Blood Stalk and Grim Swathe.", RPR.JobID)]
        RPR_GluttonyBloodSwathe_Enshroud = 12042,
        #endregion

        #region Miscellaneous
        [ReplaceSkill(RPR.ArcaneCircle)]
        [CustomComboInfo("Arcane Circle Harvest Feature", "Replaces Arcane Circle with Plentiful Harvest when you have stacks of Immortal Sacrifice.", RPR.JobID)]
        RPR_ArcaneCirclePlentifulHarvest = 12051,

        [ReplaceSkill(RPR.HellsEgress, RPR.HellsIngress)]
        [CustomComboInfo("Regress Feature", "Changes both Hell's Ingress and Hell's Egress turn into Regress when Threshold is active.", RPR.JobID)]
        RPR_Regress = 12052,

        [ReplaceSkill(RPR.Slice, RPR.SpinningScythe, RPR.ShadowOfDeath, RPR.Harpe, RPR.BloodStalk)]
        [CustomComboInfo("Soulsow Reminder Feature", "Adds Soulsow to the skills selected below when out of combat. \nWill also add Soulsow to Harpe when in combat and no target is selected.", RPR.JobID)]
        RPR_Soulsow = 12053,

        [ReplaceSkill(RPR.Harpe)]
        [ParentCombo(RPR_Soulsow)]
        [CustomComboInfo("Harpe Harvest Moon Feature", "Replaces Harpe with Harvest Moon when you are in combat with Soulsow active.", RPR.JobID)]
        RPR_Soulsow_HarpeHarvestMoon = 12054,

        [ReplaceSkill(RPR.Harpe, RPR.Slice)]
        [ParentCombo(RPR_Soulsow)]
        [CustomComboInfo("Enhanced Harpe Option", "Prevent Harvest Moon replacing Harpe when Enhanced Harpe is active.", RPR.JobID)]
        RPR_Soulsow_HarpeHarvestMoon_EnhancedHarpe = 12055,

        [ReplaceSkill(RPR.Harpe, RPR.Slice)]
        [ParentCombo(RPR_Soulsow)]
        [CustomComboInfo("Combat Harpe Option", "Prevent Harvest Moon replacing Harpe when you are not in combat.", RPR.JobID)]
        RPR_Soulsow_HarpeHarvestMoon_CombatHarpe = 12056,

        [ReplaceSkill(RPR.Enshroud)]
        [CustomComboInfo("Enshroud Protection Feature", "Turns Enshroud into Gibbet/Gallows to protect Soul Reaver waste.", RPR.JobID)]
        RPR_EnshroudProtection = 12057,

        [ParentCombo(RPR_EnshroudProtection)]
        [CustomComboInfo("Positional Preference", "Choose positional order for all positional related features.\nSupports turning Slice/Shadow of Death into all positionals or Slice and Shadow of Death being two separate positionals.", RPR.JobID)]
        RPR_EnshroudProtection_Positional = 12059,

        [ReplaceSkill(RPR.Gibbet, RPR.Gallows, RPR.Guillotine)]
        [CustomComboInfo("Communio on Gibbet/Gallows and Guillotine Feature", "Adds Communio to Gibbet/Gallows and Guillotine.", RPR.JobID)]
        RPR_CommunioOnGGG = 12058,

        [ParentCombo(RPR_CommunioOnGGG)]
        [CustomComboInfo("Lemure's Slice/Scythe Option", "Adds Lemure's Slice to Gibbet/Gallows and Lemure's Scythe to Guillotine.", RPR.JobID)]
        RPR_LemureOnGGG = 12060,

        [ReplaceSkill(RPR.Enshroud)]
        [CustomComboInfo("Enshroud to Communio Feature", "Turns Enshroud to Communio when available to use.", RPR.JobID)]
        RPR_EnshroudCommunio = 12069,

        [ReplaceSkill(RPR.Slice, RPR.ShadowOfDeath, RPR.Enshroud)]
        [CustomComboInfo("True North Feature", "Adds True North to Slice, Shadow of Death, Enshroud, and Blood Stalk when under Gluttony and if Gibbet/Gallows options are selected to replace those skills.", RPR.JobID, 0)]
        RPR_TrueNorth = 12061,

        [ReplaceSkill(RPR.Harpe)]
        [ParentCombo(RPR_Soulsow)]
        [CustomComboInfo("Soulsow Reminder during Combat", "Adds Soulsow to Harpe during combat when no target is selected.", RPR.JobID)]
        RPR_Soulsow_Combat = 12062,

        [ReplaceSkill(RPR.Gibbet, RPR.Gallows)]
        [CustomComboInfo("Dynamic True North Feature", "Adds True North to Slice before Gibbet/Gallows when you are not in the correct position for the enhanced potency bonus.", RPR.JobID)]
        RPR_TrueNorthDynamic = 12063,

        [ParentCombo(RPR_TrueNorthDynamic)]
        [CustomComboInfo("Hold True North for Gluttony Option", "Will hold the last charge of True North for use with Gluttony, even when out of position for Gibbet/Gallows potency bonuses.", RPR.JobID)]
        RPR_TrueNorthDynamic_HoldCharge = 12064,

        [Variant]
        [VariantParent(RPR_ST_SliceCombo, RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", RPR.JobID)]
        RPR_Variant_Cure = 12067,

        [Variant]
        [VariantParent(RPR_ST_SliceCombo, RPR_AoE_ScytheCombo)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", RPR.JobID)]
        RPR_Variant_Rampart = 12068,
        #endregion

        // Last value = 12069

        #endregion

        #region RED MAGE

        /* RDM Feature Numbering
        Numbering Scheme: 13[Section][Feature Number][Sub-Feature]
        Example: 13110 (Section 1: Openers, Feature Number 1, Sub-feature 0)
        New features should be added to the appropriate sections.
        If more than 10 sub features, use the next feature number if available
        The three digets after RDM.JobID can be used to reorder items in the list
        */
        #region Single Target DPS
        [ReplaceSkill(RDM.Jolt, RDM.Jolt2)]
        [CustomComboInfo("Single Target DPS Features", "Enables various Single Target options below.", RDM.JobID, 1)]
        RDM_ST_DPS = 13000,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Balance Opener Option [Lv.90]", "Replaces Jolt with the Balance opener ending with Resolution.\n**Must move into melee range before melee combo**", RDM.JobID, 110)]
        RDM_Balance_Opener = 13110,

        [ParentCombo(RDM_Balance_Opener)]
        [CustomComboInfo("Use Opener at any Mana Option", "Removes 0/0 Mana reqirement to reset opener\n**All other actions must be off cooldown**", RDM.JobID, 111)]
        RDM_Balance_Opener_AnyMana = 13111,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Verthunder/Veraero Option", "Replace Jolt with Verthunder and Veraero.", RDM.JobID, 210)]
        RDM_ST_ThunderAero = 13210,

        [ParentCombo(RDM_ST_ThunderAero)]
        [CustomComboInfo("Acceleration Option", "Add Acceleration when no Verfire/Verstone proc is available.", RDM.JobID, 211)]
        RDM_ST_ThunderAero_Accel = 13211,

        [ParentCombo(RDM_ST_ThunderAero_Accel)]
        [CustomComboInfo("Include Swiftcast Option", "Add Swiftcast when all Acceleration charges are used.", RDM.JobID, 212)]
        RDM_ST_ThunderAero_Accel_Swiftcast = 13212,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Verfire/Verstone Option", "Replace Jolt with Verfire and Verstone.", RDM.JobID, 220)]
        RDM_ST_FireStone = 13220,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Weave oGCD Damage Option", "Weave the following oGCD actions.", RDM.JobID, 240)]
        RDM_ST_oGCD = 13240,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Single Target Melee Combo Option", "Add the Reposte combo.\n**Must be in melee range or have Gap close with Corps-a-corps enabled**", RDM.JobID, 410)]
        RDM_ST_MeleeCombo = 13410,

        [ParentCombo(RDM_ST_MeleeCombo)]
        [CustomComboInfo("Use Manafication and Embolden Option", "Add Manafication and Embolden.\n**Must be in melee range or have Gap close with Corps-a-corps enabled**", RDM.JobID, 411)]
        RDM_ST_MeleeCombo_ManaEmbolden = 13411,

        [ParentCombo(RDM_ST_MeleeCombo_ManaEmbolden)]
        [CustomComboInfo("Hold for Double Melee Combo Option [Lv.90]", "Hold both actions until you can perform a double melee combo.", RDM.JobID, 412)]
        RDM_ST_MeleeCombo_ManaEmbolden_DoubleCombo = 13412,

        [ParentCombo(RDM_ST_MeleeCombo)]
        [CustomComboInfo("Gap close with Corps-a-corps Option", "Use Corp-a-corps when out of melee range and you have enough mana to start the melee combo.", RDM.JobID, 430)]
        RDM_ST_MeleeCombo_CorpsGapCloser = 13430,

        [ParentCombo(RDM_ST_MeleeCombo)]
        [CustomComboInfo("Unbalance Mana Option", "Use Acceleration to unbalance mana prior to starting melee combo.", RDM.JobID, 410)]
        RDM_ST_MeleeCombo_UnbalanceMana = 13440,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Melee Finisher Option", "Add Verflare/Verholy and other finishing moves.", RDM.JobID, 510)]
        RDM_ST_MeleeFinisher = 13510,

        [ParentCombo(RDM_ST_DPS)]
        [CustomComboInfo("Lucid Dreaming Option", "Weaves Lucid Dreaming when your MP drops below the specified value.", RDM.JobID, 610)]
        RDM_ST_Lucid = 13610,
        #endregion

        #region AoE DPS
        [ReplaceSkill(RDM.Scatter, RDM.Impact)]
        [CustomComboInfo("AoE DPS Feature", "Enables various AoE Target options below.", RDM.JobID, 310)]
        RDM_AoE_DPS = 13310,

        [ParentCombo(RDM_AoE_DPS)]
        [ReplaceSkill(RDM.Scatter, RDM.Impact)]
        [CustomComboInfo("AoE Acceleration Option", "Use Acceleration for increased damage.", RDM.JobID, 320)]
        RDM_AoE_Accel = 13320,

        [ParentCombo(RDM_AoE_Accel)]
        [CustomComboInfo("Include Swiftcast Option", "Add Swiftcast when all Acceleration charges are used or when below level 50.", RDM.JobID, 321)]
        RDM_AoE_Accel_Swiftcast = 13321,

        [ParentCombo(RDM_AoE_Accel)]
        [CustomComboInfo("Weave Acceleration Option", "Only use acceleration during weave windows.", RDM.JobID, 322)]
        RDM_AoE_Accel_Weave = 13322,

        [ParentCombo(RDM_AoE_DPS)]
        [CustomComboInfo("Weave oGCD Damage Option", "Weave the following oGCD actions:", RDM.JobID, 240)]
        RDM_AoE_oGCD = 13241,

        [ParentCombo(RDM_AoE_DPS)]
        [CustomComboInfo("Moulinet Melee Combo Option", "Use Moulinet when over 60/60 mana", RDM.JobID, 420)]
        RDM_AoE_MeleeCombo = 13420,

        [ParentCombo(RDM_AoE_MeleeCombo)]
        [CustomComboInfo("Use Manafication and Embolden Option", "Add Manafication and Embolden.\n**Must be in range of Moulinet**", RDM.JobID, 411)]
        RDM_AoE_MeleeCombo_ManaEmbolden = 13421,

        [ParentCombo(RDM_AoE_MeleeCombo)]
        [CustomComboInfo("Gap close with Corps-a-corps Option", "Use Corp-a-corps when out of melee range and you have enough mana to start the melee combo.", RDM.JobID, 430)]
        RDM_AoE_MeleeCombo_CorpsGapCloser = 13422,

        //[ParentCombo(RDM_AoE_MeleeCombo)]
        //[CustomComboInfo("Unbalance Mana Option", "Use Acceleration to unbalance mana prior to starting melee combo", RDM.JobID, 410)]
        //RDM_AoE_MeleeCombo_UnbalanceMana = 13423,

        [ParentCombo(RDM_AoE_DPS)]
        [CustomComboInfo("Melee Finisher Option", "Add Verflare/Verholy and other finishing moves.", RDM.JobID, 510)]
        RDM_AoE_MeleeFinisher = 13424,

        [ParentCombo(RDM_AoE_DPS)]
        [CustomComboInfo("Lucid Dreaming Option", "Weaves Lucid Dreaming when your MP drops below the specified value.", RDM.JobID, 610)]
        RDM_AoE_Lucid = 13425,
        #endregion

        #region QoL
        [ReplaceSkill(All.Swiftcast)]
        [ConflictingCombos(ALL_Caster_Raise)]
        [CustomComboInfo("Verraise Feature", "Changes Swiftcast to Verraise when under the effect of Swiftcast or Dualcast.", RDM.JobID, 620)]
        RDM_Raise = 13620,
        #endregion

        #region Sections 8 to 9 - Miscellaneous
        [ReplaceSkill(RDM.Displacement)]
        [CustomComboInfo("Displacement <> Corps-a-corps Feature", "Replace Displacement with Corps-a-corps when out of range.", RDM.JobID, 810)]
        RDM_CorpsDisplacement = 13810,

        [ReplaceSkill(RDM.Embolden)]
        [CustomComboInfo("Embolden to Manafication Feature", "Changes Embolden to Manafication when on cooldown.", RDM.JobID, 820)]
        RDM_EmboldenManafication = 13820,

        [ReplaceSkill(RDM.MagickBarrier)]
        [CustomComboInfo("Magick Barrier to Addle Feature", "Changes Magick Barrier to Addle when on cooldown.", RDM.JobID, 820)]
        RDM_MagickBarrierAddle = 13821,

        [Variant]
        [VariantParent(RDM_ST_DPS, RDM_AoE_DPS)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown. Replaces Jolts.", RDM.JobID)]
        RDM_Variant_Rampart = 13830,

        [Variant]
        [VariantParent(RDM_Raise)]
        [CustomComboInfo("Raise Option", "Turn Swiftcast into Variant Raise whenever you have the Swiftcast or Dualcast buffs.", RDM.JobID)]
        RDM_Variant_Raise = 13831,

        [Variant]
        [VariantParent(RDM_ST_DPS, RDM_AoE_DPS)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold. Replaces Jolts.", RDM.JobID)]
        RDM_Variant_Cure = 13832,

        [Variant]
        [CustomComboInfo("Cure on Vercure Option", "Replaces Vercure with Variant Cure.", RDM.JobID)]
        RDM_Variant_Cure2 = 13833,
        #endregion

        #endregion

        #region SAGE

        /* SGE Feature Numbering
        Numbering Scheme: 14[Feature][Option][Sub-Option]
        Example: 14110 (Feature Number 1, Option 1, no suboption)
        New features should be added to the appropriate sections.
        */

        #region Single Target DPS Feature
        [ReplaceSkill(SGE.Dosis, SGE.Dosis2, SGE.Dosis3)]
        [CustomComboInfo("Single Target DPS Feature", "Adds various options to Dosis I/II/III.", SGE.JobID, 100, "", "")]
        SGE_ST_DPS = 14100,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Lucid Dreaming Option", "Weaves Lucid Dreaming when your MP drops below the specified value.", SGE.JobID, 120, "", "")]
        SGE_ST_DPS_Lucid = 14110,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Eukrasian Dosis Option", "Automatic DoT Uptime.", SGE.JobID, 110, "", "")]
        SGE_ST_DPS_EDosis = 14120,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Movement Options", "Use selected instant cast actions while moving.", SGE.JobID, 112, "", "")]
        SGE_ST_DPS_Movement = 14130,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Phlegma Option", "Use Phlegma if available and within range.", SGE.JobID, 111, "", "")]
        SGE_ST_DPS_Phlegma = 14140,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Kardia Reminder Option", "Adds Kardia when not under the effect.", SGE.JobID, 122, "", "")]
        SGE_ST_DPS_Kardia = 14150,

        [ParentCombo(SGE_ST_DPS)]
        [CustomComboInfo("Rhizomata Option", "Weaves Rhizomata when Addersgall gauge falls below the specified value.", SGE.JobID, 121, "", "")]
        SGE_ST_DPS_Rhizo = 14160,
        #endregion

        #region AoE DPS Feature
        [ReplaceSkill(SGE.Phlegma, SGE.Phlegma2, SGE.Phlegma3)]
        [CustomComboInfo("AoE DPS Feature", "", SGE.JobID, 200, "", "")]
        SGE_AoE_DPS = 14200,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Toxikon - No Phlegma Charges Option", "Use Toxikon when out of Phlegma charges.\nTakes priority over Dyskrasia.", SGE.JobID, 210, "", "")]
        SGE_AoE_DPS_NoPhlegmaToxikon = 14210,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Toxikon - Out of Phlegma Range Option", "Use Toxikon when out of Phlemga's Range.\nTakes priority over Dyskrasia.", SGE.JobID, 220, "", "")]
        SGE_AoE_DPS_OutOfRangeToxikon = 14220,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Dyskrasia - No Phlegma Charges Option", "Use Dyskrasia when out of Phlegma charges.", SGE.JobID, 230, "", "")]
        SGE_AoE_DPS_NoPhlegmaDyskrasia = 14230,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Dyskrasia - No-Target Option", "Use Dyskrasia when no target is selected.", SGE.JobID, 240, "", "")]
        SGE_AoE_DPS_NoTargetDyskrasia = 14240,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Lucid Dreaming Option", "Weaves Lucid Dreaming when your MP falls below the specified value.", SGE.JobID, 250, "", "")]
        SGE_AoE_DPS_Lucid = 14250,

        [ParentCombo(SGE_AoE_DPS)]
        [CustomComboInfo("Rhizomata Option", "Weaves Rhizomata when Addersgall gauge falls below the specified value.", SGE.JobID, 121, "", "")]
        SGE_AoE_DPS_Rhizo = 14260,
        #endregion

        #region Diagnosis Simple Single Target Heal
        [ReplaceSkill(SGE.Diagnosis)]
        [CustomComboInfo("Single Target Heal Feature", "Supports soft-targeting.\nOptions below are in priority order.", SGE.JobID, 300, "", "")]
        SGE_ST_Heal = 14300,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Esuna Option", "Applies Esuna to your target if there is a cleansable debuff.", SGE.JobID, 11, "", "")]
        SGE_ST_Heal_Esuna = 14301,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Apply Kardia Option", "Applies Kardia to your target if it's not applied to anyone else.", SGE.JobID, 1, "", "")]
        SGE_ST_Heal_Kardia = 14310,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Eukrasian Diagnosis Option", "Diagnosis becomes Eukrasian Diagnosis if the shield is not applied to the target.", SGE.JobID, 2, "", "")]
        SGE_ST_Heal_EDiagnosis = 14320,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Soteria Option", "Applies Soteria.", SGE.JobID, 3, "", "")]
        SGE_ST_Heal_Soteria = 14330,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Zoe Option", "Applies Zoe.", SGE.JobID, 4, "", "")]
        SGE_ST_Heal_Zoe = 14340,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Pepsis Option", "Triggers Pepsis if a shield is present.", SGE.JobID, 5, "", "")]
        SGE_ST_Heal_Pepsis = 14350,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Taurochole Option", "Adds Taurochole.", SGE.JobID, 6, "", "")]
        SGE_ST_Heal_Taurochole = 14360,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Haima Option", "Applies Haima.", SGE.JobID, 7, "", "")]
        SGE_ST_Heal_Haima = 14370,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Rhizomata Option", "Adds Rhizomata when Addersgall is 0.", SGE.JobID, 10, "", "")]
        SGE_ST_Heal_Rhizomata = 14380,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Krasis Option", "Applies Krasis.", SGE.JobID, 8, "", "")]
        SGE_ST_Heal_Krasis = 14390,

        [ParentCombo(SGE_ST_Heal)]
        [CustomComboInfo("Druochole Option", "Applies Druochole.", SGE.JobID, 9, "", "")]
        SGE_ST_Heal_Druochole = 14400,
        #endregion

        #region Sage Simple AoE Heal
        [ReplaceSkill(SGE.Prognosis)]
        [CustomComboInfo("AoE Heal Feature", "Customize your AoE healing to your liking.", SGE.JobID, 500, "", "")]
        SGE_AoE_Heal = 14500,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Physis Option", "Adds Physis.", SGE.JobID, 504, "", "")]
        SGE_AoE_Heal_Physis = 14510,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Eukrasian Prognosis Option", "Prognosis becomes Eukrasian Prognosis if the shield is not applied.", SGE.JobID, 520, "", "")]
        SGE_AoE_Heal_EPrognosis = 14520,

        [ParentCombo(SGE_AoE_Heal_EPrognosis)]
        [CustomComboInfo("Ignore Shield Check", "Warning, will force the use of Eukrasia Prognosis, and normal Prognosis will be unavailable.", SGE.JobID, 520, "", "")]
        SGE_AoE_Heal_EPrognosis_IgnoreShield = 14521,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Holos Option", "Adds Holos.", SGE.JobID, 505, "", "")]
        SGE_AoE_Heal_Holos = 14530,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Panhaima Option", "Adds Panhaima.", SGE.JobID, 506, "", "")]
        SGE_AoE_Heal_Panhaima = 14540,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Pepsis Option", "Triggers Pepsis if a shield is present.", SGE.JobID, 507, "", "")]
        SGE_AoE_Heal_Pepsis = 14550,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Ixochole Option", "Adds Ixochole.", SGE.JobID, 503, "", "")]
        SGE_AoE_Heal_Ixochole = 14560,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Kerachole Option", "Adds Kerachole.", SGE.JobID, 502, "", "")]
        SGE_AoE_Heal_Kerachole = 14570,

        [ParentCombo(SGE_AoE_Heal)]
        [CustomComboInfo("Rhizomata Option", "Adds Rhizomata when Addersgall is 0.", SGE.JobID, 501, "", "")]
        SGE_AoE_Heal_Rhizomata = 14580,
        #endregion

        #region Misc Healing
        [ReplaceSkill(SGE.Taurochole, SGE.Druochole, SGE.Ixochole, SGE.Kerachole)]
        [CustomComboInfo("Rhizomata Feature", "Replaces Addersgall skills with Rhizomata when empty.", SGE.JobID, 600, "", "")]
        SGE_Rhizo = 14600,

        [ReplaceSkill(SGE.Druochole)]
        [CustomComboInfo("Druochole to Taurochole Feature", "Upgrades Druochole to Taurochole when Taurochole is available.", SGE.JobID, 700, "", "")]
        SGE_DruoTauro = 14700,

        [ReplaceSkill(SGE.Pneuma)]
        [CustomComboInfo("Zoe Pneuma Feature", "Places Zoe on top of Pneuma when both actions are on cooldown.", SGE.JobID, 701, "", "")] //Temporary to keep the order
        SGE_ZoePneuma = 141000,
        #endregion

        #region Utility
        [ReplaceSkill(All.Swiftcast)]
        [ConflictingCombos(ALL_Healer_Raise)]
        [CustomComboInfo("Swiftcast Raise Feature", "Changes Swiftcast to Egeiro while Swiftcast is on cooldown.", SGE.JobID, 800, "", "")]
        SGE_Raise = 14800,

        [ReplaceSkill(SGE.Soteria)]
        [CustomComboInfo("Soteria to Kardia Feature", "Soteria turns into Kardia when not active or Soteria is on-cooldown.", SGE.JobID, 900, "", "")]
        SGE_Kardia = 14900,

        [ReplaceSkill(SGE.Eukrasia)]
        [CustomComboInfo("Eukrasia Feature", "Eukrasia turns into the selected Eukrasian-type action when active.", SGE.JobID, 1000, "", "")]
        SGE_Eukrasia = 14910,

        [Variant]
        [VariantParent(SGE_ST_DPS_EDosis, SGE_AoE_DPS)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", SGE.JobID)]
        SGE_DPS_Variant_SpiritDart = 14920,

        [Variant]
        [VariantParent(SGE_ST_DPS, SGE_AoE_DPS)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", SGE.JobID)]
        SGE_DPS_Variant_Rampart = 14930,
        #endregion

        // Last value = 14930

        #endregion

        #region SAMURAI

        #region Overcap Features
        [ReplaceSkill(SAM.Kasha, SAM.Gekko, SAM.Yukikaze)]
        [CustomComboInfo("Samurai Overcap Feature", "Adds Shinten onto main combo when Kenki is at the selected amount or more", SAM.JobID)]
        SAM_ST_Overcap = 15001,

        [ReplaceSkill(SAM.Mangetsu, SAM.Oka)]
        [CustomComboInfo("Samurai AoE Overcap Feature", "Adds Kyuten onto main AoE combos when Kenki is at the selected amount or more", SAM.JobID)]
        SAM_AoE_Overcap = 15002,
        #endregion

        #region Main Combo (Gekko) Features
        [ReplaceSkill(SAM.Gekko)]
        [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain.\nIf all sub options are selected will turn into a full one button rotation (Advanced Samurai)", SAM.JobID)]
        SAM_ST_GekkoCombo = 15003,

        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Enpi Uptime Feature", "Replace main combo with Enpi when you are out of range.", SAM.JobID)]
        SAM_ST_GekkoCombo_RangedUptime = 15004,

        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Yukikaze Combo on Main Combo", "Adds Yukikaze combo to main combo. Will add Yukikaze during Meikyo Shisui as well", SAM.JobID)]
        SAM_ST_GekkoCombo_Yukikaze = 15005,

        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Kasha Combo on Main Combo", "Adds Kasha combo to main combo. Will add Kasha during Meikyo Shisui as well.", SAM.JobID)]
        SAM_ST_GekkoCombo_Kasha = 15006,

        [ConflictingCombos(SAM_GyotenYaten)]
        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Level 90 Samurai Opener", "Adds the Level 90 Opener to the main combo.\nOpener triggered by using Meikyo Shisui before combat. If you have any Sen, Hagakure will be used to clear them.\nWill work at any levels of Kenki, requires 2 charges of Meikyo Shisui and all CDs ready. If conditions aren't met it will skip into the regular rotation. \nIf the Opener is interrupted, it will exit the opener via a Goken and a Kaeshi: Goken at the end or via the last Yukikaze. If the latter, CDs will be used on cooldown regardless of burst options.", SAM.JobID)]
        SAM_ST_GekkoCombo_Opener = 15007,

        [ConflictingCombos(SAM_GyotenYaten)]
        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Filler Combo Feature", "Adds selected Filler combos to main combo at the appropriate time.\nChoose Skill Speed tier with Fuka buff below.\nWill disable if you die or if you don't activate the opener.", SAM.JobID)]
        SAM_ST_GekkoCombo_FillerCombos = 15008,

        #region CDs on Main Combo
        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("CDs on Main Combo", "Collection of CD features on main combo.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs = 15099,

        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Ikishoten on Main Combo", "Adds Ikishoten when at or below 50 Kenki.\nWill dump Kenki at 10 seconds left to allow Ikishoten to be used.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_Ikishoten = 15009,

        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Iaijutsu on Main Combo", "Adds Midare: Setsugekka, Higanbana, and Kaeshi: Setsugekka when ready and when you're not moving to main combo.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_Iaijutsu = 15010,

        #region Ogi Namikiri on Main Combo
        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Ogi Namikiri on Main Combo", "Ogi Namikiri and Kaeshi: Namikiri when ready and when you're not moving to main combo.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_OgiNamikiri = 15011,

        [ParentCombo(SAM_ST_GekkoCombo_CDs_OgiNamikiri)]
        [CustomComboInfo("Ogi Namikiri Burst Feature", "Saves Ogi Namikiri for even minute burst windows.\nIf you don't activate the opener or die, Ogi Namikiri will instead be used on CD.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_OgiNamikiri_Burst = 15012,
        #endregion

        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Meikyo Shisui on Main Combo", "Adds Meikyo Shisui to main combo when off cooldown.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_MeikyoShisui = 15013,

        #region Meikyo Shisui on Main Combo
        [ParentCombo(SAM_ST_GekkoCombo_CDs_MeikyoShisui)]
        [CustomComboInfo("Meikyo Shisui Burst Feature", "Saves Meikyo Shisui for burst windows.\nIf you don't activate the opener or die, Meikyo Shisui will instead be used on CD.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_MeikyoShisui_Burst = 15014,
        #endregion

        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Shoha on Main Combo", "Adds Shoha to main combo when there are three meditation stacks.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_Shoha = 15015,

        [ConflictingCombos(SAM_Shinten_Shoha_Senei)]
        [ParentCombo(SAM_ST_GekkoCombo_CDs)]
        [CustomComboInfo("Senei on Main Combo", "Adds Senei to main combo when off cooldown and above 25 Kenki.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_Senei = 15016,

        [ParentCombo(SAM_ST_GekkoCombo_CDs_Senei)]
        [CustomComboInfo("Senei Burst Feature", "Saves Senei for even minute burst windows.\nIf you don't activate the opener or die, Senei will instead be used on CD.", SAM.JobID)]
        SAM_ST_GekkoCombo_CDs_Senei_Burst = 15017,

        [ParentCombo(SAM_ST_Overcap)]
        [CustomComboInfo("Execute Feature", "Adds Shinten to the main combo when Kenki > 25 and your current target is below the HP percentage threshold.", SAM.JobID)]
        SAM_ST_Execute = 15046,
        #endregion

        #endregion

        #region Yukikaze/Kasha Combos
        [ReplaceSkill(SAM.Yukikaze)]
        [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain.", SAM.JobID)]
        SAM_ST_YukikazeCombo = 15018,

        [ReplaceSkill(SAM.Kasha)]
        [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain.", SAM.JobID)]
        SAM_ST_KashaCombo = 15019,
        #endregion

        #region AoE Combos
        [ReplaceSkill(SAM.Mangetsu)]
        [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain.\nIf all sub options are toggled will turn into a full one button AoE rotation.", SAM.JobID)]
        SAM_AoE_MangetsuCombo = 15020,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [ConflictingCombos(SAM_AoE_OkaCombo_TwoTarget)]
        [CustomComboInfo("Oka to Mangetsu Combo", "Adds Oka combo after Mangetsu combo loop.\nWill add Oka if needed during Meikyo Shisui.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_Oka = 15021,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Iaijutsu on Mangetsu Combo", "Adds Tenka Goken, Midare: Setsugekka, and Kaeshi: Goken when ready and when you're not moving to Mangetsu combo.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_TenkaGoken = 15022,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Ogi Namikiri on Mangetsu Combo", "Adds Ogi Namikiri and Kaeshi: Namikiri when ready and when you're not moving to Mangetsu combo.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_OgiNamikiri = 15023,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Shoha 2 on Mangetsu Combo", "Adds Shoha 2 when you have 3 meditation stacks to Mangetsu combo.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_Shoha2 = 15024,

        [ConflictingCombos(SAM_Kyuten_Shoha2_Guren)]
        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Guren on Mangetsu Combo", "Adds Guren when it's off cooldown and you have 25 Kenki to Mangetsu combo.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_Guren = 15025,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Meikyo Shisui on Mangetsu Combo", "Adds Meikyo Shisui to Mangetsu combo.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_MeikyoShisui = 15039,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Ikishoten on Mangetsu Combo", "Adds Ikishoten when at or below 50 Kenki.\nWill dump Kenki at 10 seconds left to allow Ikishoten to be used.", SAM.JobID)]
        SAM_AOE_GekkoCombo_CDs_Ikishoten = 15040,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Hagakure on Mangetsu Combo", "Adds Hagakure to Mangetsu combo when there are three Sen.", SAM.JobID)]
        SAM_AoE_MangetsuCombo_Hagakure = 15041,

        [ReplaceSkill(SAM.Oka)]
        [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain.", SAM.JobID)]
        SAM_AoE_OkaCombo = 15026,

        [ParentCombo(SAM_AoE_OkaCombo)]
        [ConflictingCombos(SAM_AoE_MangetsuCombo_Oka)]
        [CustomComboInfo("Oka Two Target Rotation Feature", "Adds the Yukikaze combo, Mangetsu combo, Senei, Shinten, and Shoha to Oka combo.\nUsed for two targets only and when Lv86 and above.", SAM.JobID)]
        SAM_AoE_OkaCombo_TwoTarget = 150261,
        #endregion

        #region Cooldown Features
        [ReplaceSkill(SAM.MeikyoShisui)]
        [CustomComboInfo("Jinpu/Shifu Feature", "Replace Meikyo Shisui with Jinpu, Shifu, and Yukikaze depending on what is needed.", SAM.JobID)]
        SAM_JinpuShifu = 15027,
        #endregion

        #region Iaijutsu Features
        [ReplaceSkill(SAM.Iaijutsu)]
        [CustomComboInfo("Iaijutsu Features", "Collection of Iaijutsu Features.", SAM.JobID)]
        SAM_Iaijutsu = 15028,

        [ParentCombo(SAM_Iaijutsu)]
        [CustomComboInfo("Iaijutsu to Tsubame-Gaeshi", "Replace Iaijutsu with  Tsubame-gaeshi when Sen is empty.", SAM.JobID)]
        SAM_Iaijutsu_TsubameGaeshi = 15029,

        [ParentCombo(SAM_Iaijutsu)]
        [CustomComboInfo("Iaijutsu to Shoha", "Replace Iaijutsu with Shoha when meditation is 3.", SAM.JobID)]
        SAM_Iaijutsu_Shoha = 15030,

        [ParentCombo(SAM_Iaijutsu)]
        [CustomComboInfo("Iaijutsu to Ogi Namikiri", "Replace Iaijutsu with Ogi Namikiri and Kaeshi: Namikiri when buffed with Ogi Namikiri Ready.", SAM.JobID)]
        SAM_Iaijutsu_OgiNamikiri = 15031,
        #endregion

        #region Shinten Features
        [ReplaceSkill(SAM.Shinten)]
        [CustomComboInfo("Shinten to Shoha", "Replace Hissatsu: Shinten with Shoha when OriginalHook(SteeledMeditation) is full.", SAM.JobID)]
        SAM_Shinten_Shoha = 15032,

        [ConflictingCombos(SAM_ST_GekkoCombo_CDs_Senei)]
        [ParentCombo(SAM_Shinten_Shoha)]
        [CustomComboInfo("Shinten to Senei", "Replace Hissatsu: Shinten with Senei when its cooldown is up.", SAM.JobID)]
        SAM_Shinten_Shoha_Senei = 15033,
        #endregion

        #region Kyuten Features
        [ReplaceSkill(SAM.Kyuten)]
        [CustomComboInfo("Kyuten to Shoha II", "Replace Hissatsu: Kyuten with Shoha II when OriginalHook(SteeledMeditation) is full.", SAM.JobID)]
        SAM_Kyuten_Shoha2 = 15034,

        [ConflictingCombos(SAM_AoE_MangetsuCombo_Guren)]
        [ParentCombo(SAM_Kyuten_Shoha2)]
        [CustomComboInfo("Kyuten to Guren", "Replace Hissatsu: Kyuten with Guren when its cooldown is up.", SAM.JobID)]
        SAM_Kyuten_Shoha2_Guren = 15035,
        #endregion

        #region Other
        [ConflictingCombos(SAM_ST_GekkoCombo_Opener, SAM_ST_GekkoCombo_FillerCombos)]
        [ReplaceSkill(SAM.Gyoten)]
        [CustomComboInfo("Gyoten Feature", "Hissatsu: Gyoten becomes Yaten/Gyoten depending on the distance from your target.", SAM.JobID)]
        SAM_GyotenYaten = 15036,

        [ReplaceSkill(SAM.Ikishoten)]
        [CustomComboInfo("Ikishoten Namikiri Feature", "Replace Ikishoten with Ogi Namikiri and then Kaeshi Namikiri when available.\nIf you have full OriginalHook(SteeledMeditation) stacks, Ikishoten becomes Shoha while you have Ogi Namikiri ready.", SAM.JobID)]
        SAM_Ikishoten_OgiNamikiri = 15037,

        [ReplaceSkill(SAM.Gekko, SAM.Yukikaze, SAM.Kasha)]
        [CustomComboInfo("True North Feature", "Adds True North on all single target combos if Meikyo Shisui's buff is on you.", SAM.JobID)]
        SAM_TrueNorth = 15038,

        [ParentCombo(SAM_ST_GekkoCombo)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo, using them when below the HP Percentage threshold.", SAM.JobID)]
        SAM_ST_ComboHeals = 15043,

        [ParentCombo(SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo, using them when below the HP Percentage threshold.", SAM.JobID)]
        SAM_AoE_ComboHeals = 15045,

        [Variant]
        [VariantParent(SAM_ST_GekkoCombo, SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", SAM.JobID)]
        SAM_Variant_Cure = 15047,

        [Variant]
        [VariantParent(SAM_ST_GekkoCombo, SAM_AoE_MangetsuCombo)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", SAM.JobID)]
        SAM_Variant_Rampart = 15048,
        #endregion

        // Last value = 15048

        #endregion

        #region SCHOLAR

        /* SCH Feature Numbering
        Numbering Scheme: 16[Feature][Option][Sub-Option]
        Example: 16110 (Feature Number 1, Option 1, no suboption)
        New features should be added to the appropriate sections.
        */

        #region DPS
        [ReplaceSkill(SCH.Ruin, SCH.Broil, SCH.Broil2, SCH.Broil3, SCH.Broil4, SCH.Bio, SCH.Bio2, SCH.Biolysis)]
        [CustomComboInfo("Single Target DPS Feature", "Replaces Ruin I / Broils with options below", SCH.JobID, 1)]
        SCH_DPS = 16100,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Lucid Dreaming Weave Option", "Adds Lucid Dreaming when MP drops below slider value:", SCH.JobID, 110)]
        SCH_DPS_Lucid = 16110,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Chain Stratagem Weave Option", "Adds Chain Stratagem on cooldown with overlap protection", SCH.JobID, 120)]
        SCH_DPS_ChainStrat = 16120,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Aetherflow Weave Option", "Use Aetherflow when out of Aetherflow stacks.", SCH.JobID, 130)]
        SCH_DPS_Aetherflow = 16130,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Energy Drain Weave Option", "Use Energy Drain to consume remaining Aetherflow stacks when Aetherflow is about to come off cooldown.", SCH.JobID, 131)]
        SCH_DPS_EnergyDrain = 16160,

        [ParentCombo(SCH_DPS_EnergyDrain)]
        [CustomComboInfo("Energy Drain Burst Option", "Holds Energy Drain when Chain Stratagem is ready or has less than 10 seconds cooldown remaining.", SCH.JobID, 133)]
        SCH_DPS_EnergyDrain_BurstSaver = 16161,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Ruin II Moving Option", "Use Ruin II when you have to move.", SCH.JobID, 150)]
        SCH_DPS_Ruin2Movement = 16140,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Bio / Biolysis Option", "Automatic DoT uptime.", SCH.JobID, 140)]
        SCH_DPS_Bio = 16150,

        [ParentCombo(SCH_DPS)]
        [CustomComboInfo("Dissipation Opener Option", "Use Dissipation at the start of the battle.", SCH.JobID, 170)]
        SCH_DPS_Dissipation_Opener = 16170,


        [ReplaceSkill(SCH.ArtOfWar, SCH.ArtOfWarII)]
        [CustomComboInfo("AoE DPS Feature", "Replaces Art of War with options below.", SCH.JobID, 3)]
        SCH_AoE = 16101,

        [ParentCombo(SCH_AoE)]
        [CustomComboInfo("Lucid Dreaming Weave Option", "Adds Lucid Dreaming when MP drops below slider value:", SCH.JobID)]
        SCH_AoE_Lucid = 16111,

        [ParentCombo(SCH_AoE)]
        [CustomComboInfo("Aetherflow Weave Option", "Use Aetherflow when out of Aetherflow stacks.", SCH.JobID)]
        SCH_AoE_Aetherflow = 16121,

        #endregion

        #region Healing
        [ReplaceSkill(SCH.FeyBlessing)]
        [CustomComboInfo("Fey Blessing to Seraph's Consolation Feature", "Change Fey Blessing into Consolation when Seraph is out.", SCH.JobID, 9)]
        SCH_Consolation = 16210,

        [ReplaceSkill(SCH.Lustrate)]
        [CustomComboInfo("Lustrate to Excogitation Feature", "Change Lustrate into Excogitation when Excogitation is ready.", SCH.JobID, 6)]
        SCH_Lustrate = 16220,

        [ReplaceSkill(SCH.Recitation)]
        [CustomComboInfo("Recitation Combo Feature", "Change Recitation into either Adloquium, Succor, Indomitability, or Excogitation when used.", SCH.JobID, 7)]
        SCH_Recitation = 16230,

        [ReplaceSkill(SCH.WhisperingDawn)]
        [CustomComboInfo("Fairy Healing Combo Feature", "Change Whispering Dawn into Fey Illumination, Fey Blessing, then Whispering Dawn when used.", SCH.JobID, 8)]
        SCH_Fairy_Combo = 16240,

        [ParentCombo(SCH_Fairy_Combo)]
        [CustomComboInfo("Consolation During Seraph Option", "Adds Consolation during Seraph.", SCH.JobID)]
        SCH_Fairy_Combo_Consolation = 16241,

        [ReplaceSkill(SCH.Succor)]
        [CustomComboInfo("AoE Heal Feature", "Replaces Succor with options below:", SCH.JobID, 5)]
        SCH_AoE_Heal = 16250,

        [ParentCombo(SCH_AoE_Heal)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming when MP isn't high enough to cast Succor.", SCH.JobID)]
        SCH_AoE_Heal_Lucid = 16251,

        [ParentCombo(SCH_AoE_Heal)]
        [CustomComboInfo("Aetherflow Option", "Use Aetherflow when out of Aetherflow stacks.", SCH.JobID)]
        SCH_AoE_Heal_Aetherflow = 16252,

        [ParentCombo(SCH_AoE_Heal_Aetherflow)]
        [CustomComboInfo("Indomitability Ready Only Option", "Only uses Aetherflow is Indomitability is ready to use.", SCH.JobID)]
        SCH_AoE_Heal_Aetherflow_Indomitability = 16253,

        [ParentCombo(SCH_AoE_Heal)]
        [CustomComboInfo("Indomitability Option", "Use Indomitability before using Succor.", SCH.JobID)]
        SCH_AoE_Heal_Indomitability = 16254,

        [ReplaceSkill(SCH.Physick)]
        [CustomComboInfo("Single Target Heal Feature", "Change Physick into Adloquium, Lustrate, then Physick with below options:", SCH.JobID, 4)]
        SCH_ST_Heal = 16260,

        [ParentCombo(SCH_ST_Heal)]
        [CustomComboInfo("Lucid Dreaming Weave Option", "Adds Lucid Dreaming when MP drops below slider value:", SCH.JobID, 1)]
        SCH_ST_Heal_Lucid = 16261,

        [ParentCombo(SCH_ST_Heal)]
        [CustomComboInfo("Aetherflow Weave Option", "Use Aetherflow when out of Aetherflow stacks.", SCH.JobID, 2)]
        SCH_ST_Heal_Aetherflow = 16262,

        [ParentCombo(SCH_ST_Heal)]
        [CustomComboInfo("Esuna Option", "Applies Esuna to your target if there is a cleansable debuff.", SGE.JobID, 3)]
        SCH_ST_Heal_Esuna = 16265,

        [ParentCombo(SCH_ST_Heal)]
        [CustomComboInfo("Adloquium Option", "Use Adloquium when missing Galvanize or target HP%% below:", SCH.JobID, 4)]
        SCH_ST_Heal_Adloquium = 16263,

        [ParentCombo(SCH_ST_Heal)]
        [CustomComboInfo("Lustrate Option", "Use Lustrate when target HP%% below:", SCH.JobID, 5)]
        SCH_ST_Heal_Lustrate = 16264,


        #endregion

        #region Utilities
        [ReplaceSkill(SCH.EnergyDrain, SCH.Lustrate, SCH.SacredSoil, SCH.Indomitability, SCH.Excogitation)]
        [CustomComboInfo("Aetherflow Helper Feature", "Change Aetherflow-using skills to Aetherflow, Recitation, or Dissipation as selected.", SCH.JobID, 9)]
        SCH_Aetherflow = 16300,

        [ParentCombo(SCH_Aetherflow)]
        [CustomComboInfo("Recitation Option", "Prioritizes Recitation usage on Excogitation or Indomitability.", SCH.JobID)]
        SCH_Aetherflow_Recite = 16310,

        [ParentCombo(SCH_Aetherflow)]
        [CustomComboInfo("Dissipation Option", "If Aetherflow is on cooldown, show Dissipation instead.", SCH.JobID)]
        SCH_Aetherflow_Dissipation = 16320,

        [ReplaceSkill(All.Swiftcast)]
        [ConflictingCombos(ALL_Healer_Raise)]
        [CustomComboInfo("Swiftcast Raise Combo Feature", "Changes Swiftcast to Resurrection while Swiftcast is on cooldown.", SCH.JobID, 10)]
        SCH_Raise = 16400,

        [ReplaceSkill(SCH.WhisperingDawn, SCH.FeyBlessing, SCH.FeyBlessing, SCH.Aetherpact, SCH.Dissipation)]
        [CustomComboInfo("Fairy Feature", "Change all fairy actions into Summon Eos when the Fairy is not summoned.", SCH.JobID, 11)]
        SCH_FairyReminder = 16500,

        [ReplaceSkill(SCH.DeploymentTactics)]
        [CustomComboInfo("Deployment Tactics Feature", "Changes Deployment Tactics to Adloquium until a party member has the Galvanize buff.", SCH.JobID, 12)]
        SCH_DeploymentTactics = 16600,

        [ParentCombo(SCH_DeploymentTactics)]
        [CustomComboInfo("Recitation Option", "Adds Recitation when off cooldown to force a critical Galvanize buff on a party member.", SCH.JobID)]
        SCH_DeploymentTactics_Recitation = 16610,

        [Variant]
        [VariantParent(SCH_DPS_Bio, SCH_AoE)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", SCH.JobID)]
        SCH_DPS_Variant_SpiritDart = 16700,

        [Variant]
        [VariantParent(SCH_DPS, SCH_AoE)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", SCH.JobID)]
        SCH_DPS_Variant_Rampart = 16800,

        #endregion

        // Last value = 16800

        #endregion

        #region SUMMONER

        [ReplaceSkill(SMN.Ruin, SMN.Ruin2, SMN.Outburst, SMN.Tridisaster)]
        [ConflictingCombos(SMN_Simple_Combo)]
        [CustomComboInfo("Advanced Summoner Feature", "Advanced combo features for a greater degree of customisation.\nAccommodates SpS builds.\nRuin III is left unchanged for mobility purposes.", SMN.JobID)]
        SMN_Advanced_Combo = 17000,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Demi Attacks Combo Option", "Adds Demi Summon oGCDs to the single target and AoE combos.", SMN.JobID, 11, "", "")]
        SMN_Advanced_Combo_DemiSummons_Attacks = 17002,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Egi Attacks Combo Option", "Adds Gemshine and Precious Brilliance to the single target and AoE combos, respectively.", SMN.JobID, 4, "", "")]
        SMN_Advanced_Combo_EgiSummons_Attacks = 17004,

        [ReplaceSkill(SMN.Fester)]
        [CustomComboInfo("Energy Drain to Fester Feature", "Change Fester into Energy Drain when out of Aetherflow stacks.", SMN.JobID, 6, "", "")]
        SMN_EDFester = 17008,

        [ReplaceSkill(SMN.Painflare)]
        [CustomComboInfo("Energy Siphon to Painflare Feature", "Change Painflare into Energy Siphon when out of Aetherflow stacks.", SMN.JobID, 7, "", "")]
        SMN_ESPainflare = 17009,

        // BONUS TWEAKS
        [CustomComboInfo("Carbuncle Reminder Feature", "Replaces most offensive actions with Summon Carbuncle when it is not summoned.", SMN.JobID, 8, "", "")]
        SMN_CarbuncleReminder = 17010,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Ruin IV Combo Option", "Adds Ruin IV to the single target and AoE combos.\nUses when moving during Garuda Phase and you have no attunement, when moving during Ifrit phase, or when you have no active Egi or Demi summon.", SMN.JobID)]
        SMN_Advanced_Combo_Ruin4 = 17011,

        [ParentCombo(SMN_EDFester)]
        [CustomComboInfo("Ruin IV Fester Option", "Changes Fester to Ruin IV when out of Aetherflow stacks, Energy Drain is on cooldown, and Ruin IV is available.", SMN.JobID)]
        SMN_EDFester_Ruin4 = 17013,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Energy Attacks Combo Option", "Adds Energy Drain and Fester to the single target combo.\nAdds Energy Siphon and Painflare to the AoE combo.\nWill be used on cooldown.", SMN.JobID, 1, "", "")]
        SMN_Advanced_Combo_EDFester = 17014,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Egi Summons Combo Option", "Adds Egi summons to the single target and AoE combos.\nWill prioritise the Egi selected below.\nIf no option is selected, the feature will default to summoning Titan first.", SMN.JobID, 3, "", "")]
        SMN_DemiEgiMenu_EgiOrder = 17016,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Searing Light Combo Option", "Adds Searing Light to the single target and AoE combos.\nWill be used on cooldown.", SMN.JobID, 9, "", "")]
        SMN_SearingLight = 17017,

        [ParentCombo(SMN_SearingLight)]
        [CustomComboInfo("Searing Light Burst Option", "Casts Searing Light only during Demi phases.\nReflects Demi choice selected under 'Pooled oGCDs Option'.\nNot recommended for SpS Builds.", SMN.JobID, 0, "")]
        SMN_SearingLight_Burst = 17018,
        
        [ParentCombo(SMN_SearingLight)]
        [CustomComboInfo("Searing Flash Combo Option", "Adds Searing Flash to the single target and AoE combos.", SMN.JobID, 1, "", "")]
        SMN_SearingFlash = 17019,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Demi Summons Combo Option", "Adds Demi summons to the single target and AoE combos.", SMN.JobID, 10, "", "")]
        SMN_Advanced_Combo_DemiSummons = 17020,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Swiftcast Egi Ability Option", "Uses Swiftcast during the selected Egi summon.", SMN.JobID, 8, "", "")]
        SMN_DemiEgiMenu_SwiftcastEgi = 17023,

        [CustomComboInfo("Astral Flow/Enkindle on Demis Feature", "Adds Enkindle Bahamut, Enkindle Phoenix and Astral Flow to their relevant summons.", SMN.JobID, 11, "", "")]
        SMN_DemiAbilities = 17024,

        [ParentCombo(SMN_Advanced_Combo_EDFester)]
        [CustomComboInfo("Pooled oGCDs Option", "Pools damage oGCDs for use inside the selected Demi phase while under the Searing Light buff.\nBahamut Burst becomes Solar Bahamut Burst at Lv100.", SMN.JobID, 1, "", "")]
        SMN_DemiEgiMenu_oGCDPooling = 17025,

        [ConflictingCombos(ALL_Caster_Raise)]
        [CustomComboInfo("Alternative Raise Feature", "Changes Swiftcast to Raise when on cooldown.", SMN.JobID, 8, "", "")]
        SMN_Raise = 17027,

        [ParentCombo(SMN_Advanced_Combo_DemiSummons_Attacks)]
        [CustomComboInfo("Rekindle Combo Option", "Adds Rekindle to the single target and AoE combos.", SMN.JobID, 13, "", "")]
        SMN_Advanced_Combo_DemiSummons_Rekindle = 17028,

        [ParentCombo(SMN_Advanced_Combo_DemiSummons_Attacks)]
        [CustomComboInfo("Lux Solaris Combo Option", "Adds Lux Solaris to the single target and AoE combos.", SMN.JobID, 14, "", "")]
        SMN_Advanced_Combo_DemiSummons_LuxSolaris = 17029,
        
        [ReplaceSkill(SMN.Ruin4)]
        [CustomComboInfo("Ruin III Mobility Feature", "Puts Ruin III on Ruin IV when you don't have Further Ruin.", SMN.JobID, 9, "", "")]
        SMN_RuinMobility = 17030,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming to the single target combo when MP falls below the set value.", SMN.JobID, 2, "", "")]
        SMN_Lucid = 17031,

        [CustomComboInfo("Egi Abilities on Summons Feature", "Adds Egi Abilities (Astral Flow) to Egi summons when ready.\nEgi abilities will appear on their respective Egi summon ability, as well as Titan.", SMN.JobID, 12, "", "")]
        SMN_Egi_AstralFlow = 17034,

        [ParentCombo(SMN_SearingLight)]
        [CustomComboInfo("Use only on Single Target combo", "Prevent this feature from applying to the AoE combo.", SMN.JobID, 2, "", "")]
        SMN_SearingLight_STOnly = 17036,

        [ParentCombo(SMN_DemiEgiMenu_oGCDPooling)]
        [CustomComboInfo("Use only on Single Target combo", "Prevent this feature from applying to the AoE combo.", SMN.JobID, 3, "", "")]
        SMN_DemiEgiMenu_oGCDPooling_Only = 17037,

        [ParentCombo(SMN_DemiEgiMenu_SwiftcastEgi)]
        [CustomComboInfo("Use only on Single Target combo", "Prevent this feature from applying to the AoE combo.", SMN.JobID, 2, "", "")]
        SMN_DemiEgiMenu_SwiftcastEgi_Only = 17038,

        [ParentCombo(SMN_ESPainflare)]
        [CustomComboInfo("Ruin IV Painflare Option", "Changes Painflare to Ruin IV when out of Aetherflow stacks, Energy Siphon is on cooldown, and Ruin IV is up.", SMN.JobID)]
        SMN_ESPainflare_Ruin4 = 17039,

        [ParentCombo(SMN_Advanced_Combo)]
        [CustomComboInfo("Add Egi Astralflow", "Choose which Egi Astralflows to add to the rotation.", SMN.JobID, 0, "", "")]
        SMN_ST_Egi_AstralFlow = 17048,

        [ConflictingCombos(SMN_Advanced_Combo)]
        [ReplaceSkill(SMN.Ruin, SMN.Ruin2, SMN.Outburst, SMN.Tridisaster)]
        [CustomComboInfo("Simple Summoner Feature", "General purpose one-button combo.\nBursts on Bahamut phase.\nSummons Titan, Garuda, then Ifrit.\nSwiftcasts on Slipstream unless drifted.", SMN.JobID, -1, "", "")]
        SMN_Simple_Combo = 17041,

        [ParentCombo(SMN_DemiEgiMenu_oGCDPooling)]
        [CustomComboInfo("Burst Delay Option", "Only follows Burst Delay settings for the opener burst.\nThis Option is for high SPS builds.", SMN.JobID, 2, "", "")]
        SMN_Advanced_Burst_Delay_Option = 17043,

        [ParentCombo(SMN_DemiEgiMenu_oGCDPooling)]
        [CustomComboInfo("Any Searing Burst Option", "Checks for any Searing light for bursting rather than just your own.\nUse this option if partied with multiple SMN and are worried about your Searing being overwritten.", SMN.JobID, 1, "", "")]
        SMN_Advanced_Burst_Any_Option = 17044,

        [Variant]
        [VariantParent(SMN_Simple_Combo, SMN_Advanced_Combo)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", SMN.JobID)]
        SMN_Variant_Rampart = 17045,

        [Variant]
        [VariantParent(SMN_Raise)]
        [CustomComboInfo("Raise Option", "Turn Swiftcast into Variant Raise whenever you have the Swiftcast buff.", SMN.JobID)]
        SMN_Variant_Raise = 17046,

        [Variant]
        [VariantParent(SMN_Simple_Combo, SMN_Advanced_Combo)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", SMN.JobID)]
        SMN_Variant_Cure = 17047,



        // Last value = 17047 (170181)

        #endregion

        #region VIPER
        [ReplaceSkill(VPR.SteelFangs)]
        [ConflictingCombos(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Simple Mode - Single Target", "Replaces Steel Fangs with a full one-button single target rotation.\nThis is the ideal option for newcomers to the job.", VPR.JobID)]
        VPR_ST_SimpleMode = 20000,

        #region Advanced ST Viper

        [ReplaceSkill(VPR.SteelFangs)]
        [ConflictingCombos(VPR_ST_SimpleMode)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replaces Steel Fangs with a full one-button single target rotation.\nThese features are ideal if you want to customize the rotation.", VPR.JobID)]
        VPR_ST_AdvancedMode = 20001,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Level 100 Opener", "Adds the Balance opener to the rotation.", VPR.JobID)]
        VPR_ST_Opener = 20002,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Noxious Gnash", "Adds Noxious Gnash if it is not present on current target, or is about to expire.", VPR.JobID)]
        VPR_ST_NoxiousGnash = 20003,

        #region Cooldowns ST

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Cooldowns Option", "Adds various cooldowns to the rotation.", VPR.JobID)]
        VPR_ST_CDs = 20004,

        [ParentCombo(VPR_ST_CDs)]
        [CustomComboInfo("Serpents Ire", "Adds Serpents Ire to the rotation.", VPR.JobID)]
        VPR_ST_SerpentsIre = 20005,

        [ParentCombo(VPR_ST_CDs)]
        [CustomComboInfo("Dreadwinder", "Adds Dreadwinder to the rotation.", VPR.JobID)]
        VPR_ST_Dreadwinder = 20006,

        [ParentCombo(VPR_ST_Dreadwinder)]
        [CustomComboInfo("Dreadwinder Combo", "Adds Swiftskin's Coil and Hunter's Coil to the rotation.", VPR.JobID)]
        VPR_ST_DreadwinderCombo = 20007,

        #endregion

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Serpents Tail", "Adds Serpents Tail to the rotation.", VPR.JobID)]
        VPR_ST_SerpentsTail = 20008,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Uncoiled Fury", "Adds Uncoiled Fury to the rotation.", VPR.JobID)]
        VPR_ST_UncoiledFury = 20009,

        [ParentCombo(VPR_ST_UncoiledFury)]
        [CustomComboInfo("Uncoiled Fury Combo", "Adds Uncoiled Twinfang and Uncoiled Twinblood to the rotation.", VPR.JobID)]
        VPR_ST_UncoiledFuryCombo = 200010,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Reawaken", "Adds Reawaken to the rotation.", VPR.JobID)]
        VPR_ST_Reawaken = 20011,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Reawaken Combo", "Adds Generation and Legacy to the rotation.", VPR.JobID)]
        VPR_ST_ReawakenCombo = 20012,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Ranged Uptime Option", "Adds Writhing Snap to the rotation when you are out of melee range.", VPR.JobID)]
        VPR_ST_RangedUptime = 20096,

        [ParentCombo(VPR_ST_RangedUptime)]
        [CustomComboInfo("Add Uncoiled Fury", "Adds Uncoiled Fury to the rotation when you are out of melee range and have Rattling Coil charges.", VPR.JobID)]
        VPR_ST_RangedUptimeUncoiledFury = 20097,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the rotation.", VPR.JobID)]
        VPR_ST_ComboHeals = 20098,

        [ParentCombo(VPR_ST_AdvancedMode)]
        [CustomComboInfo("Dynamic True North Option", "Adds True North when you are not in the correct position for the enhanced potency bonus.", VPR.JobID)]
        VPR_TrueNorthDynamic = 20099,

        #endregion

        [ReplaceSkill(VPR.SteelMaw)]
        [ConflictingCombos(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Simple Mode - AoE", "Replaces Steel Maw with a full one-button AoE rotation.\nThis is the ideal option for newcomers to the job.", VPR.JobID)]
        VPR_AoE_SimpleMode = 20100,

        #region Advanced AoE Viper

        [ReplaceSkill(VPR.SteelMaw)]
        [ConflictingCombos(VPR_AoE_SimpleMode)]
        [CustomComboInfo("Advanced Mode AoE", "Replaces Steel Maw with a full one-button AoE rotation.\nThese features are ideal if you want to customize the rotation.", VPR.JobID)]
        VPR_AoE_AdvancedMode = 20101,

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Noxious Gnash", "Adds Noxious Gnash if it is not present on current target, or is about to expire.", VPR.JobID)]
        VPR_AoE_NoxiousGnash = 20102,

        #region Cooldowns AoE

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Cooldowns Option", "Adds various cooldowns to the rotation.", VPR.JobID)]
        VPR_AoE_CDs = 20103,

        [ParentCombo(VPR_AoE_CDs)]
        [CustomComboInfo("Serpents Ire", "Adds Serpents Ire to the rotation.", VPR.JobID)]
        VPR_AoE_SerpentsIre = 20104,

        [ParentCombo(VPR_AoE_CDs)]
        [CustomComboInfo("Pit Of Dread", "Adds Pit Of Dread to the rotation.", VPR.JobID)]
        VPR_AoE_PitOfDread = 20105,

        [ParentCombo(VPR_AoE_PitOfDread)]
        [CustomComboInfo("Pit Of Dread Combo", "Adds Swiftskin's Den and Hunter's Den to the rotation.", VPR.JobID)]
        VPR_AoE_PitOfDreadCombo = 20106,

        #endregion

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Serpents Tail", "Adds Serpents Tail to the rotation.", VPR.JobID)]
        VPR_AoE_SerpentsTail = 20107,

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Uncoiled Fury", "Adds Uncoiled Fury to the rotation.", VPR.JobID)]
        VPR_AoE_UncoiledFury = 20108,

        [ParentCombo(VPR_AoE_UncoiledFury)]
        [CustomComboInfo("Uncoiled Fury Combo", "Adds Uncoiled Twinfang and Uncoiled Twinblood to the rotation.", VPR.JobID)]
        VPR_AoE_UncoiledFuryCombo = 20109,

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Reawaken", "Adds Reawaken to the rotation.", VPR.JobID)]
        VPR_AoE_Reawaken = 20110,

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Reawaken Combo", "Adds Generation and Legacy to the rotation.", VPR.JobID)]
        VPR_AoE_ReawakenCombo = 20112,

        [ParentCombo(VPR_AoE_AdvancedMode)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the rotation.", VPR.JobID)]
        VPR_AoE_ComboHeals = 20199,

        #endregion

        [ReplaceSkill(VPR.Dreadwinder)]
        [CustomComboInfo("Dreadwinder - Coils", "Replaces Dreadwinder with the Coils.\n Also adds Twinfang and Twinblood to the button.", VPR.JobID)]
        VPR_DreadwinderCoils = 20200,

        [ReplaceSkill(VPR.PitofDread)]
        [CustomComboInfo("Pit Of Dread - Dens", "Replaces Pits Of Dread with the Dens.\n Also adds Twinfang and Twinblood to the button.", VPR.JobID)]
        VPR_PitOfDreadDens = 20201,

        [ReplaceSkill(VPR.UncoiledFury)]
        [CustomComboInfo("Uncoiled - Twins", "Replaces Uncoiled Fury with Uncoiled Twinfang and Uncoiled Twinblood.", VPR.JobID)]
        VPR_UncoiledTwins = 20202,

        [ReplaceSkill(VPR.Reawaken)]
        [CustomComboInfo("Reawawken - Legacy", "Replaces Reawaken with the Generations and Legacy's.", VPR.JobID)]
        VPR_ReawakenLegacy = 20203,

        #endregion

        #region WARRIOR

        [ReplaceSkill(WAR.StormsPath)]
        [CustomComboInfo("Advanced Mode - Single Target", "Replaces Storm's Path with a one-button full single target rotation.\nThese features are ideal if you want to customize the rotation.", WAR.JobID, 1)]
        WAR_ST_StormsPath = 18000,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Berserk / Inner Release Option", "Adds Berserk / Inner Release to Advanced Mode.", WAR.JobID)]
        WAR_ST_StormsPath_InnerRelease = 18020,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Tomahawk Uptime Option", "Adds Tomahawk to Advanced Mode when you are out of range.", WAR.JobID, 1, "", "")]
        WAR_ST_StormsPath_RangedUptime = 18016,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Inner Beast / Fell Cleave Option", "Adds Inner Beast / Fell Cleave to Advanced Mode. Will use when you have the set minimum gauge, or under the effect of Inner Release. Will also use Nascent Chaos.", WAR.JobID, 2, "", "")]
        WAR_ST_StormsPath_FellCleave = 18011,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Infuriate Option", "Adds Infuriate to Advanced Mode.", WAR.JobID, 3, "", "")]
        WAR_ST_StormsPath_Infuriate = 18021,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Onslaught Option", "Adds Onslaught to Advanced Mode if you are under Surging Tempest Buff.", WAR.JobID, 4, "", "")]
        WAR_ST_StormsPath_Onslaught = 18012,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Upheaval Option", "Adds Upheaval to Advanced Mode if you have Surging Tempest.", WAR.JobID, 5, "", "")]
        WAR_ST_StormsPath_Upheaval = 18007,

        [ParentCombo(WAR_AoE_Overpower)]
        [CustomComboInfo("Orogeny Option", "Adds Orogeny to Advanced Mode when you are buffed with Surging Tempest.", WAR.JobID, 6, "", "")]
        WAR_AoE_Overpower_Orogeny = 18009,

        [ParentCombo(WAR_ST_StormsPath)]
        [CustomComboInfo("Primal Rend Option", "Adds Primal Rend to Advanced Mode.", WAR.JobID, 7, "", "")]
        WAR_ST_StormsPath_PrimalRend = 18008,

        [ReplaceSkill(WAR.StormsEye)]
        [CustomComboInfo("Storm's Eye Combo Feature", "Replace Storm's Eye with its combo chain.", WAR.JobID, 3, "", "")]
        War_ST_StormsEye = 18001,

        [ReplaceSkill(WAR.Overpower)]
        [CustomComboInfo("Advanced Mode - AoE", "Replaces Overpower with a one-button full AoE rotation.\nThese features are ideal if you want to customize the rotation.", WAR.JobID, 2, "", "")]
        WAR_AoE_Overpower = 18002,

        [ReplaceSkill(WAR.NascentFlash)]
        [CustomComboInfo("Nascent Flash Feature", "Replace Nascent Flash with Raw intuition when level synced below 76.", WAR.JobID, 5, "", "")]
        WAR_NascentFlash = 18005,

        [ParentCombo(WAR_AoE_Overpower)]
        [CustomComboInfo("Infuriate Option", "Adds Infuriate to Advanced Mode when gauge is below 50 and not under Inner Release.", WAR.JobID)]
        WAR_AoE_Overpower_Infuriate = 18013,

        [ParentCombo(WAR_AoE_Overpower)]
        [CustomComboInfo("Berserk / Inner Release Option", "Adds Berserk / Inner Release to Advanced Mode.", WAR.JobID)]
        WAR_AoE_Overpower_InnerRelease = 18014,

        [ReplaceSkill(WAR.FellCleave, WAR.Decimate)]
        [CustomComboInfo("Infuriate on Fell Cleave / Decimate Feature", "Turns Fell Cleave and Decimate into Infuriate if at or under set rage value.", WAR.JobID, 4, "", "")]
        WAR_InfuriateFellCleave = 18018,

        [ReplaceSkill(WAR.InnerRelease)]
        [CustomComboInfo("Primal Rend Feature", "Turns Inner Release into Primal Rend on use.", WAR.JobID, 3, "", "")]
        WAR_PrimalRend_InnerRelease = 18019,

        [ParentCombo(WAR_InfuriateFellCleave)]
        [CustomComboInfo("Inner Release Priority Option", "Prevents the use of Infuriate while you have Inner Release stacks available.", WAR.JobID)]
        WAR_InfuriateFellCleave_IRFirst = 18022,

        [ParentCombo(WAR_ST_StormsPath_PrimalRend)]
        [CustomComboInfo("Primal Rend Melee Option", "Uses Primal Rend when in the target's target ring (1 yalm) and when not moving otherwise will use it when buff is less than 10 seconds.", WAR.JobID)]
        WAR_ST_StormsPath_PrimalRend_CloseRange = 18023,

        [ParentCombo(WAR_ST_StormsPath_Onslaught)]
        [CustomComboInfo("Melee Onslaught Option", "Uses Onslaught when under Surging Tempest and in the target ring (1 yalm) and when not moving.\nWill use as many stacks as selected in the above slider.", WAR.JobID)]
        WAR_ST_StormsPath_Onslaught_MeleeSpender = 18024,

        [Variant]
        [VariantParent(WAR_ST_StormsPath, WAR_AoE_Overpower)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", WAR.JobID)]
        WAR_Variant_SpiritDart = 18025,

        [Variant]
        [VariantParent(WAR_ST_StormsPath, WAR_AoE_Overpower)]
        [CustomComboInfo("Cure Option", "Use Variant Cure when HP is below set threshold.", WAR.JobID)]
        WAR_Variant_Cure = 18026,

        [Variant]
        [VariantParent(WAR_ST_StormsPath, WAR_AoE_Overpower)]
        [CustomComboInfo("Ultimatum Option", "Use Variant Ultimatum on cooldown.", WAR.JobID)]
        WAR_Variant_Ultimatum = 18027,

        [ParentCombo(WAR_AoE_Overpower)]
        [CustomComboInfo("Steel Cyclone / Decimate Option", "Adds Steel Cyclone / Decimate to Advanced Mode.", WAR.JobID)]
        WAR_AoE_Overpower_Decimate = 18028,

        // Last value = 18028

        #endregion

        #region WHITE MAGE

        #region Single Target DPS Feature

        [ReplaceSkill(WHM.Stone1, WHM.Stone2, WHM.Stone3, WHM.Stone4, WHM.Glare1, WHM.Glare3)]
        [CustomComboInfo("Single Target DPS Feature", "Collection of cooldowns and spell features on Glare/Stone.", WHM.JobID, 1, "", "")]
        WHM_ST_MainCombo = 19099,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Opener Option", "Use the Balance opener from level 56+.", WHM.JobID, 11, "", "")]
        WHM_ST_MainCombo_Opener = 19023,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Aero/Dia Uptime Option", "Adds Aero/Dia to the single target combo if the debuff is not present on current target, or is about to expire.", WHM.JobID, 12, "", "")]
        WHM_ST_MainCombo_DoT = 19013,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Assize Option", "Adds Assize to the single target combo.", WHM.JobID, 13, "", "")]
        WHM_ST_MainCombo_Assize = 19009,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Afflatus Misery Option", "Adds Afflatus Misery to the single target combo when it is ready to be used.", WHM.JobID, 14, "", "")]
        WHM_ST_MainCombo_Misery_oGCD = 19017,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Lily Overcap Protection Option", "Adds Afflatus Rapture to the single target combo when at three Lilies.", WHM.JobID, 15, "", "")]
        WHM_ST_MainCombo_LilyOvercap = 19016,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Presence of Mind Option", "Adds Presence of Mind to the single target combo.", WHM.JobID, 16, "", "")]
        WHM_ST_MainCombo_PresenceOfMind = 19008,

        [ParentCombo(WHM_ST_MainCombo)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming to the single target combo when below set MP value.", WHM.JobID, 17, "", "")]
        WHM_ST_MainCombo_Lucid = 19006,

        #endregion

        #region AoE DPS Feature

        [ReplaceSkill(WHM.Holy, WHM.Holy3)]
        [CustomComboInfo("AoE DPS Feature", "Collection of cooldowns and spell features on Holy/Holy III.", WHM.JobID, 2, "", "")]
        WHM_AoE_DPS = 19190,

        [ParentCombo(WHM_AoE_DPS)]
        [CustomComboInfo("Assize Option", "Adds Assize to the AoE combo.", WHM.JobID, 21, "", "")]
        WHM_AoE_DPS_Assize = 19192,

        [ParentCombo(WHM_AoE_DPS)]
        [CustomComboInfo("Afflatus Misery Option", "Adds Afflatus Misery to the AoE combo when it is ready to be used.", WHM.JobID, 22, "", "")]
        WHM_AoE_DPS_Misery = 19194,

        [ParentCombo(WHM_AoE_DPS)]
        [CustomComboInfo("Lily Overcap Protection Option", "Adds Afflatus Rapture to the AoE combo when at three Lilies.", WHM.JobID, 23, "", "")]
        WHM_AoE_DPS_LilyOvercap = 19193,

        [ParentCombo(WHM_AoE_DPS)]
        [CustomComboInfo("Presence of Mind Option", "Adds Presence of Mind to the AoE combo if you are moving or it can be weaved without GCD delay.", WHM.JobID, 24, "", "")]
        WHM_AoE_DPS_PresenceOfMind = 19195,

        [ParentCombo(WHM_AoE_DPS)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming to the AoE combo when below the set MP value if you are moving or it can be weaved without GCD delay.", WHM.JobID, 25, "", "")]
        WHM_AoE_DPS_Lucid = 19191,

        #endregion

        [ReplaceSkill(WHM.AfflatusSolace)]
        [CustomComboInfo("Solace into Misery Feature", "Replaces Afflatus Solace with Afflatus Misery when it is ready to be used.", WHM.JobID, 30, "", "")]
        WHM_SolaceMisery = 19000,

        [ReplaceSkill(WHM.AfflatusRapture)]
        [CustomComboInfo("Rapture into Misery Feature", "Replaces Afflatus Rapture with Afflatus Misery when it is ready to be used.", WHM.JobID, 40, "", "")]
        WHM_RaptureMisery = 19001,

        #region AoE Heals Feature

        [ReplaceSkill(WHM.Medica)]
        [CustomComboInfo("Simple Heals (AoE)", "Replaces Medica with a one button AoE healing setup.", WHM.JobID, 4, "", "")]
        WHM_AoEHeals = 19007,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Afflatus Rapture Option", "Uses Afflatus Rapture when available.", WHM.JobID, 2, "", "")]
        WHM_AoEHeals_Rapture = 19011,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Afflatus Misery Option", "Uses Afflatus Misery when available.", WHM.JobID, 3, "", "")]
        WHM_AoEHeals_Misery = 19010,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Thin Air Option", "Uses Thin Air when available.", WHM.JobID, 4, "", "")]
        WHM_AoEHeals_ThinAir = 19200,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Cure III Option", "Replaces Medica with Cure III when available.", WHM.JobID, 5)]
        WHM_AoEHeals_Cure3 = 19201,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Assize Option", "Uses Assize when available.", WHM.JobID, 6)]
        WHM_AoEHeals_Assize = 19202,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Plenary Indulgence Option", "Uses Plenary Indulgence when available.", WHM.JobID, 7)]
        WHM_AoEHeals_Plenary = 19203,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Lucid Dreaming Option", "Uses Lucid Dreaming when available.", WHM.JobID, 8)]
        WHM_AoEHeals_Lucid = 19204,

        [ParentCombo(WHM_AoEHeals)]
        [CustomComboInfo("Medica II Option", "Uses Medica II when current target doesn't have Medica II buff.", WHM.JobID, 1)]
        WHM_AoEHeals_Medica2 = 19205,

        #endregion

        #region Single Target Heals

        [ReplaceSkill(WHM.Cure)]
        [CustomComboInfo("Simple Heals (Single Target)", "Replaces Cure with a one button single target healing setup.", WHM.JobID, 3)]
        WHM_STHeals = 19300,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Regen Option", "Applies Regen to the target if missing.", WHM.JobID)]
        WHM_STHeals_Regen = 19301,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Benediction Option", "Uses Benediction when target is below HP threshold.", WHM.JobID)]
        WHM_STHeals_Benediction = 19302,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Afflatus Solace Option", "Uses Afflatus Solace when available.", WHM.JobID)]
        WHM_STHeals_Solace = 19303,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Thin Air Option", "Uses Thin Air when available.", WHM.JobID)]
        WHM_STHeals_ThinAir = 19304,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Tetragrammaton Option", "Uses Tetragrammaton when available.", WHM.JobID)]
        WHM_STHeals_Tetragrammaton = 19305,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Divine Benison Option", "Uses Divine Benison when available.", WHM.JobID)]
        WHM_STHeals_Benison = 19306,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Aqualveil Option", "Uses Aquaveil when available.", WHM.JobID)]
        WHM_STHeals_Aquaveil = 19307,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Lucid Dreaming Option", "Uses Lucid Dreaming when available.", WHM.JobID)]
        WHM_STHeals_Lucid = 19308,

        [ParentCombo(WHM_STHeals)]
        [CustomComboInfo("Esuna Option", "Applies Esuna to your target if there is a cleansable debuff.", WHM.JobID)]
        WHM_STHeals_Esuna = 19309,

        #endregion

        [ReplaceSkill(WHM.Cure2)]
        [CustomComboInfo("Cure II Sync Feature", "Changes Cure II to Cure when synced below Lv.30.", WHM.JobID, 70, "", "")]
        WHM_CureSync = 19002,

        [ReplaceSkill(All.Swiftcast)]
        [ConflictingCombos(ALL_Healer_Raise)]
        [CustomComboInfo("Alternative Raise Feature", "Changes Swiftcast to Raise.", WHM.JobID, 80, "", "")]
        WHM_Raise = 19004,

        [ReplaceSkill(WHM.Raise)]
        [CustomComboInfo("Thin Air Raise Feature", "Adds Thin Air to the Global Raise Feature/Alternative Raise Feature.", WHM.JobID, 90, "", "")]
        WHM_ThinAirRaise = 19014,

        [Variant]
        [VariantParent(WHM_ST_MainCombo_DoT, WHM_AoE_DPS)]
        [CustomComboInfo("Spirit Dart Option", "Use Variant Spirit Dart whenever the debuff is not present or less than 3s.", WHM.JobID)]
        WHM_DPS_Variant_SpiritDart = 19025,

        [Variant]
        [VariantParent(WHM_ST_MainCombo, WHM_AoE_DPS)]
        [CustomComboInfo("Rampart Option", "Use Variant Rampart on cooldown.", WHM.JobID)]
        WHM_DPS_Variant_Rampart = 19026,

        // Last value = 19027

        #endregion

        // Non-combat

        #region DOH

        // [CustomComboInfo("Placeholder", "Placeholder.", DOH.JobID)]
        // DohPlaceholder = 50001,

        #endregion

        #region DOL

        [ReplaceSkill(DOL.AgelessWords, DOL.SolidReason)]
        [CustomComboInfo("[BTN/MIN] Eureka Feature", "Replaces Ageless Words and Solid Reason with Wise to the World when available", DOL.JobID)]
        DOL_Eureka = 51001,

        [ReplaceSkill(DOL.ArborCall, DOL.ArborCall2, DOL.LayOfTheLand, DOL.LayOfTheLand2)]
        [CustomComboInfo("[BTN/MIN] Locate & Truth Feature", "Replaces Lay of the Lands or Arbor Calls with Prospect/Triangulate and Truth of Mountains/Forests if not active.", DOL.JobID)]
        DOL_NodeSearchingBuffs = 51012,

        [ReplaceSkill(DOL.Cast)]
        [CustomComboInfo("[FSH] Cast to Hook Feature", "Replaces Cast with Hook when fishing", DOL.JobID)]
        FSH_CastHook = 51002,

        [CustomComboInfo("[FSH] Diving Feature", "Replace fishing abilities with diving abilities when underwater", DOL.JobID)]
        FSH_Swim = 51008,

        [ReplaceSkill(DOL.Cast)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("[FSH] Cast to Gig Option", "Replaces Cast with Gig when diving.", DOL.JobID)]
        FSH_CastGig = 51003,

        [ReplaceSkill(DOL.SurfaceSlap)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Surface Slap to Veteran Trade Option", "Replaces Surface Slap with Veteran Trade when diving.", DOL.JobID)]
        FSH_SurfaceTrade = 51004,

        [ReplaceSkill(DOL.PrizeCatch)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Prize Catch to Nature's Bounty Option", "Replaces Prize Catch with Nature's Bounty when diving.", DOL.JobID)]
        FSH_PrizeBounty = 51005,

        [ReplaceSkill(DOL.Snagging)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Snagging to Salvage Option", "Replaces Snagging with Salvage when diving.", DOL.JobID)]
        FSH_SnaggingSalvage = 51006,

        [ReplaceSkill(DOL.CastLight)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Cast Light to Electric Current Option", "Replaces Cast Light with Electric Current when diving.", DOL.JobID)]
        FSH_CastLight_ElectricCurrent = 51007,

        [ReplaceSkill(DOL.Mooch, DOL.MoochII)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Mooch to Shark Eye Option", "Replaces Mooch with Shark Eye when diving.", DOL.JobID)]
        FSH_Mooch_SharkEye = 51009,

        [ReplaceSkill(DOL.FishEyes)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Fish Eyes to Vital Sight Option", "Replaces Fish Eyes with Vital Sight when diving.", DOL.JobID)]
        FSH_FishEyes_VitalSight = 51010,

        [ReplaceSkill(DOL.Chum)]
        [ParentCombo(FSH_Swim)]
        [CustomComboInfo("Chum to Baited Breath Option", "Replaces Chum with Baited Breath when diving.", DOL.JobID)]
        FSH_Chum_BaitedBreath = 51011,

        // Last value = 51011

        #endregion

        #endregion

        #region PvP Combos

        #region PvP GLOBAL FEATURES
        [PvPCustomCombo]
        [CustomComboInfo("Emergency Heals Feature", "Uses Recuperate when your HP is under the set threshold and you have sufficient MP.", ADV.JobID, 1)]
        PvP_EmergencyHeals = 1100000,

        [PvPCustomCombo]
        [CustomComboInfo("Emergency Guard Feature", "Uses Guard when your HP is under the set threshold.", ADV.JobID, 2)]
        PvP_EmergencyGuard = 1100010,

        [PvPCustomCombo]
        [CustomComboInfo("Quick Purify Feature", "Uses Purify when afflicted with any selected debuff.", ADV.JobID, 4)]
        PvP_QuickPurify = 1100020,

        [PvPCustomCombo]
        [CustomComboInfo("Prevent Mash Cancelling Feature", "Stops you cancelling your guard if you're pressing buttons quickly.", ADV.JobID, 3)]
        PvP_MashCancel = 1100030,

        // Last value = 1100030
        // Extra 0 on the end keeps things working the way they should be. Nothing to see here.

        #endregion

        #region ASTROLOGIAN
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Fall Malefic into an all-in-one damage button.", AST.JobID)]
        ASTPvP_Burst = 111000,

        [ParentCombo(ASTPvP_Burst)]
        [CustomComboInfo("Double Cast Option", "Adds Double Cast to Burst Mode.", AST.JobID)]
        ASTPvP_DoubleCast = 111001,

        [ParentCombo(ASTPvP_Burst)]
        [CustomComboInfo("Card Option", "Adds Drawing and Playing Cards to Burst Mode.", AST.JobID)]
        ASTPvP_Card = 111002,

        [PvPCustomCombo]
        [CustomComboInfo("Double Cast Heal Feature", "Adds Double Cast to Aspected Benefic.", AST.JobID)]
        ASTPvP_Heal = 111003,

        // Last value = 111003
        #endregion

        #region BLACK MAGE
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Fire and Blizzard into all-in-one damage buttons.", BLM.JobID)]
        BLMPvP_BurstMode = 112000,

        [ParentCombo(BLMPvP_BurstMode)]
        [PvPCustomCombo]
        [CustomComboInfo("Night Wing Option", "Adds Night Wing to Burst Mode.", BLM.JobID)]
        BLMPvP_BurstMode_NightWing = 112001,

        [ParentCombo(BLMPvP_BurstMode)]
        [PvPCustomCombo]
        [CustomComboInfo("Aetherial Manipulation Option", "Uses Aetherial Manipulation to gap close if Burst is off cooldown.", BLM.JobID)]
        BLMPvP_BurstMode_AetherialManip = 112002,

        // Last value = 112002

        #endregion

        #region BARD
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Powerful Shot into an all-in-one damage button.", BRDPvP.JobID)]
        BRDPvP_BurstMode = 113000,

        [PvPCustomCombo]
        [ParentCombo(BRDPvP_BurstMode)]
        [CustomComboInfo("Silent Nocturne Option", "Adds Silent Nocturne to Burst Mode.", BRD.JobID)]
        BRDPvP_SilentNocturne = 113001,

        // Last value = 113001

        #endregion

        #region DANCER
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Fountain Combo into an all-in-one damage button.", DNC.JobID)]
        DNCPvP_BurstMode = 114000,

        [PvPCustomCombo]
        [ParentCombo(DNCPvP_BurstMode)]
        [CustomComboInfo("Honing Dance Option", "Adds Honing Dance to the main combo when in melee range (respects global offset).\nThis option prevents early use of Honing Ovation!\nKeep Honing Dance bound to another key if you want to end early.", DNC.JobID)]
        DNCPvP_BurstMode_HoningDance = 114001,

        [PvPCustomCombo]
        [ParentCombo(DNCPvP_BurstMode)]
        [CustomComboInfo("Curing Waltz Option", "Adds Curing Waltz to the combo when available, and your HP is at or below the set percentage.", DNC.JobID)]
        DNCPvP_BurstMode_CuringWaltz = 114002,

        // Last value = 114002

        #endregion

        #region DARK KNIGHT
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Souleater Combo into an all-in-one damage button.", DRK.JobID)]
        DRKPvP_Burst = 115000,

        [PvPCustomCombo]
        [ParentCombo(DRKPvP_Burst)]
        [CustomComboInfo("Plunge Option", "Adds Plunge to Burst Mode.", DRK.JobID)]
        DRKPvP_Plunge = 115001,

        [PvPCustomCombo]
        [ParentCombo(DRKPvP_Plunge)]
        [CustomComboInfo("Melee Plunge Option", "Uses Plunge whilst in melee range, and not just as a gap-closer.", DRK.JobID)]
        DRKPvP_PlungeMelee = 115002,

        [PvPCustomCombo]
        [ParentCombo(DRKPvP_Burst)]
        [CustomComboInfo("Salted Earth Option", "Adds Salted Earth to Burst mode.", DRK.JobID)]
        DRKPvP_SaltedEarth = 115003,

        // Last value = 115002

        #endregion

        #region DRAGOON
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Using Elusive Jump turns Wheeling Thrust Combo into all-in-one burst damage button.", DRG.JobID)]
        DRGPvP_Burst = 116000,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("Geirskogul Option", "Adds Geirskogul to Burst Mode.", DRG.JobID)]
        DRGPvP_Geirskogul = 116001,

        [ParentCombo(DRGPvP_Geirskogul)]
        [CustomComboInfo("Nastrond Option", "Adds Nastrond to Burst Mode.", DRG.JobID)]
        DRGPvP_Nastrond = 116002,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("Horrid Roar Option", "Adds Horrid Roar to Burst Mode.", DRG.JobID)]
        DRGPvP_HorridRoar = 116003,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("Sustain Chaos Spring Option", "Adds Chaos Spring to Burst Mode when below the set HP percentage.", DRG.JobID)]
        DRGPvP_ChaoticSpringSustain = 116004,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("Wyrmwind Thrust Option", "Adds Wyrmwind Thrust to Burst Mode.", DRG.JobID)]
        DRGPvP_WyrmwindThrust = 116006,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("High Jump Weave Option", "Adds High Jump to Burst Mode.", DRG.JobID)]
        DRGPvP_HighJump = 116007,

        [ParentCombo(DRGPvP_Burst)]
        [CustomComboInfo("Elusive Jump Burst Protection Option", "Disables Elusive Jump if Burst is not ready.", DRG.JobID)]
        DRGPvP_BurstProtection = 116008,

        // Last value = 116008

        #endregion

        #region GUNBREAKER

        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Solid Barrel Combo into an all-in-one damage button.", GNB.JobID)]
        GNBPvP_Burst = 117000,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Double Down Option", "Adds Double Down to Burst Mode while under the No Mercy buff.", GNB.JobID)]
        GNBPvP_DoubleDown = 117001,

        [PvPCustomCombo]
        [CustomComboInfo("Gnashing Fang Continuation Feature", "Adds Continuation onto Gnashing Fang.", GNB.JobID)]
        GNBPvP_GnashingFang = 117002,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Draw And Junction Option", "Adds Draw And Junction to Burst Mode.", GNB.JobID)]
        GNBPvP_DrawAndJunction = 117003,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Gnashing Fang Option", "Adds Gnashing Fang to Burst Mode while under the No Mercy buff.", GNB.JobID)]
        GNBPvP_ST_GnashingFang = 117004,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Continuation Option", "Adds Continuation to Burst Mode.", GNB.JobID)]
        GNBPvP_ST_Continuation = 117005,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Rough Divide Option", "Weaves Rough Divide when No Mercy Buff is about to expire.", GNB.JobID)]
        GNBPvP_RoughDivide = 117006,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Junction Cast DPS Option", "Adds Junction Cast (DPS) to Burst Mode.", GNB.JobID)]
        GNBPvP_JunctionDPS = 117007,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Junction Cast Healer Option", "Adds Junction Cast (Healer) to Burst Mode.", GNB.JobID)]
        GNBPvP_JunctionHealer = 117008,

        [ParentCombo(GNBPvP_Burst)]
        [CustomComboInfo("Junction Cast Tank Option", "Adds Junction Cast (Tank) to Burst Mode.", GNB.JobID)]
        GNBPvP_JunctionTank = 117009,

        // Last value = 117009

        #endregion

        #region MACHINIST
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Blast Charge into an all-in-one damage button.", MCHPvP.JobID)]
        MCHPvP_BurstMode = 118000,

        [PvPCustomCombo]
        [ParentCombo(MCHPvP_BurstMode)]
        [CustomComboInfo("Alternate Drill Option", "Saves Drill for use after Wildfire.", MCHPvP.JobID)]
        MCHPvP_BurstMode_AltDrill = 118001,

        [PvPCustomCombo]
        [ParentCombo(MCHPvP_BurstMode)]
        [CustomComboInfo("Alternate Analysis Option", "Uses Analysis with Air Anchor instead of Chain Saw.", MCHPvP.JobID)]
        MCHPvP_BurstMode_AltAnalysis = 118002,

        // Last value = 118002

        #endregion

        #region MONK
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Phantom Rush Combo into an all-in-one damage button.", MNK.JobID)]
        MNKPvP_Burst = 119000,

        [ParentCombo(MNKPvP_Burst)]
        [PvPCustomCombo]
        [CustomComboInfo("Thunderclap Option", "Adds Thunderclap to Burst Mode when not buffed with Wind Resonance.", MNK.JobID)]
        MNKPvP_Burst_Thunderclap = 119001,

        [ParentCombo(MNKPvP_Burst)]
        [PvPCustomCombo]
        [CustomComboInfo("Riddle of Earth Option", "Adds Riddle of Earth and Earth's Reply to Burst Mode when in combat.", MNK.JobID)]
        MNKPvP_Burst_RiddleOfEarth = 119002,

        [ParentCombo(MNKPvP_Burst)]
        [PvPCustomCombo]
        [CustomComboInfo("Six-sided Star Option", "Adds Six-sided Star to Burst Mode.", MNK.JobID)]
        MNKPvP_Burst_SixSidedStar = 119003,

        // Last value = 119003

        #endregion

        #region NINJA
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Aeolian Edge Combo into an all-in-one damage button.", NINPvP.JobID)]
        NINPvP_ST_BurstMode = 120000,

        [PvPCustomCombo]
        [CustomComboInfo("AoE Burst Mode", "Turns Fuma Shuriken into an all-in-one AoE damage button.", NINPvP.JobID)]
        NINPvP_AoE_BurstMode = 120001,

        [ParentCombo(NINPvP_ST_BurstMode)]
        [PvPCustomCombo]
        [CustomComboInfo("Meisui Option", "Uses Three Mudra on Meisui when HP is under the set threshold.", NINPvP.JobID)]
        NINPvP_ST_Meisui = 120002,

        [ParentCombo(NINPvP_AoE_BurstMode)]
        [PvPCustomCombo]
        [CustomComboInfo("Meisui Option", "Uses Three Mudra on Meisui when HP is under the set threshold.", NINPvP.JobID)]
        NINPvP_AoE_Meisui = 120003,

        // Last value = 120003

        #endregion

        #region PALADIN
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Royal Authority Combo into an all-in-one damage button.", PLD.JobID)]
        PLDPvP_Burst = 121000,

        [ParentCombo(PLDPvP_Burst)]
        [CustomComboInfo("Shield Bash Option", "Adds Shield Bash to Burst Mode.", PLD.JobID)]
        PLDPvP_ShieldBash = 121001,

        [ParentCombo(PLDPvP_Burst)]
        [CustomComboInfo("Confiteor Option", "Adds Confiteor to Burst Mode.", PLD.JobID)]
        PLDPvP_Confiteor = 121002,

        // Last value = 121002

        #endregion

        #region REAPER
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Slice Combo into an all-in-one damage button.\nAdds Soul Slice to the main combo.", RPR.JobID)]
        RPRPvP_Burst = 122000,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Death Warrant Option", "Adds Death Warrant onto the main combo when Plentiful Harvest is ready to use, or when Plentiful Harvest's cooldown is longer than Death Warrant's.\nRespects Immortal Sacrifice Pooling Option.", RPR.JobID)]
        RPRPvP_Burst_DeathWarrant = 122001,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Plentiful Harvest Opener Option", "Starts combat with Plentiful Harvest to immediately begin Limit Break generation.", RPR.JobID)]
        RPRPvP_Burst_PlentifulOpener = 122002,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Plentiful Harvest + Immortal Sacrifice Pooling Option", "Pools stacks of Immortal Sacrifice before using Plentiful Harvest.\nAlso holds Plentiful Harvest if Death Warrant is on cooldown.\nSet the value to 3 or below to use Plentiful Harvest as soon as it's available.", RPR.JobID)]
        RPRPvP_Burst_ImmortalPooling = 122003,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Enshrouded Burst Option", "Adds Lemure's Slice to the main combo during the Enshroud burst phase.\nContains burst options.", RPR.JobID)]
        RPRPvP_Burst_Enshrouded = 122004,

        #region RPR Enshrouded Option
        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst_Enshrouded)]
        [CustomComboInfo("Enshrouded Death Warrant Option", "Adds Death Warrant onto the main combo during the Enshroud burst when available.", RPR.JobID)]
        RPRPvP_Burst_Enshrouded_DeathWarrant = 122005,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst_Enshrouded)]
        [CustomComboInfo("Communio Finisher Option", "Adds Communio onto the main combo when you have 1 stack of Enshroud remaining.\nWill not trigger if you are moving.", RPR.JobID)]
        RPRPvP_Burst_Enshrouded_Communio = 122006,
        #endregion

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Ranged Harvest Moon Option", "Adds Harvest Moon onto the main combo when you're out of melee range, the GCD is not rolling and it's available for use.", RPR.JobID)]
        RPRPvP_Burst_RangedHarvest = 122007,

        [PvPCustomCombo]
        [ParentCombo(RPRPvP_Burst)]
        [CustomComboInfo("Arcane Crest Option", "Adds Arcane Crest to the main combo when under the set HP perecentage.", RPR.JobID)]
        RPRPvP_Burst_ArcaneCircle = 122008,

        // Last value = 122008

        #endregion

        #region RED MAGE
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Verstone/Verfire into an all-in-one damage button.", RDMPvP.JobID)]
        RDMPvP_BurstMode = 123000,

        [PvPCustomCombo]
        [ParentCombo(RDMPvP_BurstMode)]
        [CustomComboInfo("No Frazzle Option", "Prevents Frazzle from being used in Burst Mode.", RDMPvP.JobID)]
        RDMPvP_FrazzleOption = 123001,

        // Last value = 123001

        #endregion

        #region SAGE
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Dosis III into an all-in-one damage button.", SGE.JobID)]
        SGEPvP_BurstMode = 124000,

        [ParentCombo(SGEPvP_BurstMode)]
        [CustomComboInfo("Pneuma Option", "Adds Pneuma to Burst Mode.", SGE.JobID)]
        SGEPvP_BurstMode_Pneuma = 124001,

        // Last value = 124001

        #endregion

        #region SAMURAI

        #region Burst Mode
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Adds Meikyo Shisui, Midare: Setsugekka, Ogi Namikiri, Kaeshi: Namikiri and Soten to Meikyo Shisui.\nWill only cast Midare: Setsugekka and Ogi Namikiri when you're not moving.\nWill not use if target is guarding.", SAM.JobID)]
        SAMPvP_BurstMode = 125000,

        [PvPCustomCombo]
        [ParentCombo(SAMPvP_BurstMode)]
        [CustomComboInfo("Chiten Option", "Adds Chiten to Burst Mode when in combat and HP is below 95%.", SAM.JobID)]
        SAMPvP_BurstMode_Chiten = 125001,

        [PvPCustomCombo]
        [ParentCombo(SAMPvP_BurstMode)]
        [CustomComboInfo("Mineuchi Option", "Adds Mineuchi to Burst Mode.", SAM.JobID)]
        SAMPvP_BurstMode_Stun = 125002,

        [PvPCustomCombo]
        [ParentCombo(SAMPvP_BurstMode)]
        [CustomComboInfo("Burst Mode on Kasha Combo Option", "Adds Burst Mode to Kasha Combo instead.", SAM.JobID, 1)]
        SAMPvP_BurstMode_MainCombo = 125003,
        #endregion

        #region Kasha Features
        [PvPCustomCombo]
        [CustomComboInfo("Kasha Combo Features", "Collection of Features for Kasha Combo.", SAM.JobID)]
        SAMPvP_KashaFeatures = 125004,

        [PvPCustomCombo]
        [ParentCombo(SAMPvP_KashaFeatures)]
        [CustomComboInfo("Soten Gap Closer Option", "Adds Soten to the Kasha Combo when out of melee range.", SAM.JobID)]
        SAMPvP_KashaFeatures_GapCloser = 125005,

        [PvPCustomCombo]
        [ParentCombo(SAMPvP_KashaFeatures)]
        [CustomComboInfo("AoE Melee Protection Option", "Makes the AoE combos unusable if not in melee range of target.", SAM.JobID)]
        SAMPvP_KashaFeatures_AoEMeleeProtection = 125006,
        #endregion

        // Last value = 125006

        #endregion

        #region SCHOLAR
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Broil IV into all-in-one damage button.", SCH.JobID)]
        SCHPvP_Burst = 126000,

        [ParentCombo(SCHPvP_Burst)]
        [CustomComboInfo("Expedient Option", "Adds Expedient to Burst Mode to empower Biolysis.", SCH.JobID)]
        SCHPvP_Expedient = 126001,

        [ParentCombo(SCHPvP_Burst)]
        [CustomComboInfo("Biolysis Option", "Adds Biolysis use on cooldown to Burst Mode.", SCH.JobID)]
        SCHPvP_Biolysis = 126002,

        [ParentCombo(SCHPvP_Burst)]
        [CustomComboInfo("Deployment Tactics Option", "Adds Deployment Tactics to Burst Mode when available.", SCH.JobID)]
        SCHPvP_DeploymentTactics = 126003,

        // Last value = 126003

        #endregion

        #region SUMMONER
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Ruin III into an all-in-one damage button.\nOnly uses Crimson Cyclone when in melee range.", SMNPvP.JobID)]
        SMNPvP_BurstMode = 127000,

        [PvPCustomCombo]
        [ParentCombo(SMNPvP_BurstMode)]
        [CustomComboInfo("Radiant Aegis Option", "Adds Radiant Aegis to Burst Mode when available, and your HP is at or below the set percentage.", SMNPvP.JobID)]
        SMNPvP_BurstMode_RadiantAegis = 127001,

        // Last value = 127001

        #endregion

        #region WARRIOR
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Heavy Swing into an all-in-one damage button.", WARPvP.JobID)]
        WARPvP_BurstMode = 128000,

        [PvPCustomCombo]
        [ParentCombo(WARPvP_BurstMode)]
        [CustomComboInfo("Bloodwhetting Option", "Allows use of Bloodwhetting any time, not just between GCDs.", WARPvP.JobID)]
        WARPvP_BurstMode_Bloodwhetting = 128001,

        [PvPCustomCombo]
        [ParentCombo(WARPvP_BurstMode)]
        [CustomComboInfo("Blota Option", "Adds Blota to Burst Mode when not in melee range.", WARPvP.JobID)]
        WARPvP_BurstMode_Blota = 128003,

        [PvPCustomCombo]
        [ParentCombo(WARPvP_BurstMode)]
        [CustomComboInfo("Primal Rend Option", "Adds Primal Rend to Burst Mode.", WARPvP.JobID)]
        WARPvP_BurstMode_PrimalRend = 128004,

        // Last value = 128002

        #endregion

        #region WHITE MAGE
        [PvPCustomCombo]
        [CustomComboInfo("Burst Mode", "Turns Glare into an all-in-one damage button.", WHM.JobID)]
        WHMPvP_Burst = 129000,

        [ParentCombo(WHMPvP_Burst)]
        [CustomComboInfo("Misery Option", "Adds Afflatus Misery to Burst Mode.", WHM.JobID)]
        WHMPvP_Afflatus_Misery = 129001,

        [ParentCombo(WHMPvP_Burst)]
        [CustomComboInfo("Miracle of Nature Option", "Adds Miracle of Nature to Burst Mode.", WHM.JobID)]
        WHMPvP_Mirace_of_Nature = 129002,

        [ParentCombo(WHMPvP_Burst)]
        [CustomComboInfo("Seraph Strike Option", "Adds Seraph Strike to Burst Mode.", WHM.JobID)]
        WHMPvP_Seraph_Strike = 129003,

        [PvPCustomCombo]
        [CustomComboInfo("Aquaveil Feature", "Adds Aquaveil to Cure II when available.", WHM.JobID)]
        WHMPvP_Aquaveil = 129004,

        [PvPCustomCombo]
        [CustomComboInfo("Cure III Feature", "Adds Cure III to Cure II when available.", WHM.JobID)]
        WHMPvP_Cure3 = 129005,

        // Last value = 129005

        #endregion

        #endregion
    }
}
