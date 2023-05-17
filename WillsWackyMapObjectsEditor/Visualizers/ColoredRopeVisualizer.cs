﻿using MapsExt.Editor.MapObjects;
using UnityEngine.UI.ProceduralImage;
using UnityEngine.UI;
using UnityEngine;
using MapsExt.Visualizers;
using MapsExt;
using WWMO.MapObjectProperties;

namespace WWMO.Visualizers
{
    internal class ColoredRopeVisualizer : RopeVisualizer
    {
        private EditorRope.RopeInstance _rope;
        private LineRenderer _renderer;
        private Graphic _startGraphic;
        private Graphic _endGraphic;

        protected override void Start()
        {
            this._rope = this.gameObject.GetComponent<EditorRope.RopeInstance>();
        }

        protected override void OnEnable()
        {
            this._renderer = this.gameObject.GetComponent<LineRenderer>();
            this._renderer.material = new Material(Shader.Find("Sprites/Default"));

            Color color = new Color(0.039f, 0.039f, 0.039f, 1f);

            try
            {
                color = this.gameObject.ReadProperty<ColorProperty>();
            }
            catch (System.Exception) { }
            
            this._renderer.startColor = color;
            this._renderer.endColor = this._renderer.startColor;
            this._renderer.startWidth = 0.2f;
            this._renderer.endWidth = 0.2f;

            var canvasGo = new GameObject("Canvas");
            canvasGo.transform.SetParent(this.transform);

            var canvas = canvasGo.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            var startVizGo = new GameObject("Rope Start");
            var endVizGo = new GameObject("Rope End");

            startVizGo.transform.SetParent(canvasGo.transform);
            endVizGo.transform.SetParent(canvasGo.transform);

            this._startGraphic = startVizGo.AddComponent<ProceduralImage>();
            this._endGraphic = endVizGo.AddComponent<ProceduralImage>();

            this._startGraphic.rectTransform.sizeDelta = Vector2.one * 10;
            this._endGraphic.rectTransform.sizeDelta = Vector2.one * 10;

            this._startGraphic.color = new Color(1, 1, 1, 0.5f);
            this._endGraphic.color = new Color(1, 1, 1, 0.5f);

            var startModifier = startVizGo.AddComponent<UniformModifier>();
            var endModifier = endVizGo.AddComponent<UniformModifier>();

            startModifier.Radius = 5;
            endModifier.Radius = 5;
        }

        protected override void OnDisable()
        {
            this._renderer = null;
            this._startGraphic = null;
            this._endGraphic = null;
            GameObject.Destroy(this.transform.Find("Canvas").gameObject);
        }

        private void LateUpdate()
        {
            if (!this._renderer || !this._startGraphic || !this._endGraphic)
            {
                return;
            }

            var pos1 = this._rope.GetAnchor(0).transform.position;
            var pos2 = this._rope.GetAnchor(1).transform.position;

            this._renderer.SetPositions(new Vector3[] { pos1, pos2 });
            this._startGraphic.transform.position = MainCam.instance.cam.WorldToScreenPoint(pos1);
            this._endGraphic.transform.position = MainCam.instance.cam.WorldToScreenPoint(pos2);

            this._startGraphic.color = this._rope.GetAnchor(0).IsAttached ? new Color(0, 0.5f, 1) : new Color(1, 1, 1);
            this._endGraphic.color = this._rope.GetAnchor(1).IsAttached ? new Color(0, 0.5f, 1) : new Color(1, 1, 1);
        }
    }
}
