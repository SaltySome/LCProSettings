using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LCProSettings.GameObjects
{
    internal class GUIManager : MonoBehaviour
    {
        public void OnGUI()
        {
            UnityEngine.GUI.Box(new Rect(0, 0, 100, 100), new GUIContent("Hello"));
        }
    }
}
