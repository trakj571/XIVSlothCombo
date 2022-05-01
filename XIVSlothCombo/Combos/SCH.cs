using Dalamud.Game.ClientState.JobGauge.Types;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Game.ClientState.Objects.Enums;

namespace XIVSlothComboPlugin.Combos
{
    internal static class SCH
    {
        public const byte ClassID = 15;
        public const byte JobID = 28;

        public const uint

            // Heals
            Physick = 190,
            Adloquium = 185,
            Succor = 186,
            Lustrate = 189,
            SacredSoil = 188,
            Indomitability = 3583,
            Excogitation = 7434,
            Consolation = 16546,

            // Offense
            Bio1 = 17864,
            Bio2 = 17865,
            Biolysis = 16540,
            Ruin1 = 17869,
            Ruin2 = 17870,
            Broil1 = 3584,
            Broil2 = 7435,
            Broil3 = 16541,
            Broil4 = 25865,
            Scourge = 16539,
            EnergyDrain = 167,

            // Faerie
            SummonSeraph = 16545,
            SummonEos = 17215,
            SummonSelene = 17216,
            WhisperingDawn = 16537,
            FeyIllumination = 16538,
            Dissipation = 3587,
            Aetherpact = 7437,
            FeyBlessing = 16543,

            // Other
            Aetherflow = 166,
            Recitation = 16542,
            ChainStratagem = 7436,

            // Role
            Resurrection = 173;
            //Esuna = 5768,

        public static class Buffs
        {
            public const ushort
            Recitation = 1896;
        }

        public static class Debuffs
        {
            public const ushort
            Bio1 = 179,
            Bio2 = 189,
            Biolysis = 1895,
            ChainStratagem = 1221;
        }

        public static class Levels
        {
            public const byte

                Bio1 = 2,
                Physick = 4,
                WhisperingDawn = 20,
                Bio2 = 26,
                Adloquium = 30,
                Succor = 35,
                Ruin2 = 38,
                FeyIllumination = 40,
                Aetherflow = 45,
                EnergyDrain = 45,
                Lustrate = 45,
                Scourge = 46,
                SacredSoil = 50,
                Indomitability = 52,
                Broil = 54,
                DeploymentTactics = 56,
                EmergencyTactics = 58,
                Dissipation = 60,
                Excogitation = 62,
                Broil2 = 64,
                ChainStratagem = 66,
                Aetherpact = 70,
                Biolysis = 72,
                Broil3 = 72,
                Recitation = 74,
                FeyBlessing = 76,
                SummonSeraph = 80,
                Broil4 = 82,
                Scoura = 82,
                Protraction = 86,
                Expedient = 90;
        }

        public static class Config
        {
            public const string
                SCH_ST_Broil_Lucid = "SCH_ST_Broil_Lucid",
                SCH_ST_Broil_BioHPPer = "SCH_ST_Broil_BioHPPer",
                SCH_ST_Broil_ChainStratagem = "SCH_ST_Broil_ChainStratagem",
                SCH_Aetherflow_Recite_Excog = "SCH_Aetherflow_Recite_Excog",
                SCH_Aetherflow_Recite_Indom = "SCH_Aetherflow_Recite_Indom",
                SCH_FairyFeature = "SCH_FairyFeature";
        }
    }

    //Even though Summon Seraph becomes Consolation, this Feature puts the temporary fairy aoe heal+barrier ontop of the existing fairy AoE skill Fey Blessing
    internal class ScholarSeraphConsolationFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SCH_ConsolationFeature;
        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID is SCH.FeyBlessing &&
                level >= SCH.Levels.SummonSeraph &&
                GetJobGauge<SCHGauge>().SeraphTimer > 0
               ) return SCH.Consolation; else return actionID;
        }
    }

    //Replaces all EnergyDrain actions with Aetherflow when depleted
    //Revised to a similar flow as Sage Rhizomata, but with Dissipation / Recitation as a backup
    internal class ScholarAetherflowFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SCH_AetherflowFeature;
        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID is SCH.EnergyDrain or SCH.Lustrate or SCH.SacredSoil or SCH.Indomitability or SCH.Excogitation &&
                level >= SCH.Levels.Aetherflow)
            {
                var gauge = GetJobGauge<SCHGauge>().Aetherflow;
                if (IsEnabled(CustomComboPreset.SCH_Aetherflow_Recite) && 
                    level >= SCH.Levels.Recitation && 
                    (IsOffCooldown(SCH.Recitation) || HasEffect(SCH.Buffs.Recitation)) )
                {
                    //Request here. Recitation Indominability and Excogitation, with optional check against AF zero stack count
                    if (IsEnabled(CustomComboPreset.SCH_Aetherflow_Recite_Excog) &&
                        (GetOptionValue(SCH.Config.SCH_Aetherflow_Recite_Excog) == 1 || (GetOptionValue(SCH.Config.SCH_Aetherflow_Recite_Excog) == 2 && gauge == 0)) &&
                        actionID is SCH.Excogitation )
                    {   //Do not merge this nested if with above. Won't procede with next set
                        if (HasEffect(SCH.Buffs.Recitation) && IsOffCooldown(SCH.Excogitation)) return SCH.Excogitation; else return SCH.Recitation;
                    }

                    if (IsEnabled(CustomComboPreset.SCH_Aetherflow_Recite_Indom) &&
                        (GetOptionValue(SCH.Config.SCH_Aetherflow_Recite_Indom) == 1 || (GetOptionValue(SCH.Config.SCH_Aetherflow_Recite_Indom) == 2 && gauge == 0)) &&
                        actionID is SCH.Indomitability )
                    {
                        if (HasEffect(SCH.Buffs.Recitation) && IsOffCooldown(SCH.Excogitation)) return SCH.Indomitability; else return SCH.Recitation;
                    }
                }
                if (gauge == 0)
                {
                    if (IsEnabled(CustomComboPreset.SCH_Aetherflow_Dissipation) &&
                        level >= SCH.Levels.Dissipation &&
                        IsOffCooldown(SCH.Dissipation) &&
                        IsOnCooldown(SCH.Aetherflow) &&
                        HasPetPresent() //Dissipation requires fairy, can't seem to make it replace dissipation with fairy summon feature *shrug*
                       ) return SCH.Dissipation;
                    else return SCH.Aetherflow;

                }
            }
            return actionID;
        }
    }

    //Swiftcast changes to Raise when activated / on cooldown
    internal class ScholarRaiseFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SCH_RaiseFeature;
        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID is All.Swiftcast && IsOnCooldown(All.Swiftcast)) return SCH.Resurrection;
            else return actionID;
        }
    }

    //Replaces Fairy abilitys with fairy summoning with Eos (default) or Selene
    internal class ScholarFairyFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SCH_FairyFeature;

        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID is SCH.WhisperingDawn or SCH.FeyBlessing or SCH.FeyBlessing or SCH.FeyIllumination or SCH.Dissipation or SCH.Aetherpact or SCH.Dissipation &&
                !HasPetPresent() && 
                GetJobGauge<SCHGauge>().SeraphTimer == 0)
            {
                if ((GetOptionValue(SCH.Config.SCH_FairyFeature)) == 2) return SCH.SummonSelene; //it's a 1 or 2 option atm.
                else return SCH.SummonEos;
            }
            return actionID;
        }
    }

    //Overwrides main DPS ability family, The Broils (and ruin 1)
    //Implements new Sage features as ToT, and Ruin 2 as the movement option
    //ChainStratagem has overlap protection
    internal class ScholarBroilFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SCH_ST_BroilFeature;
        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID is SCH.Ruin1 or SCH.Broil1 or SCH.Broil2 or SCH.Broil3 or SCH.Broil4 && InCombat())
            {
                //Lucid Dreaming
                if (IsEnabled(CustomComboPreset.SCH_ST_Broil_Lucid) &&
                    level >= All.Levels.LucidDreaming &&
                    IsOffCooldown(All.LucidDreaming) &&
                    LocalPlayer.CurrentMp <= GetOptionValue(SCH.Config.SCH_ST_Broil_Lucid) &&
                    CanSpellWeave(actionID)
                   ) return All.LucidDreaming;

                //Chain Stratagem
                if (IsEnabled(CustomComboPreset.SCH_ST_Broil_ChainStratagem) &&
                    level >= SCH.Levels.ChainStratagem &&
                    IsOffCooldown(SCH.ChainStratagem) &&
                    !TargetHasEffectAny(SCH.Debuffs.ChainStratagem) && //Overwrite protection
                    EnemyHealthPercentage() > GetOptionValue(SCH.Config.SCH_ST_Broil_ChainStratagem) &&
                    CanSpellWeave(actionID)
                   ) return SCH.ChainStratagem;

                //Bio/Biolysis
                if (IsEnabled(CustomComboPreset.SCH_ST_Broil_Bio) && level >= SCH.Levels.Bio1 && CurrentTarget is not null)
                {
                    var OurTarget = CurrentTarget;
                    //Check if our Target is there and not an enemy
                    if ((CurrentTarget as BattleNpc)?.BattleNpcKind is not BattleNpcSubKind.Enemy)
                    {
                        //If ToT is enabled, Check if ToT is not null
                        if ((IsEnabled(CustomComboPreset.SCH_ST_Broil_BioToT)) &&
                            (CurrentTarget.TargetObject is not null) &&
                            ((CurrentTarget.TargetObject as BattleNpc)?.BattleNpcKind is BattleNpcSubKind.Enemy))
                            //Set Ourtarget as the Target of Target
                            OurTarget = CurrentTarget.TargetObject;
                        //Our Target of Target wasn't hostile, our target isn't hostile, time to exit, nothing to check debuff on, fuck this shit we're out
                        else return actionID;
                    }

                    //Determine which Bio debuff to check
                    var BioDebuffID = level switch
                    {
                        //Using FindEffect b/c we have a custom Target variable
                        >= SCH.Levels.Biolysis => FindEffect(SCH.Debuffs.Biolysis, OurTarget, LocalPlayer?.ObjectId),
                        >= SCH.Levels.Bio2 => FindEffect(SCH.Debuffs.Bio2, OurTarget, LocalPlayer?.ObjectId),
                        //Bio 1 checked at the start, fine for default
                        _ => FindEffect(SCH.Debuffs.Bio1, OurTarget, LocalPlayer?.ObjectId),
                    };
                    if ((BioDebuffID is null) || (BioDebuffID.RemainingTime <= 3))
                    {
                        //Advanced Options Enabled to procede with auto-bio
                        //Incompatible with ToT due to Enemy checks that are using CurrentTarget.
                        if (IsEnabled(CustomComboPreset.SCH_ST_Broil_BioHPPer))
                        {
                            if ((BioDebuffID is null || BioDebuffID.RemainingTime <= 3) &&
                                (EnemyHealthPercentage() > GetOptionValue(SCH.Config.SCH_ST_Broil_BioHPPer))
                               ) return OriginalHook(SCH.Bio1);
                        }
                        else return OriginalHook(SCH.Bio1); ;
                    }
                }

                //Aetherflow
                if (IsEnabled(CustomComboPreset.SCH_ST_Broil_Aetherflow) &&
                    level >= SCH.Levels.Aetherflow &&
                    GetJobGauge<SCHGauge>().Aetherflow == 0 &&
                    IsOffCooldown(SCH.Aetherflow)
                   ) return SCH.Aetherflow;

                //Ruin 2 Movement 
                if (IsEnabled(CustomComboPreset.SCH_ST_Broil_Ruin2Movement) &&
                    level >= SCH.Levels.Ruin2 &&
                    HasBattleTarget() &&
                    this.IsMoving
                   ) return OriginalHook(SCH.Ruin2); //Who knows in the future

                //End
            }
            return actionID;
        }
    }

}
