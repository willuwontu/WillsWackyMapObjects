using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredBoxData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredBoxData))]
    public class ColoredBox : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Box");

        public virtual void OnInstantiate(GameObject instance)
        {
            Transform lineTransform = instance.transform.Find("Lines");

            if (lineTransform != null)
            {
                UnityEngine.GameObject.Destroy(lineTransform.gameObject);
            }
        }
    }
}
