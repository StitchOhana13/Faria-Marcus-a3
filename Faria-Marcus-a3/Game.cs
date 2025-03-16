// Current to do: add fence collision, add warp pipe teleport, add timer, add victory screen

// Include the namespaces (code libraries) you need below.
using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Faria_Marcus_a3;

// The namespace your code is in.
namespace MohawkGame2D
{
    public class Game
    {
        // Place your variables here:
        Color GrassGreen = new Color("#429637"); //Grass back ground colour
        public Vector2 playerPosition = new Vector2();

        Player player;
        Fences fences;
        Pipes pipe;
        Timer time;

        public void Setup()
        {
            Window.SetTitle("Warp Pipe Dream");
            Window.SetSize(400, 400);

            player = new Player();
            fences = new Fences();
            pipe = new Pipes();
            time = new Timer();


            player.playerPosition = new Vector2();
        }

        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            //HandlePlayerMovement();
            

            //can't change the background colour the my grass green variable so big square over top of it
            Draw.FillColor = GrassGreen;
            Draw.LineColor = GrassGreen;
            Draw.Square(0, 0, 400);

            //warps.Warp();

            //Warp Points"
            {
                {
                    //Draw.FillColor = Color.Red;
                    //Draw.Circle(25, 75, 4);
                    //Draw.Circle(175, 25, 4);
                    //Draw.Circle(325, 25, 4);
                    //Draw.Circle(375, 25, 4);
                    //Draw.Circle(175, 75, 4);
                    //Draw.Circle(225, 75, 4);
                    //Draw.Circle(275, 75, 4);
                    //Draw.Circle(25, 125, 4);
                    //Draw.Circle(75, 125, 4);
                    //Draw.Circle(125, 125, 4);
                    //Draw.Circle(275, 125, 4);
                    //Draw.Circle(375, 125, 4);
                    //Draw.Circle(75, 175, 4);
                    //Draw.Circle(325, 175, 4);
                    //Draw.Circle(375, 175, 4);
                    //Draw.Circle(25, 225, 4);
                    //Draw.Circle(75, 225, 4);
                    //Draw.Circle(25, 225, 4);
                    //Draw.Circle(25, 275, 4);
                    //Draw.Circle(125, 275, 4);
                    //Draw.Circle(275, 275, 4);
                    //Draw.Circle(325, 275, 4);
                    //Draw.Circle(375, 275, 4);
                    //Draw.Circle(125, 325, 4);
                    //Draw.Circle(175, 325, 4);
                    //Draw.Circle(225, 325, 4);
                    //Draw.Circle(375, 325, 4);
                    //Draw.Circle(25, 375, 4);
                    //Draw.Circle(75, 375, 4);
                    //Draw.Circle(275, 375, 4);
                    //Draw.Circle(200, 125, 4);
                    //Draw.Circle(200, 275, 4);
                }
            }

            // "Warp Pipes"
            //{
            //    Draw.FillColor = PurplePipes;
            //    Draw.LineColor = PipeBorder;
            //    Draw.LineSize = 5;
            //    Draw.Circle(25, 75, 25);
            //    Draw.Circle(175, 25, 25);
            //    Draw.Circle(325, 25, 25);
            //    Draw.Circle(375, 25, 25);
            //    Draw.Circle(175, 75, 25);
            //    Draw.Circle(225, 75, 25);
            //    Draw.Circle(275, 75, 25);
            //    Draw.Circle(25, 125, 25);
            //    Draw.Circle(75, 125, 25);
            //    Draw.Circle(125, 125, 25);
            //    Draw.Circle(275, 125, 25);
            //    Draw.Circle(375, 125, 25);
            //    Draw.Circle(75, 175, 25);
            //    Draw.Circle(325, 175, 25);
            //    Draw.Circle(375, 175, 25);
            //    Draw.Circle(25, 225, 25);
            //    Draw.Circle(75, 225, 25);
            //    Draw.Circle(25, 225, 25);
            //    Draw.Circle(25, 275, 25);
            //    Draw.Circle(125, 275, 25);
            //    Draw.Circle(275, 275, 25);
            //    Draw.Circle(325, 275, 25);
            //    Draw.Circle(375, 275, 25);
            //    Draw.Circle(125, 325, 25);
            //    Draw.Circle(175, 325, 25);
            //    Draw.Circle(225, 325, 25);
            //    Draw.Circle(375, 325, 25);
            //    Draw.Circle(25, 375, 25);
            //    Draw.Circle(75, 375, 25);
            //    Draw.Circle(275, 375, 25);
            //    Draw.Circle(200, 125, 25);
            //    Draw.Circle(200, 275, 25);
            //}

            //Draw Victory Pipe
            //Draw.FillColor = GoldenPipe;
            //Draw.LineColor = GPipeBorder;
            //Draw.LineSize = 5;
            //Draw.Circle(200, 200, 25);

            player.Render();
            player.HandlePlayerMovement();
            player.BorderCollision();
            player.Warp();
            player.FenceBorders();

            pipe.purplePipe();
            pipe.goldPipe();

            fences.fence();

            time.timer();

            //victory.winCondition();
            //victory.PlayGame();
            //victory.Winner();
            player.winCondition();
        }

    }

}
