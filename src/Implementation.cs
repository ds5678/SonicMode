﻿using UnityEngine;
using MelonLoader;
using System.IO;

namespace SonicMode
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }
    }
}