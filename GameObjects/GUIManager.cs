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
        private GUICanvas _gUICanvas;
        private void Awake()
        {
            _gUICanvas = new GUICanvas();
        }
        public void OnGUI()
        {
            //TODO: Add function calls to GUICanvas to reactively render the config GUI
        }
    }
}
