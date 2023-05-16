using MapsExt.Properties;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WWMO.MapObjectProperties
{
    public class ParticleColorProperty : ValueProperty<Color>
    {
        [SerializeField] private readonly int _r;
        [SerializeField] private readonly int _g;
        [SerializeField] private readonly int _b;
        [SerializeField] private readonly int _a;

        public override Color Value => new Color32((byte)this._r, (byte)this._g, (byte)this._b, (byte)this._a);

        public ParticleColorProperty() : this(100, 100, 100, 255) { }

        public ParticleColorProperty(Color color) : this(Mathf.RoundToInt(color.r * 255), Mathf.RoundToInt(color.g * 255), Mathf.RoundToInt(color.b * 255), Mathf.RoundToInt(color.a * 255)) { }

        public ParticleColorProperty(Color32 color) : this(color.r, color.g, color.b, color.a) { }

        public ParticleColorProperty(int r, int g, int b, int a)
        {
            this._r = r;
            this._g = g;
            this._b = b;
            this._a = a;
        }

        public static implicit operator Color(ParticleColorProperty prop) => prop.Value;
        public static implicit operator Color32(ParticleColorProperty prop) => prop.Value;
        public static implicit operator ParticleColorProperty(Color color) => new ParticleColorProperty(color);
        public static implicit operator ParticleColorProperty(Color32 color32) => new ParticleColorProperty(color32);
    }

    [PropertySerializer(typeof(ParticleColorProperty))]
    public class ParticleColorPropertySerializer : IPropertyWriter<ParticleColorProperty>
    {
        public void WriteProperty(ParticleColorProperty property, GameObject target)
        {
            foreach (ParticleSystem particleSystem in target.GetComponentsInChildren<ParticleSystem>())
            {
                var main = particleSystem.main;

                main.startColor = new ParticleSystem.MinMaxGradient(property.Value/3, property.Value);
            }
        }
    }
}
