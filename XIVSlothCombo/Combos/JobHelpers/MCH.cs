﻿using ECommons.DalamudServices;
using System;
using XIVSlothCombo.Combos.JobHelpers.Enums;
using XIVSlothCombo.CustomComboNS.Functions;
using XIVSlothCombo.Data;

namespace XIVSlothCombo.Combos.JobHelpers
{
    internal class MCHOpenerLogic : PvE.MCH
    {
        private static bool HasCooldowns()
        {
            if (CustomComboFunctions.GetRemainingCharges(CustomComboFunctions.OriginalHook(Ricochet)) < 3)
                return false;
            if (CustomComboFunctions.GetRemainingCharges(CustomComboFunctions.OriginalHook(GaussRound)) < 3)
                return false;
            if (!CustomComboFunctions.ActionReady(ChainSaw))
                return false;
            if (!CustomComboFunctions.ActionReady(Wildfire))
                return false;
            if (!CustomComboFunctions.ActionReady(BarrelStabilizer))
                return false;

            return true;
        }

        public static bool HasPrePullCooldowns()
        {
            if (CustomComboFunctions.GetRemainingCharges(Reassemble) == 0 && Config.MCH_ST_RotationSelection == 2) return false;

            return true;
        }

        private static uint OpenerLevel => 90;

        public uint PrePullStep = 0;

        public uint OpenerStep = 1;

        public static bool LevelChecked => CustomComboFunctions.LocalPlayer.Level >= OpenerLevel;

        private static bool CanOpener => HasCooldowns() && HasPrePullCooldowns() && LevelChecked;

        private OpenerState currentState = OpenerState.PrePull;

        public OpenerState CurrentState
        {
            get
            {
                return currentState;
            }

            set
            {
                if (value != currentState)
                {
                    if (value == OpenerState.PrePull)
                    {
                        Svc.Log.Debug($"Entered PrePull Opener");
                    }
                    if (value == OpenerState.InOpener) OpenerStep = 1;
                    if (value == OpenerState.OpenerFinished || value == OpenerState.FailedOpener)
                    {
                        if (value == OpenerState.FailedOpener)
                            Svc.Log.Information("Opener Failed");

                        ResetOpener();
                    }
                    if (value == OpenerState.OpenerFinished) Svc.Log.Information("Opener Finished");

                    currentState = value;
                }
            }
        }

        private bool DoPrePullSteps(ref uint actionID)
        {
            if (!LevelChecked) return false;

            if (CanOpener && PrePullStep == 0)
            {
                PrePullStep = 1;
            }

            if (!HasCooldowns())
            {
                PrePullStep = 0;
            }

            if (CurrentState == OpenerState.PrePull && PrePullStep > 0)
            {
                if (Config.MCH_ST_RotationSelection == 0 || Config.MCH_ST_RotationSelection == 1)
                {
                    if (CustomComboFunctions.WasLastAction(HeatedSplitShot) && PrePullStep == 1) CurrentState = OpenerState.InOpener;
                    else if (PrePullStep == 1) actionID = HeatedSplitShot;

                    if (ActionWatching.CombatActions.Count > 2 && CustomComboFunctions.InCombat())
                        CurrentState = OpenerState.FailedOpener;
                }

                if (Config.MCH_ST_RotationSelection == 2)
                {
                    if (CustomComboFunctions.HasEffect(Buffs.Reassembled) && PrePullStep == 1) CurrentState = OpenerState.InOpener;
                    else if (PrePullStep == 1) actionID = Reassemble;

                    if (PrePullStep == 2 && !CustomComboFunctions.HasEffect(Buffs.Reassembled))
                        CurrentState = OpenerState.FailedOpener;

                    if (ActionWatching.CombatActions.Count > 2 && CustomComboFunctions.InCombat())
                        CurrentState = OpenerState.FailedOpener;

                }
                return true;
            }

            PrePullStep = 0;
            return false;
        }

        private bool DoOpener(ref uint actionID)
        {
            if (!LevelChecked) return false;

            if (currentState == OpenerState.InOpener)
            {
                if (Config.MCH_ST_RotationSelection == 0)
                {
                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 1) OpenerStep++;
                    else if (OpenerStep == 1) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 2) OpenerStep++;
                    else if (OpenerStep == 2) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 3) OpenerStep++;
                    else if (OpenerStep == 3) actionID = Drill;

                    if (CustomComboFunctions.WasLastAction(BarrelStabilizer) && OpenerStep == 4) OpenerStep++;
                    else if (OpenerStep == 4) actionID = BarrelStabilizer;

                    if (CustomComboFunctions.WasLastAction(HeatedSlugshot) && OpenerStep == 5) OpenerStep++;
                    else if (OpenerStep == 5) actionID = HeatedSlugshot;

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 6) OpenerStep++;
                    else if (OpenerStep == 6) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(HeatedCleanShot) && OpenerStep == 7) OpenerStep++;
                    else if (OpenerStep == 7) actionID = HeatedCleanShot;

                    if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 8) OpenerStep++;
                    else if (OpenerStep == 8) actionID = Reassemble;

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 9) OpenerStep++;
                    else if (OpenerStep == 9) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(AirAnchor) && OpenerStep == 10) OpenerStep++;
                    else if (OpenerStep == 10) actionID = AirAnchor;

                    if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 11) OpenerStep++;
                    else if (OpenerStep == 11) actionID = Reassemble;

                    if (CustomComboFunctions.WasLastAction(Wildfire) && OpenerStep == 12) OpenerStep++;
                    else if (OpenerStep == 12) actionID = Wildfire;

                    if (CustomComboFunctions.WasLastAction(ChainSaw) && OpenerStep == 13) OpenerStep++;
                    else if (OpenerStep == 13) actionID = ChainSaw;

                    if (CustomComboFunctions.WasLastAction(AutomatonQueen) && OpenerStep == 14) OpenerStep++;
                    else if (OpenerStep == 14) actionID = AutomatonQueen;

                    if (CustomComboFunctions.WasLastAction(Hypercharge) && OpenerStep == 15) OpenerStep++;
                    else if (OpenerStep == 15) actionID = Hypercharge;

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 4 && OpenerStep == 16) OpenerStep++;
                    else if (OpenerStep == 16) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 17) OpenerStep++;
                    else if (OpenerStep == 17) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 3 && OpenerStep == 18) OpenerStep++;
                    else if (OpenerStep == 18) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 19) OpenerStep++;
                    else if (OpenerStep == 19) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 2 && OpenerStep == 20) OpenerStep++;
                    else if (OpenerStep == 20) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 21) OpenerStep++;
                    else if (OpenerStep == 21) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 1 && OpenerStep == 22) OpenerStep++;
                    else if (OpenerStep == 22) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 23) OpenerStep++;
                    else if (OpenerStep == 23) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 0 && OpenerStep == 24) OpenerStep++;
                    else if (OpenerStep == 24) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 25) OpenerStep++;
                    else if (OpenerStep == 25) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 26) CurrentState = OpenerState.OpenerFinished;
                    else if (OpenerStep == 26) actionID = Drill;

                    if (ActionWatching.TimeSinceLastAction.TotalSeconds >= 5)
                        CurrentState = OpenerState.FailedOpener;

                    if (((actionID == OriginalHook(Ricochet) && CustomComboFunctions.GetRemainingCharges(OriginalHook(Ricochet)) < 3) ||
                            (actionID == ChainSaw && CustomComboFunctions.IsOnCooldown(ChainSaw)) ||
                            (actionID == Wildfire && CustomComboFunctions.IsOnCooldown(Wildfire)) ||
                            (actionID == BarrelStabilizer && CustomComboFunctions.IsOnCooldown(BarrelStabilizer)) ||
                            (actionID == OriginalHook(GaussRound) && CustomComboFunctions.GetRemainingCharges(OriginalHook(GaussRound)) < 3)) && ActionWatching.TimeSinceLastAction.TotalSeconds >= 3)
                    {
                        CurrentState = OpenerState.FailedOpener;
                        return false;
                    }
                }

                else if (Config.MCH_ST_RotationSelection == 1)
                {
                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 1) OpenerStep++;
                    else if (OpenerStep == 1) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 2) OpenerStep++;
                    else if (OpenerStep == 2) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(HeatedSlugshot) && OpenerStep == 3) OpenerStep++;
                    else if (OpenerStep == 3) actionID = HeatedSlugshot;

                    if (CustomComboFunctions.WasLastAction(BarrelStabilizer) && OpenerStep == 4) OpenerStep++;
                    else if (OpenerStep == 4) actionID = BarrelStabilizer;

                    if (CustomComboFunctions.WasLastAction(HeatedCleanShot) && OpenerStep == 5) OpenerStep++;
                    else if (OpenerStep == 5) actionID = HeatedCleanShot;

                    if (CustomComboFunctions.WasLastAction(AirAnchor) && OpenerStep == 6) OpenerStep++;
                    else if (OpenerStep == 6) actionID = AirAnchor;

                    if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 7) OpenerStep++;
                    else if (OpenerStep == 7) actionID = Reassemble;

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 8) OpenerStep++;
                    else if (OpenerStep == 8) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 9) OpenerStep++;
                    else if (OpenerStep == 9) actionID = Drill;

                    if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 10) OpenerStep++;
                    else if (OpenerStep == 10) actionID = Reassemble;

                    if (CustomComboFunctions.WasLastAction(Wildfire) && OpenerStep == 11) OpenerStep++;
                    else if (OpenerStep == 11) actionID = Wildfire;

                    if (CustomComboFunctions.WasLastAction(ChainSaw) && OpenerStep == 12) OpenerStep++;
                    else if (OpenerStep == 12) actionID = ChainSaw;

                    if (CustomComboFunctions.WasLastAction(AutomatonQueen) && OpenerStep == 13) OpenerStep++;
                    else if (OpenerStep == 13) actionID = AutomatonQueen;

                    if (CustomComboFunctions.WasLastAction(Hypercharge) && OpenerStep == 14) OpenerStep++;
                    else if (OpenerStep == 14) actionID = Hypercharge;

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 4 && OpenerStep == 15) OpenerStep++;
                    else if (OpenerStep == 15) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 16) OpenerStep++;
                    else if (OpenerStep == 16) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 3 && OpenerStep == 17) OpenerStep++;
                    else if (OpenerStep == 17) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 18) OpenerStep++;
                    else if (OpenerStep == 18) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 2 && OpenerStep == 19) OpenerStep++;
                    else if (OpenerStep == 19) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 20) OpenerStep++;
                    else if (OpenerStep == 20) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 1 && OpenerStep == 21) OpenerStep++;
                    else if (OpenerStep == 21) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 22) OpenerStep++;
                    else if (OpenerStep == 22) actionID = OriginalHook(GaussRound);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 0 && OpenerStep == 23) OpenerStep++;
                    else if (OpenerStep == 23) actionID = OriginalHook(HeatBlast);

                    if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 24) OpenerStep++;
                    else if (OpenerStep == 24) actionID = OriginalHook(Ricochet);

                    if (CustomComboFunctions.WasLastAction(HeatedSplitShot) && OpenerStep == 25) CurrentState = OpenerState.OpenerFinished;
                    else if (OpenerStep == 25) actionID = HeatedSplitShot;

                    if (ActionWatching.TimeSinceLastAction.TotalSeconds >= 5)
                        CurrentState = OpenerState.FailedOpener;

                    if (((actionID == OriginalHook(Ricochet) && CustomComboFunctions.GetRemainingCharges(OriginalHook(Ricochet)) < 3) ||
                            (actionID == ChainSaw && CustomComboFunctions.IsOnCooldown(ChainSaw)) ||
                            (actionID == Wildfire && CustomComboFunctions.IsOnCooldown(Wildfire)) ||
                            (actionID == BarrelStabilizer && CustomComboFunctions.IsOnCooldown(BarrelStabilizer)) ||
                            (actionID == OriginalHook(GaussRound) && CustomComboFunctions.GetRemainingCharges(OriginalHook(GaussRound)) < 3)) && ActionWatching.TimeSinceLastAction.TotalSeconds >= 3)
                    {
                        CurrentState = OpenerState.FailedOpener;
                        return false;
                    }
                }

                else
                {
                    if (CustomComboFunctions.LocalPlayer.Level == 100)
                    {
                        if (CustomComboFunctions.WasLastAction(AirAnchor) && OpenerStep == 1) OpenerStep++;
                        else if (OpenerStep == 1) actionID = AirAnchor;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 2) OpenerStep++;
                        else if (OpenerStep == 2) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 3) OpenerStep++;
                        else if (OpenerStep == 3) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 4) OpenerStep++;
                        else if (OpenerStep == 4) actionID = Drill;

                        if (CustomComboFunctions.WasLastAction(BarrelStabilizer) && OpenerStep == 5) OpenerStep++;
                        else if (OpenerStep == 5) actionID = BarrelStabilizer;

                        if (CustomComboFunctions.WasLastAction(ChainSaw) && OpenerStep == 6) OpenerStep++;
                        else if (OpenerStep == 6) actionID = ChainSaw;

                        if (CustomComboFunctions.WasLastAction(Excevator) && OpenerStep == 7) OpenerStep++;
                        else if (OpenerStep == 7) actionID = Excevator;

                        if (CustomComboFunctions.WasLastAction(AutomatonQueen) && OpenerStep == 8) OpenerStep++;
                        else if (OpenerStep == 8) actionID = AutomatonQueen;

                        if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 9) OpenerStep++;
                        else if (OpenerStep == 9) actionID = Reassemble;

                        if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 10) OpenerStep++;
                        else if (OpenerStep == 10) actionID = Drill;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 11) OpenerStep++;
                        else if (OpenerStep == 11) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(Wildfire) && OpenerStep == 12) OpenerStep++;
                        else if (OpenerStep == 12) actionID = Wildfire;

                        if (CustomComboFunctions.WasLastAction(FullMetalField) && OpenerStep == 13) OpenerStep++;
                        else if (OpenerStep == 13) actionID = FullMetalField;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 14) OpenerStep++;
                        else if (OpenerStep == 14) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(Hypercharge) && OpenerStep == 15) OpenerStep++;
                        else if (OpenerStep == 15) actionID = Hypercharge;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 4 && OpenerStep == 16) OpenerStep++;
                        else if (OpenerStep == 16) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 17) OpenerStep++;
                        else if (OpenerStep == 17) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 3 && OpenerStep == 18) OpenerStep++;
                        else if (OpenerStep == 18) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 19) OpenerStep++;
                        else if (OpenerStep == 19) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 2 && OpenerStep == 20) OpenerStep++;
                        else if (OpenerStep == 20) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 21) OpenerStep++;
                        else if (OpenerStep == 21) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 1 && OpenerStep == 22) OpenerStep++;
                        else if (OpenerStep == 22) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 23) OpenerStep++;
                        else if (OpenerStep == 23) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 0 && OpenerStep == 24) CurrentState = OpenerState.OpenerFinished;
                        else if (OpenerStep == 24) actionID = OriginalHook(HeatBlast);
                    }
                    else
                    {
                        if (CustomComboFunctions.WasLastAction(AirAnchor) && OpenerStep == 1) OpenerStep++;
                        else if (OpenerStep == 1) actionID = AirAnchor;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 2) OpenerStep++;
                        else if (OpenerStep == 2) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 3) OpenerStep++;
                        else if (OpenerStep == 3) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 4) OpenerStep++;
                        else if (OpenerStep == 4) actionID = Drill;

                        if (CustomComboFunctions.WasLastAction(BarrelStabilizer) && OpenerStep == 5) OpenerStep++;
                        else if (OpenerStep == 5) actionID = BarrelStabilizer;

                        if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 6) OpenerStep++;
                        else if (OpenerStep == 6) actionID = Reassemble;

                        if (CustomComboFunctions.WasLastAction(ChainSaw) && OpenerStep == 7) OpenerStep++;
                        else if (OpenerStep == 7) actionID = ChainSaw;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 8) OpenerStep++;
                        else if (OpenerStep == 8) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 9) OpenerStep++;
                        else if (OpenerStep == 9) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(HeatedSplitShot) && OpenerStep == 10) OpenerStep++;
                        else if (OpenerStep == 10) actionID = HeatedSplitShot;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 11) OpenerStep++;
                        else if (OpenerStep == 11) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(HeatedSlugshot) && OpenerStep == 12) OpenerStep++;
                        else if (OpenerStep == 12) actionID = HeatedSlugshot;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 13) OpenerStep++;
                        else if (OpenerStep == 13) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(Wildfire) && OpenerStep == 14) OpenerStep++;
                        else if (OpenerStep == 14) actionID = Wildfire;

                        if (CustomComboFunctions.WasLastAction(HeatedCleanShot) && OpenerStep == 15) OpenerStep++;
                        else if (OpenerStep == 15) actionID = HeatedCleanShot;

                        if (CustomComboFunctions.WasLastAction(AutomatonQueen) && OpenerStep == 16) OpenerStep++;
                        else if (OpenerStep == 16) actionID = AutomatonQueen;

                        if (CustomComboFunctions.WasLastAction(Hypercharge) && OpenerStep == 17) OpenerStep++;
                        else if (OpenerStep == 17) actionID = Hypercharge;

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 4 && OpenerStep == 18) OpenerStep++;
                        else if (OpenerStep == 18) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 19) OpenerStep++;
                        else if (OpenerStep == 19) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 3 && OpenerStep == 20) OpenerStep++;
                        else if (OpenerStep == 20) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 21) OpenerStep++;
                        else if (OpenerStep == 21) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 2 && OpenerStep == 22) OpenerStep++;
                        else if (OpenerStep == 22) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 23) OpenerStep++;
                        else if (OpenerStep == 23) actionID = OriginalHook(GaussRound);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 1 && OpenerStep == 24) OpenerStep++;
                        else if (OpenerStep == 24) actionID = OriginalHook(HeatBlast);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 25) OpenerStep++;
                        else if (OpenerStep == 25) actionID = OriginalHook(Ricochet);

                        if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 0 && OpenerStep == 26) CurrentState = OpenerState.OpenerFinished;
                        else if (OpenerStep == 26) actionID = OriginalHook(HeatBlast);
                    }
              
                }

                if (ActionWatching.TimeSinceLastAction.TotalSeconds >= 5)
                    CurrentState = OpenerState.FailedOpener;

                if (((actionID == OriginalHook(Ricochet) && CustomComboFunctions.GetRemainingCharges(OriginalHook(Ricochet)) < 3) ||
                        (actionID == ChainSaw && CustomComboFunctions.IsOnCooldown(ChainSaw)) ||
                        (actionID == Wildfire && CustomComboFunctions.IsOnCooldown(Wildfire)) ||
                        (actionID == BarrelStabilizer && CustomComboFunctions.IsOnCooldown(BarrelStabilizer)) ||
                        (actionID == OriginalHook(GaussRound) && CustomComboFunctions.GetRemainingCharges(OriginalHook(GaussRound)) < 3)) && ActionWatching.TimeSinceLastAction.TotalSeconds >= 3)
                {
                    CurrentState = OpenerState.FailedOpener;
                    return false;
                }

                return true;
            }

            return false;
        }

        private uint OriginalHook(uint id)
        {
            return CustomComboFunctions.OriginalHook(id);
        }

        private bool DoOpenerSimple(ref uint actionID)
        {
            if (!LevelChecked) return false;

            if (currentState == OpenerState.InOpener)
            {
                if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 1) OpenerStep++;
                else if (OpenerStep == 1) actionID = OriginalHook(GaussRound);

                if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 2) OpenerStep++;
                else if (OpenerStep == 2) actionID = OriginalHook(Ricochet);

                if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 3) OpenerStep++;
                else if (OpenerStep == 3) actionID = Drill;

                if (CustomComboFunctions.WasLastAction(BarrelStabilizer) && OpenerStep == 4) OpenerStep++;
                else if (OpenerStep == 4) actionID = BarrelStabilizer;

                if (CustomComboFunctions.WasLastAction(HeatedSlugshot) && OpenerStep == 5) OpenerStep++;
                else if (OpenerStep == 5) actionID = HeatedSlugshot;

                if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 6) OpenerStep++;
                else if (OpenerStep == 6) actionID = OriginalHook(Ricochet);

                if (CustomComboFunctions.WasLastAction(HeatedCleanShot) && OpenerStep == 7) OpenerStep++;
                else if (OpenerStep == 7) actionID = HeatedCleanShot;

                if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 8) OpenerStep++;
                else if (OpenerStep == 8) actionID = Reassemble;

                if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 9) OpenerStep++;
                else if (OpenerStep == 9) actionID = OriginalHook(GaussRound);

                if (CustomComboFunctions.WasLastAction(AirAnchor) && OpenerStep == 10) OpenerStep++;
                else if (OpenerStep == 10) actionID = AirAnchor;

                if (CustomComboFunctions.WasLastAction(Reassemble) && OpenerStep == 11) OpenerStep++;
                else if (OpenerStep == 11) actionID = Reassemble;

                if (CustomComboFunctions.WasLastAction(Wildfire) && OpenerStep == 12) OpenerStep++;
                else if (OpenerStep == 12) actionID = Wildfire;

                if (CustomComboFunctions.WasLastAction(ChainSaw) && OpenerStep == 13) OpenerStep++;
                else if (OpenerStep == 13) actionID = ChainSaw;

                if (CustomComboFunctions.WasLastAction(AutomatonQueen) && OpenerStep == 14) OpenerStep++;
                else if (OpenerStep == 14) actionID = AutomatonQueen;

                if (CustomComboFunctions.WasLastAction(Hypercharge) && OpenerStep == 15) OpenerStep++;
                else if (OpenerStep == 15) actionID = Hypercharge;

                if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 4 && OpenerStep == 16) OpenerStep++;
                else if (OpenerStep == 16) actionID = OriginalHook(HeatBlast);

                if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 17) OpenerStep++;
                else if (OpenerStep == 17) actionID = OriginalHook(Ricochet);

                if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 3 && OpenerStep == 18) OpenerStep++;
                else if (OpenerStep == 18) actionID = OriginalHook(HeatBlast);

                if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 19) OpenerStep++;
                else if (OpenerStep == 19) actionID = OriginalHook(GaussRound);

                if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 2 && OpenerStep == 20) OpenerStep++;
                else if (OpenerStep == 20) actionID = OriginalHook(HeatBlast);

                if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 21) OpenerStep++;
                else if (OpenerStep == 21) actionID = OriginalHook(Ricochet);

                if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 1 && OpenerStep == 22) OpenerStep++;
                else if (OpenerStep == 22) actionID = OriginalHook(HeatBlast);

                if (CustomComboFunctions.WasLastAction(OriginalHook(GaussRound)) && OpenerStep == 23) OpenerStep++;
                else if (OpenerStep == 23) actionID = OriginalHook(GaussRound);

                if (CustomComboFunctions.WasLastAction(OriginalHook(HeatBlast)) && CustomComboFunctions.GetBuffStacks(Buffs.Overheated) == 0 && OpenerStep == 24) OpenerStep++;
                else if (OpenerStep == 24) actionID = OriginalHook(HeatBlast);

                if (CustomComboFunctions.WasLastAction(OriginalHook(Ricochet)) && OpenerStep == 25) OpenerStep++;
                else if (OpenerStep == 25) actionID = OriginalHook(Ricochet);

                if (CustomComboFunctions.WasLastAction(Drill) && OpenerStep == 26) CurrentState = OpenerState.OpenerFinished;
                else if (OpenerStep == 26) actionID = Drill;

                if (ActionWatching.TimeSinceLastAction.TotalSeconds >= 5)
                    CurrentState = OpenerState.FailedOpener;

                if (((actionID == OriginalHook(Ricochet) && CustomComboFunctions.GetRemainingCharges(OriginalHook(Ricochet)) < 3) ||
                        (actionID == ChainSaw && CustomComboFunctions.IsOnCooldown(ChainSaw)) ||
                        (actionID == Wildfire && CustomComboFunctions.IsOnCooldown(Wildfire)) ||
                        (actionID == BarrelStabilizer && CustomComboFunctions.IsOnCooldown(BarrelStabilizer)) ||
                        (actionID == OriginalHook(GaussRound) && CustomComboFunctions.GetRemainingCharges(OriginalHook(GaussRound)) < 3)) && ActionWatching.TimeSinceLastAction.TotalSeconds >= 3)
                {
                    CurrentState = OpenerState.FailedOpener;
                    return false;
                }

                return true;
            }
            return false;
        }

        private void ResetOpener()
        {
            PrePullStep = 0;
            OpenerStep = 0;
        }

        public bool DoFullOpener(bool simpleMode, out uint openerId)
        {
            openerId = 0;
            if (!LevelChecked) return false;

            if (CurrentState == OpenerState.PrePull)
                if (DoPrePullSteps(ref openerId)) return true;

            if (CurrentState == OpenerState.InOpener)
            {
                if (simpleMode)
                {
                    if (DoOpenerSimple(ref openerId)) return true;
                }
                else
                {
                    if (DoOpener(ref openerId)) return true;
                }
            }

            if (!CustomComboFunctions.InCombat())
            {
                ResetOpener();
                CurrentState = OpenerState.PrePull;
            }


            return false;
        }
    }
}