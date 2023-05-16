using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredGroundData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredGroundData))]
    public class ColoredGround : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
