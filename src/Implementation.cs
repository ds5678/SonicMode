using UnityEngine;
using MelonLoader;
using System.IO;

namespace SonicMode
{
    public class Implementation : MelonMod
    {
        internal static bool first_run = true;
        internal static float initial_recovery = 0f;
        internal static float initial_seconds_before_recovery = 0f;

        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}