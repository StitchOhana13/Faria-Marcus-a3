using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Player
    {
        public Texture2D Frog = Graphics.LoadTexture("../../../../Assets/Graphics/Frog.png");
        public Vector2 playerPosition = new Vector2();
        public float playerSpeed = 100;
        public float size;
        //public Rectangle playerSize = new Rectangle(0, 0, 40, 40);
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

        // Warp destination Vectors
        public Vector2 newPositionK1 = new Vector2(150, 330);
        public Vector2 newPositionI2 = new Vector2(350, 335);
        public Vector2 newPositionG2 = new Vector2(335, 100);

        //public Rectangle Fence1 = new Rectangle(0, 100, 50, 5);
        // Fence Borders positions
        //public Vector2 rectanglePosition1 = new Vector2(0, 100);
        //public Vector2 rectanglePosition2 = new Vector2(0, 250);

        // Fence Borders Size
        //public Vector2 rectangleSize1 = new Vector2(50, 5);
        //public Vector2 rectangleSize2 = new Vector2(50, 5);

        //Victory screen Variables
        public bool isWinner;
        public Vector2 winPosition = new Vector2(180, 180);

        // Draw Frog
        public void Render()
        {
            Graphics.Draw(Frog, playerPosition.X, playerPosition.Y);
        }
        public void update()
        {
            HandlePlayerMovement();
            BorderCollision();
            Warp();
            FenceBorders();
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
            Console.WriteLine(playerPosition);
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

        public void FenceBorders()
        {
            {
                // attempt to add fence collision
                //bool isCollideLeft1 = playerPosition.X - colliderSize == 100;
                //bool isCollideRight1 = playerPosition.X - colliderSize == 100;
                //bool isCollideTop1 = playerPosition.Y - colliderSize == 0;
                //bool isCollideBottom1 = playerPosition.Y + colliderSize == 250;
                //if (isCollideLeft1)
                //    playerPosition.X = 100 + colliderSize;

                //if (isCollideRight1)
                //    playerPosition.X = 100 + colliderSize;

                //if (isCollideTop1)
                //    playerPosition.Y = 0 + colliderSize;

                //if (isCollideBottom1)
                //    playerPosition.Y = 250 - colliderSize;
            } 
        }


        public void winCondition()
        {
            if (isWinner)
            {
                Winner();
            }
            else
            {
                PlayGame();
            }
        }

        public void PlayGame()
        {
            float distance = Vector2.Distance(playerPosition, winPosition);
            if (distance < 10)
            {
                isWinner = true;
            }
        }

        public void Winner()
        {
            Window.ClearBackground(Color.Yellow);

            Text.Draw("Congratulations!!", 50, 100);
            Text.Draw("Final Time: ...", 50, 200);
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
