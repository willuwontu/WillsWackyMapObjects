using System;
using MapsExt;
using MapsExt.Compatibility;
using MapsExt.MapObjects;
using MapsExt.Properties;
using UnboundLib;
using UnityEngine;
using UnityEngine.Serialization;
using WWMO.MapObjects;

namespace ExtraMapObjects
{
    #region Static

    public class MapObjects
    {
        [Obsolete("Legacy map object")]
        public class Red
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Red data)
            {
                ColoredGroundData result = new ColoredGroundData();
                result.Active = data.active;
                result.Position = data.position;
                result.Scale = data.scale;
                result.Rotation = new RotationProperty(data.rotation.eulerAngles.z);
                result.Color = Color.red * 0.8f;
                Color color = result.Color;
                color.a = 1;
                result.Color = color;
                return result;
            }
        }

        [Obsolete("Legacy map object")]
        public class Green
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Green data)
            {
                ColoredGroundData result = new ColoredGroundData();
                result.Active = data.active;
                result.Position = data.position;
                result.Scale = data.scale;
                result.Rotation = new RotationProperty(data.rotation.eulerAngles.z);
                result.Color = Color.green * 0.8f;
                Color color = result.Color;
                color.a = 1;
                result.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Blue
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Blue data)
            {
                ColoredGroundData result = new ColoredGroundData();
                result.Active = data.active;
                result.Position = data.position;
                result.Scale = data.scale;
                result.Rotation = new RotationProperty(data.rotation.eulerAngles.z);
                result.Color = Color.blue * 0.8f;
                Color color = result.Color;
                color.a = 1;
                result.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Yellow
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Yellow data)
            {
                ColoredGroundData result = new ColoredGroundData();
                result.Active = data.active;
                result.Position = data.position;
                result.Scale = data.scale;
                result.Rotation = new RotationProperty(data.rotation.eulerAngles.z);
                result.Color = Color.yellow * 0.8f;
                Color color = result.Color;
                color.a = 1;
                result.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Purple
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Purple source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Orange
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Orange source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Brown
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Brown source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Pink
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Pink source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Cyan
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Cyan source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Black
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Black source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class White
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(White source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Grey
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredGroundData(Grey source)
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.4f, 0.4f, 0.4f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        #endregion

        #region Dynamic objects
        [Obsolete("Legacy map object")]
        public class RedPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(RedPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = Color.red * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreenPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(GreenPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = Color.green * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BluePhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(BluePhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = Color.blue * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class YellowPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(YellowPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = Color.yellow * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PurplePhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(PurplePhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class OrangePhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(OrangePhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BrownPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(BrownPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PinkPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(PinkPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class CyanPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(CyanPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BlackPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(BlackPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class WhitePhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(WhitePhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreyPhys
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxData(GreyPhys source)
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                data.Color = new Color(0.4f, 0.4f, 0.4f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        #endregion


        #region PhysBackg
        [Obsolete("Legacy map object")]
        public class RedPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(RedPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.red * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreenPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(GreenPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.green * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BluePhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(BluePhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.blue * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class YellowPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(YellowPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PurplePhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(PurplePhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.magenta * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class OrangePhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(OrangePhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BrownPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(BrownPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PinkPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(PinkPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class CyanPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(CyanPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.cyan * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BlackPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(BlackPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.black * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class WhitePhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(WhitePhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.white * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreyPhysBackg
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public static implicit operator ColoredBoxBackgroundData(GreyPhysBackg source)
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = source.active;
                data.Position = source.position;
                data.Scale = source.scale;
                data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
                var color = Color.grey * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        #endregion
    }
}