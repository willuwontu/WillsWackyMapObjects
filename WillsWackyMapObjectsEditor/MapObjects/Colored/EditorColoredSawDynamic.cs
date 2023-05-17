using MapsExt;
using MapsExt.Editor.MapObjects;
using UnityEngine;
using WWMO.MapObjects;

namespace WWMO.MapObjects
{
    [EditorMapObject(typeof(ColoredSawDynamicData), "Saw", Category = "Colored Dynamic")]
    public sealed class EditorColoredSawDynamic : ColoredSawDynamic
    {
        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            GameObjectUtils.DisableRigidbody(instance);
        }
    }
}
