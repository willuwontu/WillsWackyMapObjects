using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MonoBehaviours;
using UnboundLib;

namespace WWMO.MapObjects
{
    public class WaterData : LiquidMapObjectData { }

    [MapObject(typeof(WaterData))]
    public class WaterMapObject : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        public virtual void OnInstantiate(GameObject instance)
        {
            instance.GetOrAddComponent<WaterMono>();
        }
    }
}
