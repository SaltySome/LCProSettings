using System;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
using BepInEx;
using UnityEngine;

namespace LCProSettings.Wrappers
{
    public static class GUILoader
    {
        private static int BoxWidthPrecent = 50;
        private static int BoxHeightPrecent = 50;
        private static int BoxWidth { get {
            return (Screen.width / (100 / BoxWidthPrecent));
        }}
        private static int BoxHeight { get {
            return (Screen.height / (100 / BoxHeightPrecent));
        }}
        private static int BoxDrawPosX { get {
            return ((Screen.width / 2) - (BoxWidth / 2));
        }}
        private static int BoxDrawPosY { get {
            return ((Screen.height) / 2) - (BoxHeight / 2);
        }}
        private static Rect DrawBoxRect { get {
            return new Rect(BoxDrawPosX, BoxDrawPosY, BoxWidth, BoxHeight);
        }}
        public static void DrawPageOne()
        {
            GUI.Box(DrawBoxRect, "");
        }
    }
}