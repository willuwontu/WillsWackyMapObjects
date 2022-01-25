using System;
using MapsExt;
using MapsExt.MapObjects;
using UnboundLib;
using UnityEngine;
using WWMO.MonoBehaviours;

namespace WWMO.MapObjects
{
    #region Water Objects
    #region Water
    public class Water : SpatialMapObject
    {
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

    public class Acid : SpatialMapObject
    {
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

    public class Lava : SpatialMapObject
    {
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

    public class Space : SpatialMapObject
    {
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
    #endregion
}