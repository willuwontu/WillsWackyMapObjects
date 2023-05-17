using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredGroundCircleData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredGroundCircleData))]
    public class ColoredGroundCircle : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground Circle");

        public virtual void OnInstantiate(GameObject instance)
        {
            SpriteRenderer spriteRenderer = instance.GetComponent<SpriteRenderer>();
            instance.tag = "NoMask";
            //UnityEngine.GameObject.DestroyImmediate(spriteRenderer);

            SpriteMask mask = instance.GetComponent<SpriteMask>();
            UnityEngine.GameObject.Destroy(mask);

            var box = MapObjectManager.LoadCustomAsset<GameObject>("Box");
            var color = box.transform.Find("Color");
            var colorSprite = color.GetComponent<SpriteRenderer>();
            //colorSprite.color = new Color32(55,55,55,255);

            spriteRenderer.material = colorSprite.material;
        }
    }
}
