using MapsExt;
using MapsExt.Editor.MapObjects;
using UnityEngine;
using WWMO.MapObjects;

namespace WWMO.MapObjects
{
    [EditorMapObject(typeof(ColoredBoxDestructibleData), "Box (Destructible)", Category = "Colored Dynamic")]
    public sealed class EditorColoredBoxDestructible : ColoredBoxDestructible
    {
        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            GameObjectUtils.DisableRigidbody(instance);
        }
    }
}
