using System;
using MapsExt;
using MapsExt.Compatibility;
using MapsExt.MapObjects;
using MapsExt.Properties;
using UnboundLib;
using UnityEngine;
using WWMO.MapObjects;

namespace ExtraMapObjects
{
    #region Static

    public class MapObjects
    {
        [Obsolete("Legacy map object")]
        public class Red : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Green : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Blue : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Yellow : IUpgradable<MapObjectData>
        {
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
                data.Color = Color.yellow * 0.8f;
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Purple : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Orange : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Brown : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Pink : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Cyan : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Black : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class White : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class Grey : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }

        #endregion

        #region Dynamic objects
        [Obsolete("Legacy map object")]
        public class RedPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreenPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BluePhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class YellowPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PurplePhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class OrangePhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BrownPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class PinkPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class CyanPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class BlackPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class WhitePhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }
        [Obsolete("Legacy map object")]
        public class GreyPhys : IUpgradable<MapObjectData>
        {
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
                return data;
            }
        }

        #endregion


        #region PhysBackg
        [Obsolete("Legacy map object")]
        public class RedPhysBackg : IUpgradable<MapObjectData>
        {
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