using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Warps
    {
        public Vector2 playerPosition = new Vector2();
        public float playerSpeed = 100;
        public float size;
        public Vector2 velocity;
        public Vector2 objectPositionA1 = new Vector2(25, 75);
        public Vector2 newPositionK1 = new Vector2(175, 350);


        internal void update()
        {
            WarpPipes();
            //Warp();
        }


        public void WarpPipes()
        {
            Draw.FillColor = Color.Red;
            Draw.Circle(25, 75, 4);
            Draw.Circle(175, 25, 4);
            Draw.Circle(325, 25, 4);
            Draw.Circle(375, 25, 4);
            Draw.Circle(175, 75, 4);
            Draw.Circle(225, 75, 4);
            Draw.Circle(275, 75, 4);
            Draw.Circle(25, 125, 4);
            Draw.Circle(75, 125, 4);
            Draw.Circle(125, 125, 4);
            Draw.Circle(275, 125, 4);
            Draw.Circle(375, 125, 4);
            Draw.Circle(75, 175, 4);
            Draw.Circle(325, 175, 4);
            Draw.Circle(375, 175, 4);
            Draw.Circle(25, 225, 4);
            Draw.Circle(75, 225, 4);
            Draw.Circle(25, 225, 4);
            Draw.Circle(25, 275, 4);
            Draw.Circle(125, 275, 4);
            Draw.Circle(275, 275, 4);
            Draw.Circle(325, 275, 4);
            Draw.Circle(375, 275, 4);
            Draw.Circle(125, 325, 4);
            Draw.Circle(175, 325, 4);
            Draw.Circle(225, 325, 4);
            Draw.Circle(375, 325, 4);
            Draw.Circle(25, 375, 4);
            Draw.Circle(75, 375, 4);
            Draw.Circle(275, 375, 4);
            Draw.Circle(200, 125, 4);
            Draw.Circle(200, 275, 4);
        }
        //public void Warp()
        //{
        //    if (Vector2.Distance(playerPosition, objectPositionA1) < 10)
        //    {
        //        playerPosition = newPositionK1;
        //    }
        //}
        
    }
}
