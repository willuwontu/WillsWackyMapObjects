using MapsExt;
using MapsExt.Editor.MapObjects;
using UnityEngine;
using WWMO.MapObjects;

namespace WWMO.MapObjects
{
    [EditorMapObject(typeof(ColoredBoxData), "Box", Category = "Colored Dynamic")]
    public sealed class EditorColoredBox : ColoredBox
    {
        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            GameObjectUtils.DisableRigidbody(instance);
        }
    }
}
