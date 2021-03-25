using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;

namespace SonicMode
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(vp_FPSController),"GetSlopeMultiplier")]
        private static class IncreaseSpeed
        {
            internal static void Postfix(ref float __result)
            {
                if (GameManager.GetPlayerManagerComponent().PlayerIsSprinting())
                {
                    __result *= Settings.options.sprintSpeedMultiplier;
                }
                else if (GameManager.GetPlayerManagerComponent().PlayerIsCrouched())
                {
                    __result *= Settings.options.crouchSpeedMultiplier;
                }
                else __result *= Settings.options.walkSpeedMultiplier;
            }
        }

        [HarmonyPatch(typeof(PlayerMovement), "Update")]
        private static class IncreaseStamina
        {
            internal static void Postfix(PlayerMovement __instance)
            {
                if (Implementation.first_run)
                {
                    Implementation.initial_recovery = __instance.m_SprintStaminaRecoverPerHour;
                    Implementation.initial_seconds_before_recovery = __instance.m_SecondsNotSprintingBeforeRecovery;
                    Implementation.first_run = false;
                }
                __instance.m_SprintStaminaRecoverPerHour = Implementation.initial_recovery * Settings.options.rechargeScalar;
                __instance.m_SecondsNotSprintingBeforeRecovery = Implementation.initial_seconds_before_recovery * Settings.options.secondsScalar;
            }
        }
    }
}
