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
        public Vector2 playerPosition = new Vector2(0, 0);
        public float playerSpeed = 100;
        public float size;
        public Vector2 velocity;
        public bool hasHitScreenEdge;
        public float colliderSize = 0;
        // Color FrogBodyLight = new Color("#74bb1f"); //Frog player body colour light
        // Color FrogBodyDark = new Color("#437013"); //Frog player body colour dark
        // Color Frogcheeks = new Color("#ffcde9"); //Frog cheek colour
        // Warp Point vectors
        public Vector2 objectPositionA1 = new Vector2(0, 65);
        public Vector2 objectPositionA2 = new Vector2(50, 115);
        public Vector2 objectPositionB1 = new Vector2(0, 95);
        //public Vector2 objectPositionB2 = new Vector2(0, 0);
        //public Vector2 objectPositionB3 = new Vector2(0, 0);
        //public Vector2 objectPositionC1 = new Vector2(0, 0);
        //public Vector2 objectPositionC2 = new Vector2(0, 0);
        //public Vector2 objectPositionC3 = new Vector2(0, 0);
        //public Vector2 objectPositionD1 = new Vector2(0, 0);
        //public Vector2 objectPositionD2 = new Vector2(0, 0);
        //public Vector2 objectPositionE1 = new Vector2(0, 0);
        //public Vector2 objectPositionE2 = new Vector2(0, 0);
        //public Vector2 objectPositionE3 = new Vector2(0, 0);
        //public Vector2 objectPositionF1 = new Vector2(0, 0);
        //public Vector2 objectPositionF2 = new Vector2(0, 0);
        public Vector2 newPositionK1 = new Vector2(150, 330);
        public Vector2 newPositionI2 = new Vector2(350, 335);
        public Vector2 newPositionG2 = new Vector2(335, 100);

        // Draw Frog
        public void Render()
        {
            Graphics.Draw(Frog, playerPosition.X, playerPosition.Y);
        }
        internal void update()
        {
            HandlePlayerMovement();
            BorderCollision();
            Warp();
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

        public void Warp()
        {
            if (Vector2.Distance(playerPosition, objectPositionA1) < 10)
            {
                playerPosition = newPositionK1;
            }
            if (Vector2.Distance(playerPosition, objectPositionA2) < 10)
            {
                playerPosition = newPositionI2;
            }
            if (Vector2.Distance(playerPosition, objectPositionB1) < 10)
            {
                playerPosition = newPositionG2;
            }
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
