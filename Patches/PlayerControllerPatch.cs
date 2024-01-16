using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNetcodeStuff;
using HarmonyLib;
using LCProSettings.Wrappers;

namespace LCProSettings.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        private void UpdatePlayerSprintMeter(ref float ___sprintMeter)
        {
            // Updates the "sprintMeter" varriable found in "GameNetcodeStuff" to always
            // be 1f if the player has InfiniteSprint set to true in the config(See "ConfigManager").
            // and otherwise it sets it to the original value and doesn't change it.
            ___sprintMeter = ConfigManager.InfiniteSprint.Value ? 1f : ___sprintMeter;
        }
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        private void UpdatePlayerSpeed(ref float ___sprintMultiplier)
        {
            // Updates the "sprintMultiplier" variable found in "GameNetcodeStuff" to be
            // the value the player puts for the "SprintMultiplier" in the config file(See "ConfigManager")
            // The "sprintMultiplier" is confusingly used when calculating the players movement
            // even for walking and is lerped between 1f for not sprinting and 2.25f for sprinting
            // so that value inputed will not be excatley modled in the game but is pretty close
            // when called every frame.
            
            ___sprintMultiplier = ConfigManager.SprintMultiplier.Value;
        }
    }
}
