using System;
using BepInEx;
using BepInEx.Configuration;

namespace LCProSettings.Wrappers
{
    public static class ConfigManager
    {
        #region Settings
        public static ConfigEntry<bool> InfiniteSprint;
        public static ConfigEntry<float> SprintMultiplier;
        #endregion

        public static void Initialize() {
            //Assigning the values of config settings and pushing 
            //them to (GUID).cfg file under BepInEx/config

            InfiniteSprint = Plugin._instance.Config.Bind("Movement Cheats",
            "Infinite Sprint",
            true,
            "A true of false value for enabling infinite sprint and stamina");

            SprintMultiplier = Plugin._instance.Config.Bind("Movement Cheats",
            "Speed Multiplier",
            1f,
            "A speed multiplier that is based off the default speeds");
        }
    }
}
