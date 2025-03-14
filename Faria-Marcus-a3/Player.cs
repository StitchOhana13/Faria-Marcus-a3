using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Player
    {
        public Texture2D Frog = Graphics.LoadTexture("../../../../Assets/Graphics/Frog.png");
        public Vector2 playerPosition = new Vector2(50, 50);
        public float playerSpeed = 100;
        public float size;
        public Vector2 velocity;
        public bool hasHitScreenEdge;
        public float colliderSize = 0;

        // Draw Frog
        public void Render()
        {
            Graphics.Draw(Frog, playerPosition.X, playerPosition.Y);
        }
        internal void update()
        {
            HandlePlayerMovement();
            BorderCollision();
        }

            // Player Movement
            public void HandlePlayerMovement()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                playerPosition.X += Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                playerPosition.X -= Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.Down))
            {
                playerPosition.Y += Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                playerPosition.Y -= Time.DeltaTime * playerSpeed;
            }
            playerPosition += velocity * Time.DeltaTime;
        }

        public void BorderCollision()
        {
            bool isCollideLeft = playerPosition.X - colliderSize <= 0;
            bool isCollideRight = playerPosition.X - colliderSize >= 350;
            bool isCollideTop = playerPosition.Y - colliderSize <= 0;
            bool isCollideBottom = playerPosition.Y + colliderSize >= 350;

            if (isCollideLeft)
                playerPosition.X = 0 + colliderSize;

            if (isCollideRight)
                playerPosition.X = 350 + colliderSize;

            if (isCollideTop)
                playerPosition.Y = 0 + colliderSize;

            if (isCollideBottom)
                playerPosition.Y = 350 - colliderSize;

        }

                //border collision
                //bool hitScreenEdge()
                //{
                //    bool hitScreenEdge = hasHitScreenEdge;
                //    hasHitScreenEdge = false;
                //    return hitScreenEdge;
                //}
            }
        }
