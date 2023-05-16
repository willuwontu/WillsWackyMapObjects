using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using WWMO.MapObjectProperties;

namespace WWMO.MapObjects
{
    public class ColoredRopeData : RopeData
    {
        [SerializeField] private ColorProperty _color = new ColorProperty();

        public ColorProperty Color { get => this._color; set => this._color = value; }
    }

    [MapObject(typeof(ColoredRopeData))]
    public class ColoredRope : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Rope");

        public virtual void OnInstantiate(GameObject instance)
        {

        }
    }
}
