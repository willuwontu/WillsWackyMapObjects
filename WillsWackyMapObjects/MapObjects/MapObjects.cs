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
    public class Water : SpatialMapObject, IUpgradable<MapObjectData>
    {
        public MapObjectData Upgrade()
        {
            WaterData data = new WaterData();
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    [MapObjectSpec(typeof(Water))]
    public static class WaterSpec
    {
        [MapObjectPrefab]
        public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        [MapObjectSerializer]
        public static void Serialize(GameObject instance, Water target)
        {
            SpatialSerializer.Serialize(instance, target);
        }

        [MapObjectDeserializer]
        public static void Deserialize(Water data, GameObject target)
        {
            SpatialSerializer.Deserialize(data, target);
            target.GetOrAddComponent<WaterMono>();
        }
    }

    #endregion

    #region Acid
    [Obsolete("Legacy map object")]
    public class Acid : SpatialMapObject, IUpgradable<MapObjectData>
    {
        public MapObjectData Upgrade()
        {
            AcidData data = new AcidData();
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    [MapObjectSpec(typeof(Acid))]
    public static class AcidSpec
    {
        [MapObjectPrefab]
        public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        [MapObjectSerializer]
        public static void Serialize(GameObject instance, Acid target)
        {
            SpatialSerializer.Serialize(instance, target);
        }

        [MapObjectDeserializer]
        public static void Deserialize(Acid data, GameObject target)
        {
            SpatialSerializer.Deserialize(data, target);
            target.GetOrAddComponent<AcidMono>();
        }
    }

    #endregion

    #region Lava
    [Obsolete("Legacy map object")]
    public class Lava : SpatialMapObject, IUpgradable<MapObjectData>
    {
        public MapObjectData Upgrade()
        {
            LavaData data = new LavaData();
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    [MapObjectSpec(typeof(Lava))]
    public static class LavaSpec
    {
        [MapObjectPrefab]
        public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        [MapObjectSerializer]
        public static void Serialize(GameObject instance, Lava target)
        {
            SpatialSerializer.Serialize(instance, target);
        }

        [MapObjectDeserializer]
        public static void Deserialize(Lava data, GameObject target)
        {
            SpatialSerializer.Deserialize(data, target);
            target.GetOrAddComponent<LavaMono>();
        }
    }

    #endregion

    #region Space
    [Obsolete("Legacy map object")]
    public class Space : SpatialMapObject, IUpgradable<MapObjectData>
    {
        public MapObjectData Upgrade()
        {
            SpaceData data = new SpaceData();
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    [MapObjectSpec(typeof(Space))]
    public static class SpaceSpec
    {
        [MapObjectPrefab]
        public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        [MapObjectSerializer]
        public static void Serialize(GameObject instance, Space target)
        {
            SpatialSerializer.Serialize(instance, target);
        }

        [MapObjectDeserializer]
        public static void Deserialize(Space data, GameObject target)
        {
            SpatialSerializer.Deserialize(data, target);
            target.GetOrAddComponent<SpaceMono>();
        }
    }

    #endregion

    #region ForceZone

    [Obsolete("Legacy map object")]
    public class ForceZone : SpatialMapObject, IUpgradable<MapObjectData>
    {
        public MapObjectData Upgrade()
        {
            ForceZoneData data = new ForceZoneData();
            data.Position = this.position;
            data.Scale = this.scale;
            data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
            return data;
        }
    }

    [MapObjectSpec(typeof(ForceZone))]
    public static class ForceZoneSpec
    {
        [MapObjectPrefab]
        public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        [MapObjectSerializer]
        public static void Serialize(GameObject instance, ForceZone target)
        {
            SpatialSerializer.Serialize(instance, target);
        }

        [MapObjectDeserializer]
        public static void Deserialize(ForceZone data, GameObject target)
        {
            SpatialSerializer.Deserialize(data, target);
            target.GetOrAddComponent<ForceZoneMono>();
        }
    }

    #endregion

    #endregion 
}