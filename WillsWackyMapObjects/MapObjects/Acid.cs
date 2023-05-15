using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MonoBehaviours;
using UnboundLib;

namespace WWMO.MapObjects
{
    public class AcidData : NonAnimatedSpatialMapObjectData { }

    [MapObject(typeof(AcidData))]
    public class Acid : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        public virtual void OnInstantiate(GameObject instance)
        {
            instance.GetOrAddComponent<AcidMono>();
        }
    }
}
