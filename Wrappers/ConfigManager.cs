using System;
using BepinEx;
using BepinEx.Configuration;

public namespace LCProSettings.Wrappers
public class ConfigManager
{
    #region Settings
    public ConfigEntry<bool> InfiniteSprint;
    public ConfigEntry<float> SprintMultiplier;
    #endregion

    public ConfigManager() {
        //Assigning the values of config settings and pushing 
        //them to (GUID).cfg file under BepInEx/config
        
        InfiniteSprint = Config.Bind("Movement Cheats",
        "Infinite Sprint",
        true,
        "A true of false value for enabling infinite sprint and stamina");

        SprintMultiplier = Config.Bind("Movement Cheats",
        "Speed Multiplier",
        1f,
        "A speed multiplier that is based off the default speeds");
    }
}