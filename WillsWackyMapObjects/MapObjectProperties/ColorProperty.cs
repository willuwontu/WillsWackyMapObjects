using MapsExt.Properties;
using System.Collections;
using UnityEngine;

namespace WWMO.MapObjectProperties
{
    public class ColorProperty : ValueProperty<Color>
    {
        [SerializeField] private readonly int _r;
        [SerializeField] private readonly int _g;
        [SerializeField] private readonly int _b;
        [SerializeField] private readonly int _a;

        public override Color Value => new Color32((byte)this._r, (byte)this._g, (byte)this._b, (byte)this._a);

        public ColorProperty() : this(67, 55, 43, 225) { }

        public ColorProperty(Color color) : this(Mathf.RoundToInt(color.r * 255), Mathf.RoundToInt(color.g * 255), Mathf.RoundToInt(color.b * 255), Mathf.RoundToInt(color.a * 255)) { }

        public ColorProperty(Color32 color) : this(color.r, color.g, color.b, color.a) { }

        public ColorProperty(int r, int g, int b, int a)
        {
            this._r = r;
            this._g = g;
            this._b = b;
            this._a = a;
        }

        public static implicit operator Color(ColorProperty prop) => prop.Value;
        public static implicit operator Color32(ColorProperty prop) => prop.Value;
        public static implicit operator ColorProperty(Color color) => new ColorProperty(color);
        public static implicit operator ColorProperty(Color32 color32) => new ColorProperty(color32);
    }

    [PropertySerializer(typeof(ColorProperty))]
    public class ColorPropertySerializer : IPropertyWriter<ColorProperty>
    {
        public void WriteProperty(ColorProperty property, GameObject target)
        {
            foreach (SpriteRenderer spriteRenderer in target.GetComponentsInChildren<SpriteRenderer>())
            {
                spriteRenderer.color = property;
                //WillsWackyMapObjects.instance.StartCoroutine(SetColor(property, spriteRenderer));
            }
        }

        public IEnumerator SetColor(Color color, SpriteRenderer spriteRenderer)
        {
            yield return null;

            spriteRenderer.color = color;

            yield break;
        }
    }
}
