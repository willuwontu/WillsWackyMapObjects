using System;
using MapsExt;
using MapsExt.Compatibility;
using MapsExt.MapObjects;
using MapsExt.Properties;
using UnboundLib;
using UnityEngine;
using WWMO.MonoBehaviours;

namespace WWMO.MapObjects
{
    #region Liquids
    #region Water
    [Obsolete("Legacy map object")]
    public class Water : IUpgradable<MapObjectData>
    {
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;

        public MapObjectData Upgrade()
        {
            WaterData data = new WaterData();
            data.Active = active;
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Acid
    [Obsolete("Legacy map object")]
    public class Acid : IUpgradable<MapObjectData>
    {
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public MapObjectData Upgrade()
        {
            AcidData data = new AcidData();
            data.Active = active;
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Lava
    [Obsolete("Legacy map object")]
    public class Lava : IUpgradable<MapObjectData>
    {
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public MapObjectData Upgrade()
        {
            LavaData data = new LavaData();
            data.Active = active;
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Space
    [Obsolete("Legacy map object")]
    public class Space : IUpgradable<MapObjectData>
    {
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public MapObjectData Upgrade()
        {
            SpaceData data = new SpaceData();
            data.Active = active;
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region ForceZone

    [Obsolete("Legacy map object")]
    public class ForceZone : IUpgradable<MapObjectData>
    {
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public MapObjectData Upgrade()
        {
            ForceZoneData data = new ForceZoneData();
            data.Active = active;
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #endregion 
}