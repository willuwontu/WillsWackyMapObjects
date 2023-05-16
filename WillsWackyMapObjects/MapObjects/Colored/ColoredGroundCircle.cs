using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredGroundCircleData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredGroundCircleData))]
    public class ColoredGroundCircle : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground Circle");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
