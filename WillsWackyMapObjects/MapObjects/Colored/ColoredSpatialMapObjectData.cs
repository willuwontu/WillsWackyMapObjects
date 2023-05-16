using MapsExt.MapObjects;
using UnityEngine;
using WWMO.MapObjectProperties;

namespace WWMO.MapObjects
{
    public abstract class ColoredSpatialMapObjectData : SpatialMapObjectData
    {
        [SerializeField] private ColorProperty _color = new ColorProperty();

        public ColorProperty Color { get => this._color; set => this._color = value; }
    }
}
