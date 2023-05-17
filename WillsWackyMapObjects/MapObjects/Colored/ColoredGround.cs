using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using UnboundLib;

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
            UnityEngine.GameObject.Destroy(mask);

            WillsWackyMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                SpriteMask mask = instance.GetComponent<SpriteMask>();
                UnityEngine.GameObject.Destroy(mask);

                spriteRenderer.material = new Material(Shader.Find("Sprites/Default"));
            });

            WillsWackyMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                SpriteMask mask = instance.GetComponent<SpriteMask>();
                UnityEngine.GameObject.Destroy(mask);

                spriteRenderer.material = new Material(Shader.Find("Sprites/Default"));
            });

            spriteRenderer.material = new Material(Shader.Find("Sprites/Default"));

            GetColor[] getColors = instance.GetComponentsInChildren<GetColor>();


            for (int i = getColors.Length - 1; i >= 0; i--)
            {
                UnityEngine.GameObject.DestroyImmediate(getColors[i]);
            }
        }
    }
}
