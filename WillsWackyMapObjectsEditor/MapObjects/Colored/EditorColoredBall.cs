using MapsExt;
using MapsExt.Editor.MapObjects;
using UnityEngine;
using WWMO.MapObjects;

namespace WWMO.MapObjects
{
    [EditorMapObject(typeof(ColoredBallData), "Ball", Category = "Colored Dynamic")]
    public sealed class EditorColoredBall : ColoredBall
    {
        public override void OnInstantiate(GameObject instance)
        {
            base.OnInstantiate(instance);
            GameObjectUtils.DisableRigidbody(instance);
        }
    }
}
