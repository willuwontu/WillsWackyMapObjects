using MapsExt;
using MapsExt.Editor;
using MapsExt.Editor.Properties;
using MapsExt.Editor.UI;
using MapsExt.Properties;
using System.Collections;
using UnityEngine;

namespace WWMO.MapObjectProperties
{
    [EditorPropertySerializer(typeof(ParticleColorProperty))]
    public class EditorParticleColorPropertySerializer : ParticleColorPropertySerializer, IPropertyReader<ParticleColorProperty>
    {
        public ParticleColorProperty ReadProperty(GameObject instance)
        {
            var main = instance.GetComponentInChildren<ParticleSystem>().main;

            var color = main.startColor.colorMax;

            ParticleColorProperty colorProperty = new ParticleColorProperty(color);

            return colorProperty;
        }
    }

    [InspectorElement(typeof(ParticleColorProperty))]
    public class ParticleColorElement : InspectorElement
    {
        private TextSliderInput _r;
        private TextSliderInput _g;
        private TextSliderInput _b;
        private TextSliderInput _a;

        public Color Value
        {
            get => this.Context.InspectorTarget.ReadProperty<ParticleColorProperty>();
            set => this.OnChange(value, ChangeType.ChangeEnd);
        }

        protected override GameObject GetInstance()
        {
            var instance = GameObject.Instantiate(Assets.FoldoutPrefab);
            var foldout = instance.GetComponent<Foldout>();
            foldout.Label.text = "Particle Color";

            var r = GameObject.Instantiate(Assets.InspectorSliderInputPrefab, foldout.Content.transform);
            var quaternionInput = r.GetComponent<InspectorSliderInput>();
            quaternionInput.Label.text = "R";
            this._r = quaternionInput.Input;
            this._r.Slider.minValue = 0f;
            this._r.Slider.maxValue = 255f;
            this._r.Slider.wholeNumbers = true;
            this._r.OnChanged += this.OnChange;

            var g = GameObject.Instantiate(Assets.InspectorSliderInputPrefab, foldout.Content.transform);
            quaternionInput = g.GetComponent<InspectorSliderInput>();
            quaternionInput.Label.text = "G";
            this._g = quaternionInput.Input;
            this._g.Slider.minValue = 0f;
            this._g.Slider.maxValue = 255f;
            this._g.Slider.wholeNumbers = true;
            this._g.OnChanged += this.OnChange;

            var b = GameObject.Instantiate(Assets.InspectorSliderInputPrefab, foldout.Content.transform);
            quaternionInput = b.GetComponent<InspectorSliderInput>();
            quaternionInput.Label.text = "B";
            this._b = quaternionInput.Input;
            this._b.Slider.minValue = 0f;
            this._b.Slider.maxValue = 255f;
            this._b.Slider.wholeNumbers = true;
            this._b.OnChanged += this.OnChange;

            var a = GameObject.Instantiate(Assets.InspectorSliderInputPrefab, foldout.Content.transform);
            quaternionInput = a.GetComponent<InspectorSliderInput>();
            quaternionInput.Label.text = "A";
            this._a = quaternionInput.Input;
            this._a.Slider.minValue = 0f;
            this._a.Slider.maxValue = 255f;
            this._a.Slider.wholeNumbers = true;
            this._a.OnChanged += this.OnChange;

            return instance;
        }

        public override void OnUpdate()
        {
            this._r.SetWithoutEvent(Mathf.RoundToInt(this.Value.r * 255));
            this._g.SetWithoutEvent(Mathf.RoundToInt(this.Value.g * 255));
            this._b.SetWithoutEvent(Mathf.RoundToInt(this.Value.b * 255));
            this._a.SetWithoutEvent(Mathf.RoundToInt(this.Value.a * 255));
        }

        public void OnChange(Color color, ChangeType changeType)
        {
            if (changeType == ChangeType.Change || changeType == ChangeType.ChangeEnd)
            {
                this.Context.InspectorTarget.WriteProperty<ParticleColorProperty>((Color32)color);
            }

            if (changeType == ChangeType.ChangeEnd)
            {
                this.Context.Editor.TakeSnaphot();
            }
        }

        public void OnChange(float value, ChangeType changeType)
        {
            if (changeType == ChangeType.Change || changeType == ChangeType.ChangeEnd)
            {
                this.Context.InspectorTarget.WriteProperty<ParticleColorProperty>((Color32)new Color(this._r.Value /255, this._g.Value /255, this._b.Value /255, this._a.Value /255));
            }

            if (changeType == ChangeType.ChangeEnd)
            {
                this.Context.Editor.TakeSnaphot();
            }
        }
    }
}
