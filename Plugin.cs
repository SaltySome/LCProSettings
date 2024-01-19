using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections.Generic;
using LCProSettings.Wrappers;
using System;
using System.CodeDom;

namespace LCProSettings
{
    [BepInPlugin(_MOD_GUID, _MOD_NAME, _MOD_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private const string _MOD_GUID = "SaltySome.LCProSettings";
        private const string _MOD_NAME = "LC Pro Settings";
        private const string _MOD_VERSION = "1.0.0.0";

        

        private readonly Harmony _harmony = new Harmony(_MOD_GUID);

        internal static Plugin _instance;

        public static ManualLogSource LogSource;

        private void Awake()
        {
            HandleInstance(this);
            HandleLogSource();
            ConfigManager.Initialize();
            HarmonyPatches(_instance);
            LogSource.LogInfo(_MOD_NAME + " has succesfully started");
        }

        #region ExtractedMethods

        private static void HandleInstance(Plugin sender)
        {
            if(_instance == null)
            {
                _instance = sender;
                return;
            }
        }

        private static void HandleLogSource()
        {
            LogSource = BepInEx.Logging.Logger.CreateLogSource("   " + _MOD_GUID);
        }

        private static void HarmonyPatches(Plugin sender)
        {
            sender._harmony.PatchAll();
        }
        #endregion
    }
}
