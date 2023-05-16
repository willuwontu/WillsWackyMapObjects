using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;

namespace WWMO.MapObjects
{
    public class ColoredGroundData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredGroundData))]
    public class ColoredGround : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

        public virtual void OnInstantiate(GameObject instance)
        {
            SpriteRenderer spriteRenderer = instance.GetComponent<SpriteRenderer>();
            instance.tag = "NoMask";
            //UnityEngine.GameObject.DestroyImmediate(spriteRenderer);

            SpriteMask mask = instance.GetComponent<SpriteMask>();
            UnityEngine.GameObject.DestroyImmediate(mask);

            var box = MapObjectManager.LoadCustomAsset<GameObject>("Box");
            var color = box.transform.Find("Color");
            var colorSprite = color.GetComponent<SpriteRenderer>();
            //colorSprite.color = new Color32(55,55,55,255);

            spriteRenderer.material = colorSprite.material;

            GetColor[] getColors = instance.GetComponentsInChildren<GetColor>();


            for (int i = getColors.Length - 1; i >= 0; i--)
            {
                UnityEngine.GameObject.DestroyImmediate(getColors[i]);
            }
        }
    }
}
