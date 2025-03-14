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
        Color PurplePipes = new Color("#8058b6"); //Pipe colour
        Color PipeBorder = new Color("#58308d"); //pipe border colour
        Color GoldenPipe = new Color("#ebb81e"); //Victory Pipe Colour
        Color GPipeBorder = new Color("#b68a05"); //victory pipe border
        // Color FrogBodyLight = new Color("#74bb1f"); //Frog player body colour light
        // Color FrogBodyDark = new Color("#437013"); //Frog player body colour dark
        // Color Frogcheeks = new Color("#ffcde9"); //Frog cheek colour

        Player player;
        Texture2D Frog = Graphics.LoadTexture("../../../../Assets/Graphics/Frog.png");
        //Vector2 playerPosition = new Vector2(50, 50);
        //float playerSpeed = 100;
        //Vector2 size;
        //Vector2 velocity;
        //Vector2 position;
        //bool hasHitScreenEdge;


        public void Setup()
        {
            Window.SetTitle("Warp Pipe Dream");
            Window.SetSize(400, 400);

            player = new Player();
            player.playerPosition = new Vector2(0, 0);

        }

        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            //HandlePlayerMovement();
            

            //can't change the background colour the my grass green variable so big square over top of it
            Draw.FillColor = GrassGreen;
            Draw.LineColor = GrassGreen;
            Draw.Square(0, 0, 400);

            // "Warp Pipes"
            {
                Draw.FillColor = PurplePipes;
                Draw.LineColor = PipeBorder;
                Draw.LineSize = 5;
                Draw.Circle(25, 75, 25);
                Draw.Circle(175, 25, 25);
                Draw.Circle(325, 25, 25);
                Draw.Circle(375, 25, 25);
                Draw.Circle(175, 75, 25);
                Draw.Circle(225, 75, 25);
                Draw.Circle(275, 75, 25);
                Draw.Circle(25, 125, 25);
                Draw.Circle(75, 125, 25);
                Draw.Circle(125, 125, 25);
                Draw.Circle(275, 125, 25);
                Draw.Circle(375, 125, 25);
                Draw.Circle(75, 175, 25);
                Draw.Circle(325, 175, 25);
                Draw.Circle(375, 175, 25);
                Draw.Circle(25, 225, 25);
                Draw.Circle(75, 225, 25);
                Draw.Circle(25, 225, 25);
                Draw.Circle(25, 275, 25);
                Draw.Circle(125, 275, 25);
                Draw.Circle(275, 275, 25);
                Draw.Circle(325, 275, 25);
                Draw.Circle(375, 275, 25);
                Draw.Circle(125, 325, 25);
                Draw.Circle(175, 325, 25);
                Draw.Circle(225, 325, 25);
                Draw.Circle(375, 325, 25);
                Draw.Circle(25, 375, 25);
                Draw.Circle(75, 375, 25);
                Draw.Circle(275, 375, 25);
                Draw.Circle(200, 125, 25);
                Draw.Circle(200, 275, 25);
            }

            //Draw Victory Pipe
            Draw.FillColor = GoldenPipe;
            Draw.LineColor = GPipeBorder;
            Draw.LineSize = 5;
            Draw.Circle(200, 200, 25);

            // Fences
            {
                Draw.FillColor = Color.White;
                Draw.LineColor = Color.White;
                Draw.Rectangle(0, 100, 50, 5);
                Draw.Rectangle(0, 250, 50, 5);
                Draw.Rectangle(0, 300, 250, 5);
                Draw.Rectangle(50, 150, 100, 5);
                Draw.Rectangle(50, 200, 50, 5);
                Draw.Rectangle(50, 350, 100, 5);
                Draw.Rectangle(100, 250, 50, 5);
                Draw.Rectangle(150, 50, 50, 5);
                Draw.Rectangle(150, 100, 250, 5);
                Draw.Rectangle(200, 350, 50, 5);
                Draw.Rectangle(250, 50, 100, 5);
                Draw.Rectangle(250, 150, 50, 5);
                Draw.Rectangle(250, 250, 100, 5);
                Draw.Rectangle(300, 200, 50, 5);
                Draw.Rectangle(350, 150, 50, 5);
                Draw.Rectangle(350, 300, 50, 5);
                Draw.Rectangle(100, 0, 5, 250);
                Draw.Rectangle(150, 0, 5, 50);
                Draw.Rectangle(350, 0, 5, 50);
                Draw.Rectangle(200, 50, 5, 50);
                Draw.Rectangle(250, 50, 5, 100);
                Draw.Rectangle(50, 100, 5, 50);
                Draw.Rectangle(150, 100, 5, 50);
                Draw.Rectangle(300, 150, 5, 250);
                Draw.Rectangle(350, 150, 5, 50);
                Draw.Rectangle(50, 200, 5, 50);
                Draw.Rectangle(150, 250, 5, 100);
                Draw.Rectangle(250, 250, 5, 50);
                Draw.Rectangle(350, 250, 5, 50);
                Draw.Rectangle(200, 300, 5, 50);
                Draw.Rectangle(50, 350, 5, 50);
                Draw.Rectangle(250, 350, 5, 50);
            }

            player.Render();
            player.HandlePlayerMovement();
            player.BorderCollision();
        }

    }

}
