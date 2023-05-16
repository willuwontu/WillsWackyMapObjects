using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MapObjectProperties;

namespace WWMO.MapObjects
{
    public class ColoredSawData : ColoredSpatialMapObjectData 
    {
        [SerializeField] private ParticleColorProperty _particleColor = new ParticleColorProperty();

        public ParticleColorProperty ParticleColor { get => this._particleColor; set => this._particleColor = value; }
    }

    [MapObject(typeof(ColoredSawData))]
    public class ColoredSaw : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Saw");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
