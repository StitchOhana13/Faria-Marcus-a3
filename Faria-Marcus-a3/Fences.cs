using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Fences
    {
        public float colliderSize = 0;
        public Vector2 playerPosition = new Vector2(0, 0);
        public float playerSpeed = 100;
        public float size;
        public Vector2 rectanglePosition1 = new Vector2(0, 100);
        public Vector2 rectanglePosition2 = new Vector2(0, 250);

        public Vector2 rectangleSize1 = new Vector2(50, 5);
        public Vector2 rectangleSize2 = new Vector2(50, 5);

        public void update()
        {
            fence();
            FB();
        }

        public void fence()
        {
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Draw.LineSize = 5;
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

        public void FB()
        {
            //bool isCollideLeft = playerPosition.X - colliderSize <= 0;
            //bool isCollideRight = playerPosition.X - colliderSize >= 350;
            //bool isCollideTop = playerPosition.Y - colliderSize <= 0;
            //bool isCollideBottom = playerPosition.Y + colliderSize >= 350;
            //if(playerPosition.X > 
        }
    }
}
