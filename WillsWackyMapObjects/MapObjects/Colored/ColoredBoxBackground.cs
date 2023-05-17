using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using UnboundLib;

namespace WWMO.MapObjects
{
    public class ColoredBoxBackgroundData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredBoxBackgroundData))]
    public class ColoredBoxBackground : IMapObject
    {
        public virtual GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

        public virtual void OnInstantiate(GameObject instance)
        {
            GameObject.Destroy(instance.transform.GetChild(1).gameObject);
            GameObject.Destroy(instance.transform.GetChild(0).gameObject);

            SpriteRenderer spriteRenderer = instance.GetComponent<SpriteRenderer>();

            spriteRenderer.enabled = true;

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
