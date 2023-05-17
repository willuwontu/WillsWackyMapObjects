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
        public class Red : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.red * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Green : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.green * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Blue : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.blue * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Yellow : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.yellow * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Purple : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Orange : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Brown : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Pink : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Cyan : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Black : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class White : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Grey : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
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
        public class RedPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.red * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreenPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.green * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BluePhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.blue * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class YellowPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.yellow * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PurplePhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class OrangePhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BrownPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PinkPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class CyanPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BlackPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class WhitePhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreyPhys : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
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
        public class RedPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.red * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreenPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.green * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BluePhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.blue * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class YellowPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PurplePhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.magenta * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class OrangePhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BrownPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PinkPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class CyanPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.cyan * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BlackPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.black * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class WhitePhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.white * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreyPhysBackg : IUpgradable<MapObjectData>
        {
            [FormerlySerializedAs("_active")]
            public bool active;
            public Vector3 position;
            public Vector3 scale;
            public Quaternion rotation;

            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = active;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
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