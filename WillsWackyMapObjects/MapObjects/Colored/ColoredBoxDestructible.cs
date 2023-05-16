using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using MapsExt.Properties;

namespace WWMO.MapObjects
{
    public class ColoredBoxDestructibleData : ColoredSpatialMapObjectData 
    {
        [SerializeField] private bool _damageable;

        public DamageableProperty DamageableByEnvironment { get => this._damageable; set => this._damageable = value; }

        public ColoredBoxDestructibleData()
        {
            this.DamageableByEnvironment = new DamageableProperty();
        }
    }

    [MapObject(typeof(ColoredBoxDestructibleData))]
    public class ColoredBoxDestructible : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Box Destructible");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
