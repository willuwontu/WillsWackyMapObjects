using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnityEngine;
using UnboundLib;
using HarmonyLib;

namespace WWMO.MonoBehaviours
{
    public class WaterMono : MonoBehaviour
    {
        //TrailRenderer trail;

        public RaycastHit2D[] hits;

        private float _forceMult = 0.745f;
        public virtual float forceMult
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
        public virtual Color waterColor
        {
            get
            {
                return new Color(0.215f, 0.215f, 0.8f, 0.025f);
            }
        }

        public virtual void Start()
        {
            //if (gameObject.GetComponent<Collider2D>())
            //{
            //    Destroy(gameObject.GetComponent<Collider2D>());
            //}

            this.gameObject.layer = LayerMask.NameToLayer("BackgroundObject");
            var coll = gameObject.GetOrAddComponent<BoxCollider2D>();
            coll.isTrigger = true;

            //var rigid = gameObject.GetOrAddComponent<Rigidbody2D>();
            //rigid.isKinematic = true;
            //rigid.useFullKinematicContacts = true;
            gameObject.GetOrAddComponent<RectTransform>();

            UnityEngine.GameObject.Destroy(gameObject.GetComponent<SpriteMask>());
            gameObject.GetOrAddComponent<SpriteRenderer>().material = WillsWackyMapObjects.defaultMaterial;

            gameObject.GetOrAddComponent<SpriteRenderer>().color = waterColor;

            WillsWackyMapObjects.instance.ExecuteAfterFrames(1, () => 
            {
                UnityEngine.GameObject.Destroy(gameObject.GetComponent<SpriteMask>());
                var sprite = gameObject.GetOrAddComponent<SpriteRenderer>();

                sprite.material = WillsWackyMapObjects.defaultMaterial;
                sprite.color = waterColor;
            });
            UnityEngine.GameObject.Destroy(gameObject.GetComponent<SpriteMask>());
            WillsWackyMapObjects.instance.ExecuteAfterFrames(5, () =>
            {
                UnityEngine.GameObject.Destroy(gameObject.GetComponent<SpriteMask>());
                var sprite = gameObject.GetOrAddComponent<SpriteRenderer>();

                sprite.material = WillsWackyMapObjects.defaultMaterial;
                sprite.color = waterColor;
            });

            //trail = this.gameObject.AddComponent<TrailRenderer>();
            //trail.startColor = waterColor;
            //trail.endColor = waterColor;
            //trail.time = 0.02f;
            //trail.startWidth = 0.025f;
            //trail.endWidth = 0.025f;
        }

        void DisplayWorldCorners()
        {
            RectTransform rt = GetComponent<RectTransform>();
            Vector3[] v = new Vector3[4];
            rt.GetWorldCorners(v);

            UnityEngine.Debug.Log("World Corners");
            for (var i = 0; i < 4; i++)
            {
                UnityEngine.Debug.Log("World Corner " + i + " : " + v[i]);
            }
        }

        //private void OnTriggerEnter2D(Collider2D collider)
        //{
        //    //if (collider == this.gameObject.GetComponent<Collider2D>())
        //    //{
        //    //    return;
        //    //}

        //    HandleCollision(collider);
        //}

        //private void OnTriggerStay2D(Collider2D collider)
        //{
        //    //if (collider == this.gameObject.GetComponent<Collider2D>())
        //    //{
        //    //    return;
        //    //}

        //    HandleCollision(collider);
        //}

        private void FixedUpdate()
        {
            if (!gameObject.GetComponent<Renderer>())
            {
                return;
            }

            var tempHits = new List<RaycastHit2D>();

            var tempCorners = new Vector3[4];
            gameObject.GetOrAddComponent<RectTransform>().GetWorldCorners(tempCorners);
            Vector2[] waterCorners = tempCorners.Select(corner => (Vector2)corner).ToArray();

            //trail.AddPositions(tempCorners);
            //trail.AddPosition(tempCorners[0]);

            // Get all collisions going clockwise
            for (int i = 0; i < waterCorners.Length; i++)
            {
                if (i == 0)
                {
                    tempHits.AddRange(Physics2D.LinecastAll(waterCorners[waterCorners.Length - 1], waterCorners[0]));
                }
                else
                {
                    tempHits.AddRange(Physics2D.LinecastAll(waterCorners[i - 1], waterCorners[i]));
                }
            }

            // Get all collisions going counterclockwise
            for (int i = 0; i < waterCorners.Length; i++)
            {
                if (i == 0)
                {
                    tempHits.AddRange(Physics2D.LinecastAll(waterCorners[0], waterCorners[waterCorners.Length - 1]));
                }
                else
                {
                    tempHits.AddRange(Physics2D.LinecastAll(waterCorners[i], waterCorners[i - 1]));
                }
            }

            hits = tempHits.ToArray();

            var colliders = Physics2D.OverlapBoxAll(transform.position, gameObject.GetComponent<RectTransform>().lossyScale, Vector2.SignedAngle(Vector2.up, transform.up.normalized));

            foreach (var collider in colliders)
            {
                HandleCollision(collider);
            }
        }

        public virtual void HandleCollision(Collider2D collider)
        {

            //trail.AddPositions(new Vector3[] { this.transform.position, collider.transform.position });

            // If our patch of water
            if (collider.gameObject == this.gameObject)
            {
                return;
            }

            // If Player
            if (collider.GetComponent<Player>())
            {
                HandlePlayer(collider.GetComponent<Player>());

                return;
            }

            // If Bullet
            if (collider.GetComponentInParent<ProjectileHit>())
            {
                HandleBullet(collider.GetComponentInParent<ProjectileHit>());

                return;
            }

            // If Box
            if (collider.GetComponent<Rigidbody2D>())
            {
                HandleBox(collider.GetComponent<Rigidbody2D>());

                return;
            }
        }

        public virtual void HandlePlayer(Player player)
        {
            var data = player.data;

            data.currentJumps = data.jumps;
            var inWater = data.gameObject.GetOrAddComponent<PlayerInWater_Mono>();

            if (player.data.view.IsMine)
            {
                player.data.healthHandler.CallTakeForce(Vector2.up * 0.15f * (float)player.data.playerVel.GetFieldValue("mass"), ForceMode2D.Impulse);
            }

            inWater.hadWater = new bool[] { true, true };
        }

        public virtual void HandleBullet(ProjectileHit projectileHit)
        {
            var inWater = projectileHit.gameObject.GetOrAddComponent<BulletInWater_Mono>();
            inWater.hadWater = new bool[] { true, true };
        }

        public virtual void HandleBox(Rigidbody2D rb, RaycastHit2D[] hits)
        {
            if (hits.Length > 0)
            {
                Vector2 centroid = new Vector2(hits.Select(hit => hit.point.x).Sum() / hits.Length, hits.Select(hit => hit.point.y).Sum() / hits.Length);

                rb.AddForceAtPosition(Vector2.up * rb.mass * forceMult, centroid, ForceMode2D.Impulse);
            }
            else
            {
                rb.AddForce(Vector2.up * rb.mass * forceMult, ForceMode2D.Impulse);
            }
        }

        public virtual void HandleBox(Rigidbody2D rb)
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
                rb.AddForceAtPosition(Vector2.up * rb.mass * forceMult, rb.transform.position, ForceMode2D.Impulse);
                return;
            }

            // Find out if any of the water's corners are in the object
            bool[] inObject = waterCorners.Select(corner => PointIsInsideShape(rigidCorners, corner)).ToArray();

            // If all the corners of the water are in the object, centroid is center of water region
            if (!inObject.Contains(false))
            {
                rb.AddForceAtPosition(Vector2.up * rb.mass * forceMult, transform.position, ForceMode2D.Impulse);
                return;
            }

            // Get all contact points from our linecasts
            var contactPoints = hits.Where(hit => hit.collider.gameObject == rb.gameObject).Select(hit => hit.point).ToList();

            // Add any corners inside the water
            contactPoints.AddRange(rigidCorners.Where(corner => PointIsInsideShape(waterCorners, corner)));

            // If contact points for the object don't exist
            if (!(contactPoints.Count() > 0))
            {
                rb.AddForceAtPosition(Vector2.up * rb.mass * forceMult, rb.transform.position, ForceMode2D.Impulse);
                return;
            }

            //trail.AddPositions(contactPoints.Select(point => (Vector3) point).ToArray());

            // Centroid is (sum x / count x, sum y / count y)
            var centroid = new Vector2(contactPoints.Select(point => point.x).Sum() / contactPoints.Count(), contactPoints.Select(point => point.y).Sum() / contactPoints.Count());

            rb.AddForceAtPosition(Vector2.up * rb.mass * forceMult, centroid, ForceMode2D.Impulse);
        }

        internal bool PointIsInsideShape(Vector2[] outline, Vector2 point)
        {
            var result = true;
            List<int> results = new List<int>();
            for (int i = 0; i < outline.Length - 1; i++)
            {
                results.Add(isLeft(outline[i], outline[i + 1], point));
            }

            if (results.Contains(1) && results.Contains(2))
            {
                result = false;
            }

            return result;
        }

        private int isLeft(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
        {

            Vector3 lineVec = linePoint2 - linePoint1;
            Vector3 pointVec = point - linePoint1;

            float dot = Vector3.Dot(pointVec, lineVec);

            //point is on side of linePoint2, compared to linePoint1
            if (dot > 0)
            {

                //point is on the line segment
                if (pointVec.magnitude <= lineVec.magnitude)
                {

                    return 0;
                }

                //point is not on the line segment and it is on the side of linePoint2
                else
                {

                    return 2;
                }
            }

            //Point is not on side of linePoint2, compared to linePoint1.
            //Point is not on the line segment and it is on the side of linePoint1.
            else
            {

                return 1;
            }
        }
    }

    [DisallowMultipleComponent]
    public class PlayerInWater_Mono : ModdingUtils.MonoBehaviours.ReversibleEffect
    {
        public bool[] hadWater = new bool[] { true, true };

        public override void OnAwake()
        {
            if (!this.gameObject.GetComponent<Player>())
            {
                UnityEngine.GameObject.Destroy(this);
            }
        }

        public override void OnStart()
        {
            characterStatModifiersModifier.jump_mult = 0.2f;
            characterStatModifiersModifier.movementSpeed_mult = 0.7f;
            gravityModifier.gravityForce_mult = 0f;

            player.GetComponent<Gravity>().enabled = false;

            ApplyModifiers();
        }

        public override void OnFixedUpdate()
        {
            if (!player)
            {
                return;
            }

            if (hadWater[0] == false && hadWater[0] == hadWater[1])
            {
                UnityEngine.GameObject.Destroy(this);
            }
            else
            {
                if (hadWater[0])
                {
                    hadWater[0] = false;
                }
                else
                {
                    hadWater[1] = false;
                }
            }

            if (player.data.playerActions.Jump.IsPressed)
            {
                player.data.jump.Jump();
            }
        }

        public override void OnOnDestroy()
        {
            player.GetComponent<Gravity>().enabled = true;

            data.currentJumps = data.jumps;
        }
    }

    [DisallowMultipleComponent]
    public class BulletInWater_Mono : MonoBehaviour
    {
        public bool[] hadWater = new bool[] { true, true };

        private MoveTransform move;
        private float initialDrag;
        private float initialMinDragSpeed;
        private float prevVel;
        private float timeEntered;
        private float maxTimeInWater = 1f;
        private void Start()
        {
            move = gameObject.GetComponent<MoveTransform>();
            prevVel = move.velocity.magnitude;
            timeEntered = Time.time;
            initialDrag = move.drag;
            initialMinDragSpeed = move.dragMinSpeed;
        }

        private void FixedUpdate()
        {
            move.drag += 2;
            move.dragMinSpeed = 0f;
            if (move.velocity.magnitude < prevVel)
            {
                prevVel = move.velocity.magnitude;
            }
            if (move.velocity.magnitude > prevVel)
            {
                move.velocity = Vector3.ClampMagnitude(move.velocity, prevVel);
            }

            move.velocity += Vector3.up * 0.5f;

            if (Time.time >= timeEntered + maxTimeInWater)
            {
                Destroy(gameObject);
            }

            if (hadWater[0] == false && hadWater[0] == hadWater[1])
            {
                move.drag = initialDrag;
                move.dragMinSpeed = initialMinDragSpeed;
                Destroy(this);
            }
            else
            {
                if (hadWater[0])
                {
                    hadWater[0] = false;
                }
                else
                {
                    hadWater[1] = false;
                }
            }
        }
    }
}