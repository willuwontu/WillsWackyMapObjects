using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MapObjectProperties;

namespace WWMO.MapObjects
{
    public class ColoredSawDynamicData : ColoredSpatialMapObjectData
    {
        [SerializeField] private ParticleColorProperty _particleColor = new ParticleColorProperty();

        public ParticleColorProperty ParticleColor { get => this._particleColor; set => this._particleColor = value; }
    }

    [MapObject(typeof(ColoredSawDynamicData))]
    public class ColoredSawDynamic : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Saw Dynamic");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
