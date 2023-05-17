using MapsExt.MapObjects;
using MapsExt.Editor;
using MapsExt.Editor.MapObjects;
using UnityEngine;

namespace WWMO.MapObjects
{
    #region Water Objects
    #region Water

    [EditorMapObjectSpec(typeof(MapObjects.Water), "Water", "Liquids")]
    public static class EditorWater
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.WaterSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Water> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Water>(MapObjects.WaterSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Water> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Water>(MapObjects.WaterSpec.Deserialize);
    }

    #endregion

    #region Acid

    [EditorMapObjectSpec(typeof(MapObjects.Acid), "Acid", "Liquids")]
    public static class EditorAcid
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.AcidSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Acid> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Acid>(MapObjects.AcidSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Acid> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Acid>(MapObjects.AcidSpec.Deserialize);
    }

    #endregion

    #region Lava

    [EditorMapObjectSpec(typeof(MapObjects.Lava), "Lava", "Liquids")]
    public static class EditorLava
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.LavaSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Lava> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Lava>(MapObjects.LavaSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Lava> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Lava>(MapObjects.LavaSpec.Deserialize);
    }

    #endregion

    #region Space

    [EditorMapObjectSpec(typeof(MapObjects.Space), "Space", "Liquids")]
    public static class EditorSpace
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.SpaceSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.Space> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.Space>(MapObjects.SpaceSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.Space> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.Space>(MapObjects.SpaceSpec.Deserialize);
    }

    #endregion

    #region Space

    [EditorMapObjectSpec(typeof(MapObjects.ForceZone), "Force Zone", "Liquids")]
    public static class EditorForceZone
    {
        [EditorMapObjectPrefab] public static GameObject Prefab => MapObjects.ForceZoneSpec.Prefab;

        [EditorMapObjectSerializer]
        public static SerializerAction<MapObjects.ForceZone> Serialize => EditorSpatialSerializer.BuildSerializer<MapObjects.ForceZone>(MapObjects.ForceZoneSpec.Serialize);

        [EditorMapObjectDeserializer]
        public static DeserializerAction<MapObjects.ForceZone> Deserialize => EditorSpatialSerializer.BuildDeserializer<MapObjects.ForceZone>(MapObjects.ForceZoneSpec.Deserialize);
    }

    #endregion
    #endregion
}