using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredBoxBackgroundData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredBoxBackgroundData))]
    public class ColoredBoxBackground : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Box Background");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
