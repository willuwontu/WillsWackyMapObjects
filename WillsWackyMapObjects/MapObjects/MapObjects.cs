using System;
using MapsExt;
using MapsExt.Compatibility;
using MapsExt.MapObjects;
using MapsExt.Properties;
using UnboundLib;
using UnityEngine;
using UnityEngine.Serialization;
using WWMO.MonoBehaviours;

namespace WWMO.MapObjects
{
    #region Liquids
    #region Water
    [Obsolete("Legacy map object")]
    public class Water
    {
        [FormerlySerializedAs("_active")]
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;

        public static implicit operator WaterData(Water source)
        {
            WaterData data = new WaterData();
            data.Active = source.active;
            data.Position = source.position;
            data.Scale = source.scale;
            data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Acid
    [Obsolete("Legacy map object")]
    public class Acid
    {
        [FormerlySerializedAs("_active")]
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public static implicit operator AcidData(Acid source)
        {
            AcidData data = new AcidData();
            data.Active = source.active;
            data.Position = source.position;
            data.Scale = source.scale;
            data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Lava
    [Obsolete("Legacy map object")]
    public class Lava
    {
        [FormerlySerializedAs("_active")]
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public static implicit operator LavaData(Lava source)
        {
            LavaData data = new LavaData();
            data.Active = source.active;
            data.Position = source.position;
            data.Scale = source.scale;
            data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region Space
    [Obsolete("Legacy map object")]
    public class Space
    {
        [FormerlySerializedAs("_active")]
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public static implicit operator SpaceData(Space source)
        {
            SpaceData data = new SpaceData();
            data.Active = source.active;
            data.Position = source.position;
            data.Scale = source.scale;
            data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #region ForceZone

    [Obsolete("Legacy map object")]
    public class ForceZone
    {
        [FormerlySerializedAs("_active")]
        public bool active;
        public Vector3 position;
        public Vector3 scale;
        public Quaternion rotation;
        public static implicit operator ForceZoneData(ForceZone source)
        {
            ForceZoneData data = new ForceZoneData();
            data.Active = source.active;
            data.Position = source.position;
            data.Scale = source.scale;
            data.Rotation = new RotationProperty(source.rotation.eulerAngles.z);
            return data;
        }
    }

    #endregion

    #endregion 
}