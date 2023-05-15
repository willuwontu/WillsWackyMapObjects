using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnboundLib;
using UnityEngine;

namespace WWMO.MonoBehaviours
{
    public class ForceZoneMono : WaterMono
    {
        private float _forceMult = 1f;
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
                return new Color(1f, 0.15f, 0.15f, 0.7f);
            }
        }

        public override void Start()
        {
            base.Start();

            this.GetComponent<SpriteRenderer>().sprite = WillsWackyMapObjects.instance.MapObjectAssets.LoadAsset<Sprite>("Boxed Arrow");
        }

        public override void HandlePlayer(Player player)
        {
            if (player.data.view.IsMine)
            {
                player.data.healthHandler.CallTakeForce(new Vector2(this.transform.up.normalized.x * 4f, this.transform.up.normalized.y * 1f / 2f) * forceMult * (float)player.data.playerVel.GetFieldValue("mass"));
            }
        }

        public override void HandleBox(Rigidbody2D rb)
        {
            /*
            1 - 2
            |   |
            0 - 3
            */

            // get the boxes of each object
            List<RaycastHit2D> hits = new List<RaycastHit2D>();
            var tempCorners = new Vector3[4];
            gameObject.GetOrAddComponent<RectTransform>().GetWorldCorners(tempCorners);
            Vector2[] waterCorners = tempCorners.Select(corner => (Vector2)corner).ToArray();

            rb.gameObject.GetOrAddComponent<RectTransform>().GetWorldCorners(tempCorners);
            Vector2[] rigidCorners = tempCorners.Select(corner => (Vector2)corner).ToArray();

            // Find out if any corners are in the water
            bool[] inWater = rigidCorners.Select(corner => PointIsInsideShape(waterCorners, corner)).ToArray();

            // If all of the corners are in the object, centroid is the centroid of the object.
            if (!inWater.Contains(false))
            {
                rb.AddForceAtPosition(this.transform.up.normalized * rb.mass * forceMult, rb.transform.position, ForceMode2D.Impulse);
                return;
            }

            // Find out if any of the water's corners are in the object
            bool[] inObject = waterCorners.Select(corner => PointIsInsideShape(rigidCorners, corner)).ToArray();

            // If all the corners of the water are in the object, centroid is center of water region
            if (!inObject.Contains(false))
            {
                rb.AddForceAtPosition(this.transform.up.normalized * rb.mass * forceMult, transform.position, ForceMode2D.Impulse);
                return;
            }

            // Get all contact points from our linecasts
            var contactPoints = hits.Where(hit => hit.collider.gameObject == rb.gameObject).Select(hit => hit.point).ToList();

            // Add any corners inside the water
            contactPoints.AddRange(rigidCorners.Where(corner => PointIsInsideShape(waterCorners, corner)));

            // If contact points for the object don't exist
            if (!(contactPoints.Count() > 0))
            {
                rb.AddForceAtPosition(this.transform.up.normalized * rb.mass * forceMult, rb.transform.position, ForceMode2D.Impulse);
                return;
            }

            //trail.AddPositions(contactPoints.Select(point => (Vector3) point).ToArray());

            // Centroid is (sum x / count x, sum y / count y)
            var centroid = new Vector2(contactPoints.Select(point => point.x).Sum() / contactPoints.Count(), contactPoints.Select(point => point.y).Sum() / contactPoints.Count());

            rb.AddForceAtPosition(this.transform.up.normalized * rb.mass * forceMult, centroid, ForceMode2D.Impulse);
        }

        public override void HandleBullet(ProjectileHit projectileHit)
        {
            var move = projectileHit.GetComponent<MoveTransform>();

            move.velocity += this.transform.up.normalized * 10 * forceMult;
        }
    }

}
