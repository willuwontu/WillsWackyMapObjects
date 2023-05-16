using MapsExt.MapObjects;
using MapsExt.Properties;
using UnityEngine;
using WWMO.MapObjectProperties;

namespace WWMO.MapObjects
{
    public abstract class NonAnimatedSpatialMapObjectData : MapObjectData
    {
        [SerializeField] private PositionProperty _position = new PositionProperty();
        [SerializeField] private ScaleProperty _scale = new ScaleProperty();
        [SerializeField] private RotationProperty _rotation = new RotationProperty();
        [SerializeField] private ColorProperty _color = new ColorProperty();

        public PositionProperty Position { get => this._position; set => this._position = value; }
        public ScaleProperty Scale { get => this._scale; set => this._scale = value; }
        public RotationProperty Rotation { get => this._rotation; set => this._rotation = value; }
        public ColorProperty Color { get => this._color; set => this._color = value; }
    }
}
