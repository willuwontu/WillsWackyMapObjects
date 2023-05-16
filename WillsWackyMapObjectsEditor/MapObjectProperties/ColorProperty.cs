using MapsExt;
using MapsExt.Editor;
using MapsExt.Editor.Properties;
using MapsExt.Editor.UI;
using MapsExt.Properties;
using UnityEngine;

namespace WWMO.MapObjectProperties
{
    [EditorPropertySerializer(typeof(ColorProperty))]
    public class EditorColorPropertySerializer : ColorPropertySerializer, IPropertyReader<ColorProperty>
    {
        public ColorProperty ReadProperty(GameObject instance)
        {
            var color = instance.GetComponentInChildren<SpriteRenderer>().color;

            ColorProperty colorProperty = new ColorProperty(color);

            return colorProperty;
        }
    }

    [InspectorElement(typeof(ColorProperty))]
    public class ColorElement : InspectorElement
    {
        private TextSliderInput _r;
        private TextSliderInput _g;
        private TextSliderInput _b;
        private TextSliderInput _a;

        public Color Value
        {
            get => this.Context.InspectorTarget.ReadProperty<ColorProperty>();
            set => this.OnChange(value, ChangeType.ChangeEnd);
        }

        protected override GameObject GetInstance()
        {
            var instance = GameObject.Instantiate(Assets.FoldoutPrefab);
            var foldout = instance.GetComponent<Foldout>();
            foldout.Label.text = "Color";

            var r = GameObject.Instantiate(Assets.InspectorQuaternionPrefab, foldout.Content.transform);
            var quaternionInput = r.GetComponent<InspectorQuaternion>();
            quaternionInput.Label.text = "R";
            this._r = quaternionInput.Input;
            this._r.Slider.minValue = 0;
            this._r.Slider.maxValue = 255;
            this._r.OnChanged += this.OnChange;

            var g = GameObject.Instantiate(Assets.InspectorQuaternionPrefab, foldout.Content.transform);
            quaternionInput = g.GetComponent<InspectorQuaternion>();
            quaternionInput.Label.text = "G";
            this._g = quaternionInput.Input;
            this._g.Slider.minValue = 0;
            this._g.Slider.maxValue = 255;
            this._g.OnChanged += this.OnChange;

            var b = GameObject.Instantiate(Assets.InspectorQuaternionPrefab, foldout.Content.transform);
            quaternionInput = b.GetComponent<InspectorQuaternion>();
            quaternionInput.Label.text = "B";
            this._b = quaternionInput.Input;
            this._b.Slider.minValue = 0;
            this._b.Slider.maxValue = 255;
            this._b.OnChanged += this.OnChange;

            var a = GameObject.Instantiate(Assets.InspectorQuaternionPrefab, foldout.Content.transform);
            quaternionInput = a.GetComponent<InspectorQuaternion>();
            quaternionInput.Label.text = "A";
            this._a = quaternionInput.Input;
            this._a.Slider.minValue = 0;
            this._a.Slider.maxValue = 255;
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
                this.Context.InspectorTarget.WriteProperty<ColorProperty>((Color32)color);
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
                this.Context.InspectorTarget.WriteProperty<ColorProperty>((Color32)new Color(this._r.Value /255, this._g.Value /255, this._b.Value /255, this._a.Value /255));
            }

            if (changeType == ChangeType.ChangeEnd)
            {
                this.Context.Editor.TakeSnaphot();
            }
        }

        //public void OnChange(int r, int g, int b, int a, ChangeType changeType) 
        //{
        //    if (changeType == ChangeType.Change || changeType == ChangeType.ChangeEnd)
        //    {
        //        this.Context.InspectorTarget.WriteProperty<ColorProperty>(new Color32((byte)r, (byte)g, (byte)b, (byte)a));
        //    }

        //    if (changeType == ChangeType.ChangeEnd)
        //    {
        //        this.Context.Editor.TakeSnaphot();
        //    }
        //}

        //public void OnChangeR(float r, ChangeType changeType)
        //{
        //    OnChange(Mathf.RoundToInt(r), Mathf.RoundToInt(this._g.Value * 255), Mathf.RoundToInt(this._b.Value * 255), Mathf.RoundToInt(this._a.Value * 255), changeType);
        //}
        //public void OnChangeG(float g, ChangeType changeType)
        //{
        //    OnChange(Mathf.RoundToInt(this._r.Value * 255), Mathf.RoundToInt(g * 255), Mathf.RoundToInt(this._b.Value * 255), Mathf.RoundToInt(this._a.Value * 255), changeType);
        //}
        //public void OnChangeB(float b, ChangeType changeType)
        //{
        //    OnChange(Mathf.RoundToInt(this._r.Value * 255), Mathf.RoundToInt(this._g.Value * 255), Mathf.RoundToInt(b * 255), Mathf.RoundToInt(this._a.Value * 255), changeType);
        //}
        //public void OnChangeA(float a, ChangeType changeType)
        //{
        //    OnChange(Mathf.RoundToInt(this._r.Value * 255), Mathf.RoundToInt(this._g.Value * 255), Mathf.RoundToInt(this._b.Value * 255), Mathf.RoundToInt(a * 255), changeType);
        //}
    }
}
