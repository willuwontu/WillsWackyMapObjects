using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WWMO.MonoBehaviours
{
    public class AcidMono : WaterMono
    {
        private float _forceMult = 0.685f;
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
                return new Color(0.15f, 1f, 0.15f, 0.0275f);
            }
        }

        public override void HandlePlayer(Player player)
        {
            base.HandlePlayer(player);

            player.data.healthHandler.TakeDamageOverTime(Vector2.up * 0.45f, Vector2.zero, 5, 1, new Color(0, 1, 0, 0.7f));
        }

        public override void HandleBox(Rigidbody2D rb)
        {
            base.HandleBox(rb);

            if (rb.isKinematic)
            {
                return;
            }

            if (rb.GetComponent<DamagableEvent>())
            {
                rb.GetComponent<DamagableEvent>().CallTakeDamage(Vector2.up * 2, Vector2.zero);
            }
            else
            {
                rb.gameObject.transform.localScale = new Vector3(rb.gameObject.transform.localScale.x * 0.9985f, rb.gameObject.transform.localScale.y * 0.9985f, rb.gameObject.transform.localScale.z);

                if (((Vector2)rb.gameObject.transform.localScale).magnitude <= new Vector2(0.2f, 0.2f).magnitude)
                {
                    Destroy(rb.gameObject);
                }
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

}
