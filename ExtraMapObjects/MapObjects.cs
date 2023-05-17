using System;
using MapsExt;
using MapsExt.Compatibility;
using MapsExt.MapObjects;
using MapsExt.Properties;
using UnboundLib;
using UnityEngine;
using WWMO.MapObjects;

namespace ExtraMapObjects
{
    #region Static

    public class MapObjects
    {
        private static readonly Material defaultMaterial = new Material(Shader.Find("Sprites/Default"));

        public static void Deserialize(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }

        public static void DeserializePhys(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                color.a = 1;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }

        public static void DeserializePhysBack(GameObject target, Color color)
        {
            ExtraMapObjects.instance.ExecuteAfterFrames(1, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().enabled = true;
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                target.GetComponent<SpriteRenderer>().color = color;
            });
            ExtraMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                GameObject.Destroy(target.GetComponent<SpriteMask>());
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                GameObject.Destroy(target.transform.TryGetChild(0).gameObject);
                target.GetComponent<SpriteRenderer>().enabled = true;
                target.GetComponent<SpriteRenderer>().material = defaultMaterial;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                target.GetComponent<SpriteRenderer>().color = color;
            });
        }


        [Obsolete("Legacy map object")]
        public class Red : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.red * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Red))]
        public static class RedSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Red target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Red data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.red * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Green : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.green * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Green))]
        public static class GreenSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Green target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Green data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.green * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Blue : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.blue * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Blue))]
        public static class BlueSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Blue target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Blue data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.blue * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Yellow : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.yellow * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Yellow))]
        public static class YellowSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Yellow target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Yellow data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Purple : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Purple))]
        public static class PurpleSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Purple target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Purple data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.5f, 0f, 0.9f));
            }
        }

        [Obsolete("Legacy map object")]
        public class Orange : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Orange))]
        public static class OrangeSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Orange target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Orange data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(1f, 0.5f, 0f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Brown : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Brown))]
        public static class BrownSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Brown target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Brown data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.5f, 0.25f, 0f));
            }
        }

        [Obsolete("Legacy map object")]
        public class Pink : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Pink))]
        public static class PinkSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Pink target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Pink data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.9f, 0.4f, 0.7f));
            }
        }

        [Obsolete("Legacy map object")]
        public class Cyan : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Cyan))]
        public static class CyanSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Cyan target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Cyan data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.1f, 0.8f, 0.8f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Black : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Black))]
        public static class BlackSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Black target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Black data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0, 0, 0));
            }
        }

        [Obsolete("Legacy map object")]
        public class White : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(White))]
        public static class WhiteSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, White target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(White data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(1f, 1f, 1f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class Grey : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredGroundData data = new ColoredGroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.4f, 0.4f, 0.4f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(Grey))]
        public static class GreySpec
        {
            [MapObjectPrefab] public static GameObject Prefab => MapObjectManager.LoadCustomAsset<GameObject>("Ground");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, Grey target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(Grey data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.Deserialize(target, new Color(0.4f, 0.4f, 0.4f));
            }
        }

        #endregion

        #region Dynamic objects
        [Obsolete("Legacy map object")]
        public class RedPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.red * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(RedPhys))]
        public static class RedPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, RedPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(RedPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.red * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class GreenPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.green * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(GreenPhys))]
        public static class GreenPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreenPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreenPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.green * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BluePhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.blue * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BluePhys))]
        public static class BluePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BluePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BluePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.blue * 0.8f);
            }
        }


        [Obsolete("Legacy map object")]
        public class YellowPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = Color.yellow * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(YellowPhys))]
        public static class YellowPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, YellowPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(YellowPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class PurplePhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0f, 0.9f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(PurplePhys))]
        public static class PurplePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PurplePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PurplePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.5f, 0f, 0.9f));
            }
        }

        [Obsolete("Legacy map object")]
        public class OrangePhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 0.5f, 0f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(OrangePhys))]
        public static class OrangePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, OrangePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(OrangePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(1f, 0.5f, 0f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BrownPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.5f, 0.25f, 0f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BrownPhys))]
        public static class BrownPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BrownPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BrownPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.5f, 0.25f, 0f));
            }
        }

        [Obsolete("Legacy map object")]
        public class PinkPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.9f, 0.4f, 0.7f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(PinkPhys))]
        public static class PinkPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PinkPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PinkPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.9f, 0.4f, 0.7f));
            }
        }

        [Obsolete("Legacy map object")]
        public class CyanPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.1f, 0.8f, 0.8f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(CyanPhys))]
        public static class CyanPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, CyanPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(CyanPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.1f, 0.8f, 0.8f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BlackPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0, 0, 0);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BlackPhys))]
        public static class BlackPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BlackPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BlackPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0, 0, 0));
            }
        }

        [Obsolete("Legacy map object")]
        public class WhitePhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(1f, 1f, 1f) * 0.8f;
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(WhitePhys))]
        public static class WhitePhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, WhitePhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(WhitePhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(1f, 1f, 1f) * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class GreyPhys : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxData data = new ColoredBoxData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                data.Color = new Color(0.4f, 0.4f, 0.4f);
                Color color = data.Color;
                color.a = 1;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(GreyPhys))]
        public static class GreyPhysSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreyPhys target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreyPhys data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhys(target, new Color(0.4f, 0.4f, 0.4f));
            }
        }

        #endregion


        #region PhysBackg
        [Obsolete("Legacy map object")]
        public class RedPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.red * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(RedPhysBackg))]
        public static class RedPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, RedPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(RedPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.red * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class GreenPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.green * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(GreenPhysBackg))]
        public static class GreenPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreenPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreenPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.green * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BluePhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.blue * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BluePhysBackg))]
        public static class BluePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BluePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BluePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.blue * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class YellowPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(YellowPhysBackg))]
        public static class YellowPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, YellowPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(YellowPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class PurplePhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.magenta * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(PurplePhysBackg))]
        public static class PurplePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PurplePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PurplePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.magenta * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class OrangePhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(OrangePhysBackg))]
        public static class OrangePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, OrangePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(OrangePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BrownPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BrownPhysBackg))]
        public static class BrownPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BrownPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BrownPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class PinkPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.yellow * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(PinkPhysBackg))]
        public static class PinkPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, PinkPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(PinkPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.yellow * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class CyanPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.cyan * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(CyanPhysBackg))]
        public static class CyanPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, CyanPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(CyanPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.cyan * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class BlackPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.black * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(BlackPhysBackg))]
        public static class BlackPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, BlackPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(BlackPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.black * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class WhitePhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.white * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(WhitePhysBackg))]
        public static class WhitePhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, WhitePhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(WhitePhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.white * 0.8f);
            }
        }

        [Obsolete("Legacy map object")]
        public class GreyPhysBackg : SpatialMapObject, IUpgradable<MapObjectData>
        {
            public MapObjectData Upgrade()
            {
                ColoredBoxBackgroundData data = new ColoredBoxBackgroundData();
                data.Active = true;
                data.Position = this.position;
                data.Scale = this.scale;
                data.Rotation = new RotationProperty(this.rotation.eulerAngles.z);
                var color = Color.grey * 0.8f;
                Color.RGBToHSV(color, out var h, out var s, out var v);
                color = Color.HSVToRGB(h, s, v * 0.75f);
                color.a = 0.5f;
                data.Color = color;
                return data;
            }
        }

        [Obsolete("Legacy map object")]
        [MapObjectSpec(typeof(GreyPhysBackg))]
        public static class GreyPhysBackgSpec
        {
            [MapObjectPrefab] public static GameObject Prefab => Resources.Load<GameObject>("4 Map Objects/Box_BG");

            [MapObjectSerializer]
            public static void Serialize(GameObject instance, GreyPhysBackg target)
            {
                SpatialSerializer.Serialize(instance, target);
            }

            [MapObjectDeserializer]
            public static void Deserialize(GreyPhysBackg data, GameObject target)
            {
                SpatialSerializer.Deserialize(data, target);
                MapObjects.DeserializePhysBack(target, Color.grey * 0.8f);
            }
        }

        #endregion
    }
}