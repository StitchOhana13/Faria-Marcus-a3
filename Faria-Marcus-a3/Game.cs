// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;

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
        Color FrogBodyLight = new Color("#74bb1f"); //Frog player body colour light
        Color FrogBodyDark = new Color("#437013"); //Frog player body colour dark
        Color Frogcheeks = new Color("#ffcde9"); //Frog cheek colour

        Texture2D Frog = Graphics.LoadTexture("../../../../Assets/Graphics/Frog.png");

        float playerSpeed = 100;

        public void Setup()
        {
            Window.SetTitle("Warp Pipe Dream");
            Window.SetSize(400, 400);

            Console.WriteLine(Directory.GetCurrentDirectory());
        }

        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            PlayerMovement();

            //can't change the background colour the my grass green variable so big square over top of it
            Draw.FillColor = GrassGreen;
            Draw.LineColor = GrassGreen;
            Draw.Square(0, 0, 400);

            // "Warp Pipes"
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

            //Draw Victory Pipe
            Draw.FillColor = GoldenPipe;
            Draw.LineColor = GPipeBorder;
            Draw.LineSize = 5;
            Draw.Circle(200, 200, 25);

            // Fences
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

            Graphics.Draw(Frog, 0, 0);

            // Draw Frog player (Implementing another way)
            {
/*                Draw.FillColor = FrogBodyLight;
                Draw.LineColor = FrogBodyLight;
                Draw.Circle(115, 85, 5);
                Draw.Circle(85, 85, 5);

                Draw.FillColor = Color.White;
                Draw.LineColor = Color.White;
                Draw.Circle(115, 85, 3);
                Draw.Circle(85, 85, 3);

                Draw.FillColor = Color.Black;
                Draw.LineColor = Color.Black;
                Draw.Circle(115, 85, 2);
                Draw.Circle(85, 85, 2);

                Draw.FillColor = FrogBodyLight;
                Draw.LineColor = FrogBodyLight;
                Draw.Circle(100, 100, 15);

                Draw.FillColor = FrogBodyDark;
                Draw.LineColor = FrogBodyDark;
                Draw.Arc(100, 100, 40, 40, -180, -360);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 3;
                Draw.Line(116, 100, 84, 100);

                Draw.FillColor = Frogcheeks;
                Draw.LineColor = Frogcheeks;
                Draw.Circle(115, 100, 3);
                Draw.Circle(85, 100, 3);*/

            }

            void PlayerMovement();

            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                Frog.X += Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))

            {
                Frog.X -= Time.DeltaTime * playerSpeed;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                Frog.X += Time.DeltaTime * playerSpeed;
            }

            if (Input.IsKeyboardKeyDown(KeyboardInput.Down))

            {
                Frog.X -= Time.DeltaTime * playerSpeed;
            }
        }
    }

}
