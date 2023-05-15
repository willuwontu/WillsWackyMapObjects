using System;
using System.Collections.Generic;
using System.Text;
using UnboundLib;
using UnityEngine;

namespace WWMO.MonoBehaviours
{
    public class SpaceMono : WaterMono
    {
        private float _forceMult = 0.7f;
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
                return new Color(0.5f, 0.5f, 0.5f, 0.03f);
            }
        }

        public override void HandlePlayer(Player player)
        {
            var data = player.data;

            var inSpace = data.gameObject.GetOrAddComponent<PlayerInSpace_Mono>();

            if (!(data.isGrounded || data.isWallGrab) && player.data.view.IsMine)
            {
                player.data.healthHandler.CallTakeForce(Vector2.up * 0.125f * (float)player.data.playerVel.GetFieldValue("mass"));
            }
            else if (data.isGrounded && player.data.view.IsMine)
            {
                player.data.healthHandler.CallTakeForce(Vector2.down * 0.125f * (float)player.data.playerVel.GetFieldValue("mass"));
            }

            inSpace.inSpace = new bool[] { true, true };
        }

        public override void HandleBox(Rigidbody2D rb)
        {
            base.HandleBox(rb);

        }

        public override void HandleBullet(ProjectileHit projectileHit)
        {
            var inSpace = projectileHit.gameObject.GetOrAddComponent<BulletInSpace_Mono>();
            inSpace.inSpace = new bool[] { true, true };

        }
    }

    [DisallowMultipleComponent]
    public class PlayerInSpace_Mono : ModdingUtils.MonoBehaviours.ReversibleEffect
    {
        public bool[] inSpace = new bool[] { true, true };
        private float initialDrag;
        private float initialAngularDrag;
        public override void OnAwake()
        {
            if (!gameObject.GetComponentInParent<Player>())
            {
                UnityEngine.GameObject.Destroy(this);
            }
        }

        public override void OnStart()
        {
            characterStatModifiersModifier.jump_mult = 0.25f;
            characterStatModifiersModifier.movementSpeed_mult = 0.1f;
            gravityModifier.gravityForce_mult = -0.001f;

            initialAngularDrag = player.data.movement.extraAngularDrag;
            initialDrag = player.data.movement.extraDrag;

            player.data.movement.extraDrag = 1;
            player.data.movement.extraAngularDrag = 1;

            ApplyModifiers();
        }

        public override void OnFixedUpdate()
        {
            if (inSpace[0] == false && inSpace[0] == inSpace[1])
            {
                Destroy(this);
            }
            else
            {
                if (inSpace[0])
                {
                    inSpace[0] = false;
                }
                else
                {
                    inSpace[1] = false;
                }
            }
        }

        public override void OnOnDestroy()
        {
            player.data.movement.extraDrag = initialDrag;
            player.data.movement.extraAngularDrag = initialAngularDrag;

            data.currentJumps = data.jumps;
        }
    }
    [DisallowMultipleComponent]
    public class BulletInSpace_Mono : MonoBehaviour
    {
        public bool[] inSpace = new bool[] { true, true };

        private MoveTransform move;

        private void Start()
        {
            move = gameObject.GetComponent<MoveTransform>();
            move.simulateGravity = 1;
        }

        private void FixedUpdate()
        {
            if (inSpace[0] == false && inSpace[0] == inSpace[1])
            {
                move.simulateGravity = 0;
                Destroy(this);
            }
            else
            {
                if (inSpace[0])
                {
                    inSpace[0] = false;
                }
                else
                {
                    inSpace[1] = false;
                }
            }
        }
    }

}
