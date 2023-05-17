using MapsExt;
using MapsExt.Editor.MapObjects;
using UnityEngine;
using WWMO.MapObjects;

namespace WWMO.MapObjects
{
    [EditorMapObject(typeof(ColoredBoxBackgroundData), "Box (Background)", Category = "Colored Dynamic")]
    public sealed class EditorColoredBoxBackground : ColoredBoxBackground
    {
        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            GameObjectUtils.DisableRigidbody(instance);
        }
    }
}
