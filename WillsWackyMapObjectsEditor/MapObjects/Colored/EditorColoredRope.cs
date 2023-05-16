using MapsExt;
using MapsExt.Editor.MapObjects;
using MapsExt.Visualizers;
using UnboundLib;
using UnityEngine;
using WWMO.MapObjects;

namespace WillsWackyMapObjectsEditor.MapObjects
{
    [EditorMapObject(typeof(ColoredRopeData), "Colored Rope")]
    public sealed class EditorColoredRope : ColoredRope
    {
        public override GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Editor Rope");

        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            var ropeInstance = instance.GetOrAddComponent<EditorRope.RopeInstance>();
            ropeInstance.GetAnchor(0).gameObject.GetOrAddComponent<MapObjectPart>();
            ropeInstance.GetAnchor(1).gameObject.GetOrAddComponent<MapObjectPart>();
            instance.GetOrAddComponent<RopeVisualizer>();
        }
    }
}
