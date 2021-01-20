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
                //Debug.Log("Working");
                if (InputManager.GetSprintDown(InputManager.m_CurrentContext))
                {
                    __result *= Settings.options.speedMultiplier;
                }
            }
        }
    }
}
