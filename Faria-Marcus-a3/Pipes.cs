using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Pipes
    {
        Color PurplePipes = new Color("#8058b6"); //Pipe colour
        Color PipeBorder = new Color("#58308d"); //pipe border colour
        Color GoldenPipe = new Color("#ebb81e"); //Victory Pipe Colour
        Color GPipeBorder = new Color("#b68a05"); //victory pipe border

        public void update()
        {
            pipeDrawing();
            goldPipe();
        }

        //Draw pipes
        public void pipeDrawing()
        {
            //Draw.FillColor = PurplePipes;
            //Draw.LineColor = PipeBorder;
            //Draw.LineSize = 5;
            //Draw.Circle(25, 75, 25);
            //Draw.Circle(175, 25, 25);
            //Draw.Circle(325, 25, 25);
            //Draw.Circle(375, 25, 25);
            //Draw.Circle(175, 75, 25);
            //Draw.Circle(225, 75, 25);
            //Draw.Circle(275, 75, 25);
            //Draw.Circle(25, 125, 25);
            //Draw.Circle(75, 125, 25);
            //Draw.Circle(125, 125, 25);
            //Draw.Circle(275, 125, 25);
            //Draw.Circle(375, 125, 25);
            //Draw.Circle(75, 175, 25);
            //Draw.Circle(325, 175, 25);
            //Draw.Circle(375, 175, 25);
            //Draw.Circle(25, 225, 25);
            //Draw.Circle(75, 225, 25);
            //Draw.Circle(25, 225, 25);
            //Draw.Circle(25, 275, 25);
            //Draw.Circle(125, 275, 25);
            //Draw.Circle(275, 275, 25);
            //Draw.Circle(325, 275, 25);
            //Draw.Circle(375, 275, 25);
            //Draw.Circle(125, 325, 25);
            //Draw.Circle(175, 325, 25);
            //Draw.Circle(225, 325, 25);
            //Draw.Circle(375, 325, 25);
            //Draw.Circle(25, 375, 25);
            //Draw.Circle(75, 375, 25);
            //Draw.Circle(275, 375, 25);
            //Draw.Circle(200, 125, 25);
            //Draw.Circle(200, 275, 25);
        }

        public void purplePipe()
        {
            Draw.FillColor = PurplePipes;
            Draw.LineColor = PipeBorder;
            Draw.LineSize = 5;
            int[] pipePositions =
            {
                25, 75, 175, 25, 325, 25, 375, 25, 175, 75,
                225, 75, 275, 75, 25, 125, 75, 125, 125, 125,
                275, 125, 375, 125, 75, 175, 325, 175, 375, 175,
                25, 225, 75, 225, 125, 275, 275, 275, 325, 275,
                375, 275, 125, 325, 175, 325, 225, 325, 375, 325,
                25, 375, 75, 375, 225, 375, 200, 125, 200, 275,
                25, 275, 325, 225
            };

            for (int i = 0; i < pipePositions.Length; i += 2)
            {
                Draw.Circle(pipePositions[i], pipePositions[i +1], 25);
            }
        }

        public void goldPipe()
        {
            Draw.FillColor = GoldenPipe;
            Draw.LineColor = GPipeBorder;
            Draw.LineSize = 5;
            Draw.Circle(200, 200, 25);
        }
    }
}
