using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredBallData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredBallData))]
    public class ColoredBall : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ball");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
