using MapsExt.MapObjects;
using MapsExt;
using UnityEngine;
using UnboundLib;

namespace WWMO.MapObjects
{
    public class ColoredBoxData : ColoredSpatialMapObjectData { }

    [MapObject(typeof(ColoredBoxData))]
    public class ColoredBox : IMapObject
    {
        public virtual GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Box");

        public virtual void OnInstantiate(GameObject instance)
        {
            var npo = instance.GetComponent<NetworkPhysicsObject>();

            if (npo != null)
            {
                npo.bulletPushMultiplier = 20;
                npo.collisionThreshold = 200000;
                npo.dmgAmount = 0.5f;
                npo.forceAmount = 1500f;
                npo.maxShake = 8000000;
                npo.playerColThreshold = 5;
            }

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
