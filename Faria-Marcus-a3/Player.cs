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
        public Music FunSun = Audio.LoadMusic("../../../../Assets/Audio/FunInTheSun.MP3");
        public Music Victor = Audio.LoadMusic("../../../../Assets/Audio/Victor.MP3");
        public Vector2 playerPosition = new Vector2();
        public float playerSpeed = 100;
        public Vector2 playerSize = new Vector2(40,40);
        //public Rectangle playerSize = new Rectangle(0, 0, 40, 40);
        public Vector2 velocity;
        public bool hasHitScreenEdge;
        public float colliderSize = 0;
        Timer time;
        // Color FrogBodyLight = new Color("#74bb1f"); //Frog player body colour light
        // Color FrogBodyDark = new Color("#437013"); //Frog player body colour dark
        // Color Frogcheeks = new Color("#ffcde9"); //Frog cheek colour

        // Warp Point vectors
        public Vector2 objectPositionA1 = new Vector2(0, 55);
        public Vector2 objectPositionA2 = new Vector2(50, 115);
        public Vector2 objectPositionB1 = new Vector2(0, 110);
        public Vector2 objectPositionB2 = new Vector2(55, 150);
        public Vector2 objectPositionB3 = new Vector2(5, 210);
        public Vector2 objectPositionC1 = new Vector2(55, 215);
        public Vector2 objectPositionC2 = new Vector2(20, 250);
        public Vector2 objectPositionC3 = new Vector2(95, 250);
        public Vector2 objectPositionD1 = new Vector2(100, 115);
        public Vector2 objectPositionD2 = new Vector2(165, 50);
        public Vector2 objectPositionE1 = new Vector2(160, 5);
        public Vector2 objectPositionE2 = new Vector2(205, 45);
        public Vector2 objectPositionE3 = new Vector2(305, 5);
        public Vector2 objectPositionF1 = new Vector2(350, 15);
        public Vector2 objectPositionF2 = new Vector2(265, 55);
        public Vector2 objectPositionG1 = new Vector2(255, 105);
        public Vector2 objectPositionG2 = new Vector2(335, 105);
        public Vector2 objectPositionG3 = new Vector2(305, 165);
        public Vector2 objectPositionH1 = new Vector2(350, 155);
        public Vector2 objectPositionH2 = new Vector2(315, 200);
        public Vector2 objectPositionH3 = new Vector2(355, 255);
        public Vector2 objectPositionI1 = new Vector2(300, 265);
        public Vector2 objectPositionI2 = new Vector2(350, 305);
        public Vector2 objectPositionJ1 = new Vector2(250, 255);
        public Vector2 objectPositionJ2 = new Vector2(215, 300);
        public Vector2 objectPositionK1 = new Vector2(155, 315);
        public Vector2 objectPositionK2 = new Vector2(210, 355);
        public Vector2 objectPositionK3 = new Vector2(65, 355);
        public Vector2 objectPositionL1 = new Vector2(115, 300);
        public Vector2 objectPositionL2 = new Vector2(0, 365);

        // Warp destination Vectors
        public Vector2 newPositionA1 = new Vector2(5, 45);
        public Vector2 newPositionA2 = new Vector2(55, 85);
        public Vector2 newPositionB1 = new Vector2(5, 135);
        public Vector2 newPositionB2 = new Vector2(25, 155);
        public Vector2 newPositionB3 = new Vector2(5, 175);
        public Vector2 newPositionC1 = new Vector2(55, 235);
        public Vector2 newPositionC2 = new Vector2(40, 255);
        public Vector2 newPositionC3 = new Vector2(80, 255);
        public Vector2 newPositionD1 = new Vector2(105, 80);
        public Vector2 newPositionD2 = new Vector2(120, 55);
        public Vector2 newPositionE1 = new Vector2(185, 5);
        public Vector2 newPositionE2 = new Vector2(205, 35);
        public Vector2 newPositionE3 = new Vector2(285, 5);
        public Vector2 newPositionF1 = new Vector2(355, 45);
        public Vector2 newPositionF2 = new Vector2(285, 55);
        public Vector2 newPositionG1 = new Vector2(290, 105);
        public Vector2 newPositionG2 = new Vector2(315, 105);
        public Vector2 newPositionG3 = new Vector2(305, 135);
        public Vector2 newPositionH1 = new Vector2(355, 190);
        public Vector2 newPositionH2 = new Vector2(335, 205);
        public Vector2 newPositionH3 = new Vector2(355, 235);
        public Vector2 newPositionI1 = new Vector2(305, 290);
        public Vector2 newPositionI2 = new Vector2(355, 365);
        public Vector2 newPositionJ1 = new Vector2(255, 295);
        public Vector2 newPositionJ2 = new Vector2(225, 305);
        public Vector2 newPositionK1 = new Vector2(155, 335);
        public Vector2 newPositionK2 = new Vector2(185, 355);
        public Vector2 newPositionK3 = new Vector2(90, 355);
        public Vector2 newPositionL1 = new Vector2(70, 305);
        public Vector2 newPositionL2 = new Vector2(5, 335);
        public Vector2 newPositionM1 = new Vector2(175, 105);
        public Vector2 newPositionM2 = new Vector2(175, 255);

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
            time = new Timer();

            Audio.Play(FunSun);
        }

            // Player Movement
        public void HandlePlayerMovement()
        {
            Vector2 newPosition = playerPosition;
            if (Input.IsKeyboardKeyDown(KeyboardInput.D) || Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                newPosition.X += Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.A) || Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                newPosition.X -= Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.S) || Input.IsKeyboardKeyDown(KeyboardInput.Down))
            {
                newPosition.Y += Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.W) || Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                newPosition.Y -= Time.DeltaTime * playerSpeed;
            }
            if (Fences.FenceCheck(newPosition, playerSize))
            {
                playerPosition = newPosition;
            }
           // Console.WriteLine(playerPosition.ToString());
        }

        public void BorderCollision()
        {
            bool isCollideLeft = playerPosition.X - colliderSize <= 0;
            bool isCollideRight = playerPosition.X - colliderSize >= 400;
            bool isCollideTop = playerPosition.Y - colliderSize <= 0;
            bool isCollideBottom = playerPosition.Y + colliderSize >= 400;

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
            if (Vector2.Distance(playerPosition, objectPositionK1) < 10)
            {
                playerPosition = newPositionA1;
            }
            if (Vector2.Distance(playerPosition, objectPositionA2) < 10)
            {
                playerPosition = newPositionI2;
            }
            if (Vector2.Distance(playerPosition, objectPositionI2) < 10)
            {
                playerPosition = newPositionA2;
            }
            if (Vector2.Distance(playerPosition, objectPositionB1) < 10)
            {
                playerPosition = newPositionG2;
            }
            if (Vector2.Distance(playerPosition, objectPositionG2) < 10)
            {
                playerPosition = newPositionB1;
            }
            if (Vector2.Distance(playerPosition, objectPositionK2) < 10)
            {
                playerPosition = newPositionF1;
            }
            if (Vector2.Distance(playerPosition, objectPositionF1) < 10)
            {
                playerPosition = newPositionK2;
            }
            if (Vector2.Distance(playerPosition, objectPositionF2) < 10)
            {
                playerPosition = newPositionH3;
            }
            if (Vector2.Distance(playerPosition, objectPositionH3) < 10)
            {
                playerPosition = newPositionF2;
            }
            if (Vector2.Distance(playerPosition, objectPositionH2) < 10)
            {
                playerPosition = newPositionC3;
            }
            if (Vector2.Distance(playerPosition, objectPositionC3) < 10)
            {
                playerPosition = newPositionH2;
            }
            if (Vector2.Distance(playerPosition, objectPositionC1) < 10)
            {
                playerPosition = newPositionJ1;
            }
            if (Vector2.Distance(playerPosition, objectPositionJ1) < 10)
            {
                playerPosition = newPositionC1;
            }
            if (Vector2.Distance(playerPosition, objectPositionJ2) < 10)
            {
                playerPosition = newPositionE2;
            }
            if (Vector2.Distance(playerPosition, objectPositionE2) < 10)
            {
                playerPosition = newPositionJ2;
            }
            if (Vector2.Distance(playerPosition, objectPositionE3) < 10)
            {
                playerPosition = newPositionM1;
            }
            if (Vector2.Distance(playerPosition, objectPositionE1) < 10)
            {
                playerPosition = newPositionG1;
            }
            if (Vector2.Distance(playerPosition, objectPositionG1) < 10)
            {
                playerPosition = newPositionE1;
            }
            if (Vector2.Distance(playerPosition, objectPositionB3) < 10)
            {
                playerPosition = newPositionK3;
            }
            if (Vector2.Distance(playerPosition, objectPositionK3) < 10)
            {
                playerPosition = newPositionB3;
            }
            if (Vector2.Distance(playerPosition, objectPositionI1) < 10)
            {
                playerPosition = newPositionB2;
            }
            if (Vector2.Distance(playerPosition, objectPositionB2) < 10)
            {
                playerPosition = newPositionI1;
            }
            if (Vector2.Distance(playerPosition, objectPositionH1) < 10)
            {
                playerPosition = newPositionD1;
            }
            if (Vector2.Distance(playerPosition, objectPositionD1) < 10)
            {
                playerPosition = newPositionH1;
            }
            if (Vector2.Distance(playerPosition, objectPositionD2) < 10)
            {
                playerPosition = newPositionL1;
            }
            if (Vector2.Distance(playerPosition, objectPositionL1) < 10)
            {
                playerPosition = newPositionD2;
            }
            if (Vector2.Distance(playerPosition, objectPositionL2) < 10)
            {
                playerPosition = newPositionC2;
            }
            if (Vector2.Distance(playerPosition, objectPositionC2) < 10)
            {
                playerPosition = newPositionL2;
            }
            if (Vector2.Distance(playerPosition, objectPositionG3) < 10)
            {
                playerPosition = newPositionM2;
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

            Audio.Pause(FunSun);
            Audio.Play(Victor);

            Text.Draw("Congratulations!!", 50, 100);
            Text.Draw($"Final Time: {time.secondsElapsed}", 50, 200);
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