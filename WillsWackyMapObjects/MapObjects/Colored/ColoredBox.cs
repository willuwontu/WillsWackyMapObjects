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

            GetColor[] getColors = instance.GetComponentsInChildren<GetColor>();


            for (int i = getColors.Length - 1; i >= 0; i--)
            {
                UnityEngine.GameObject.DestroyImmediate(getColors[i]);
            }
        }
    }
}
