using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnboundLib;
using UnityEngine;

namespace WWMO.MonoBehaviours
{
    public class LavaMono : WaterMono
    {
        private float _forceMult = 0.8f;
        public override float forceMult
        {
            get
            {
                return _forceMult;
            }
            set
            {
                _forceMult = value;
            }
        }
        public override Color waterColor
        {
            get
            {
                return new Color(1f, 0.15f, 0.15f, 0.05f);
            }
        }
        public override void HandlePlayer(Player player)
        {
            base.HandlePlayer(player);

            player.data.healthHandler.TakeDamageOverTime(Vector2.up * 0.65f, Vector2.zero, 2.5f, 1, new Color(1, 0, 0, 0.7f));
        }

        public override void HandleBox(Rigidbody2D rb)
        {
            base.HandleBox(rb);

            if (rb.isKinematic || rb.gameObject.layer == LayerMask.NameToLayer("BackgroundObject"))
            {
                return;
            }

            if (rb.GetComponent<DamagableEvent>())
            {
                rb.GetComponent<DamagableEvent>().CallTakeDamage(Vector2.up * 2, Vector2.zero);
            }
            else
            {
                var heatMono = rb.gameObject.GetOrAddComponent<BoxTouchingLava_Mono>();
                heatMono.heatPercent += 0.01f;
                heatMono.heatPercent = Mathf.Min(heatMono.heatPercent, 1f);
            }
        }

        public override void HandleBullet(ProjectileHit projectileHit)
        {
            base.HandleBullet(projectileHit);

            projectileHit.GetComponent<ProjectileCollision>().TakeDamage(10);
            projectileHit.damage -= 10;
            projectileHit.damage = Mathf.Max(projectileHit.damage, 1);
        }
    }


    public class BoxTouchingLava_Mono : MonoBehaviour
    {
        class SpriteColors
        {
            public SpriteRenderer sprite;
            public Color initialColor;

            public SpriteColors(SpriteRenderer renderer, Color color)
            {
                sprite = renderer;
                initialColor = color;
            }
        }

        SpriteColors[] boxSprites;
        float heatDuration = 5f;
        Color heatedColor = new Color(1f, 0f, 0f, 0.7f);
        public float heatPercent;

        private void Start()
        {
            boxSprites = GetComponentsInChildren<SpriteRenderer>().Where(sr => sr.gameObject.name != "Lines").Select(sr => new SpriteColors(sr, sr.color)).ToArray();
        }

        private void Update()
        {
            foreach (var sr in boxSprites)
            {
                Color initialColor = sr.initialColor;
                sr.sprite.color = new Color(initialColor.r + (heatedColor.r - initialColor.r) * heatPercent, initialColor.g + (heatedColor.g - initialColor.g) * heatPercent, initialColor.b + (heatedColor.b - initialColor.b) * heatPercent, initialColor.a + (heatedColor.a - initialColor.a) * heatPercent);
            }

            if (heatPercent <= 0f)
            {
                Destroy(this);
            }
        }

        private void FixedUpdate()
        {
            var colliders = Physics2D.OverlapBoxAll(transform.position, gameObject.GetOrAddComponent<RectTransform>().localScale * 1f, Vector2.SignedAngle(Vector2.up, (Vector2)transform.up.normalized));

            foreach (var collider in colliders)
            {
                if (collider.GetComponent<Player>())
                {
                    var player = collider.GetComponent<Player>();

                    player.data.healthHandler.TakeDamageOverTime(Vector2.up * 0.25f * heatPercent, Vector2.zero, 5f, 0.1f, new Color(1f, 0f, 0f, 0.7f));
                }
            }

            heatPercent -= Time.deltaTime / heatDuration;
        }

        private void OnDestroy()
        {
            foreach (var sr in boxSprites)
            {
                Color initialColor = sr.sprite.color;
                sr.sprite.color = sr.initialColor;
            }
        }
    }
}
