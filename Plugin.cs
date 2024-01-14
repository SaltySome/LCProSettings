using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LCProSettings.GameObjects;
using System.Runtime.CompilerServices;
using UnityEngine;

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

        private GUIManager _gUIManager;

        private void Awake()
        {
            HandleInstance(this);
            HandleLogSource();

            LogSource.LogInfo(_MOD_NAME + " has succesfully started");
            LogSource.LogInfo("Does this show up in github");

            InstanceGUI(this);
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

        private static void InstanceGUI(Plugin sender)
        {
            var gameObject = new GameObject("GUIManager");
            DontDestroyOnLoad(gameObject);
            gameObject.hideFlags = HideFlags.HideAndDontSave;
            gameObject.AddComponent<GUIManager>();
            sender._gUIManager = (GUIManager)gameObject.GetComponent("GUIManager");
        }

        #endregion
    }
}
