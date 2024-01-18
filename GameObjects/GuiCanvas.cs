using System;
using UnityEngine;
using BepInEx;

namespace LCProSettings.GameObjects
{
    public class GUICanvas : MonoBehaviour
    {
        private Canvas _canvas;
        private Vector2 _position = new Vector2(0.5f, 0.5f);
        public GUICanvas() 
        {
            InstanceCanvas();
            SetCanvasPosition();
        }

        #region HelperMethods
        private void InstanceCanvas()
        {
            GameObject gameObject = new GameObject("ConfigCanva");
            DontDestroyOnLoad(gameObject);
            gameObject.hideFlags = HideFlags.HideAndDontSave;
            gameObject.AddComponent<Canvas>();
            _canvas = gameObject.GetComponent<Canvas>();
        }

        private void SetCanvasPosition()
        {
            _canvas.GetComponent<RectTransform>().anchoredPosition = _position;
        }

        private void SetCanvasPosition(Vector2 position)
        {
            _canvas.GetComponent<RectTransform>().anchoredPosition = position;
        }
        #endregion
    }
}