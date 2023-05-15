using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MonoBehaviours;
using UnboundLib;

namespace WWMO.MapObjects
{
    public class LavaData : NonAnimatedSpatialMapObjectData { }

    [MapObject(typeof(LavaData))]
    public class Lava : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        public virtual void OnInstantiate(GameObject instance)
        {
            instance.GetOrAddComponent<LavaMono>();
        }
    }
}
