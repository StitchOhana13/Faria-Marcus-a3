using System;
using System.Collections.Generic;
//using System.Drawing;
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
        public float playerSpeed = 100;
        public float size;
        //public Rectangle playerSize = new Rectangle(playerPosiiton, playerPosition, 40, 40);
        public class Rectangle(Vector2 position, Vector2 size)
        {
            public Vector2 position = position;
            public Vector2 size = size;

        }

        static public Rectangle[] fences = [
            new Rectangle(new Vector2(0, 100), new Vector2(50, 3)), //1
            new Rectangle(new Vector2(0, 250), new Vector2(50, 3)), //2
            new Rectangle(new Vector2(0, 300), new Vector2(250, 3)), //3
            new Rectangle(new Vector2(50, 150), new Vector2(100, 3)), //4
            new Rectangle(new Vector2(50, 200), new Vector2(50, 3)), //5
            new Rectangle(new Vector2(50, 350), new Vector2(100, 3)), //6
            new Rectangle(new Vector2(100, 250), new Vector2(50, 3)), //7
            new Rectangle(new Vector2(150, 50), new Vector2(50, 3)), //8
            new Rectangle(new Vector2(150, 100), new Vector2(250, 3)), //9
            new Rectangle(new Vector2(200, 350), new Vector2(50, 3)), //10
            new Rectangle(new Vector2(250, 50), new Vector2(100, 3)), //11
            new Rectangle(new Vector2(250, 150), new Vector2(50, 3)), //12
            new Rectangle(new Vector2(250, 250), new Vector2(100, 3)), //13
            new Rectangle(new Vector2(300, 200), new Vector2(50, 3)), //14
            new Rectangle(new Vector2(350, 150), new Vector2(50, 3)), //15
            new Rectangle(new Vector2(350, 300), new Vector2(50, 3)), //16
            new Rectangle(new Vector2(100, 0), new Vector2(3, 250)), //17
            new Rectangle(new Vector2(150, 0), new Vector2(3, 50)), //18
            new Rectangle(new Vector2(350, 0), new Vector2(3, 50)), //19
            new Rectangle(new Vector2(200, 50), new Vector2(3, 50)), //20
            new Rectangle(new Vector2(250, 50), new Vector2(3, 100)), //21
            new Rectangle(new Vector2(50, 100), new Vector2(3, 50)), //22
            new Rectangle(new Vector2(150, 100), new Vector2(3, 50)), //23
            new Rectangle(new Vector2(300, 150), new Vector2(3, 250)), //24
            new Rectangle(new Vector2(50, 200), new Vector2(3, 50)), //25
            new Rectangle(new Vector2(350, 150), new Vector2(3, 50)), //26
            new Rectangle(new Vector2(150, 250), new Vector2(3, 100)), //27
            new Rectangle(new Vector2(250, 250), new Vector2(3, 50)), //28
            new Rectangle(new Vector2(350, 250), new Vector2(3, 50)), //29
            new Rectangle(new Vector2(200, 300), new Vector2(3, 50)), //30
            new Rectangle(new Vector2(50, 350), new Vector2(3, 50)), //31
            new Rectangle(new Vector2(250, 350), new Vector2(3, 50)), //32
        ];

        public Vector2 rectanglePosition1 = new Vector2(0, 100);
        public Vector2 rectanglePosition2 = new Vector2(0, 250);
        public Vector2 rectanglePosition3 = new Vector2(0, 300);
        public Vector2 rectanglePosition4 = new Vector2(50, 150);
        public Vector2 rectanglePosition5 = new Vector2(50, 200);
        public Vector2 rectanglePosition6 = new Vector2(50, 350);
        public Vector2 rectanglePosition7 = new Vector2(100, 250);
        public Vector2 rectanglePosition8 = new Vector2(150, 50);
        public Vector2 rectanglePosition9 = new Vector2(150, 100);
        public Vector2 rectanglePosition10 = new Vector2(200, 350);
        public Vector2 rectanglePosition11 = new Vector2(250, 50);
        public Vector2 rectanglePosition12 = new Vector2(250, 150);
        public Vector2 rectanglePosition13 = new Vector2(250, 250);
        public Vector2 rectanglePosition14 = new Vector2(300, 200);
        public Vector2 rectanglePosition15 = new Vector2(350, 150);
        public Vector2 rectanglePosition16 = new Vector2(350, 300);
        public Vector2 rectanglePosition17 = new Vector2(100, 0);
        public Vector2 rectanglePosition18 = new Vector2(150, 0);
        public Vector2 rectanglePosition19 = new Vector2(350, 0);
        public Vector2 rectanglePosition20 = new Vector2(200, 50);
        public Vector2 rectanglePosition21 = new Vector2(250, 50);
        public Vector2 rectanglePosition22 = new Vector2(50, 100);
        public Vector2 rectanglePosition23 = new Vector2(150, 100);
        public Vector2 rectanglePosition24 = new Vector2(300, 150);
        public Vector2 rectanglePosition25 = new Vector2(50, 200);
        public Vector2 rectanglePosition26 = new Vector2(350, 150);
        public Vector2 rectanglePosition27 = new Vector2(150, 250);
        public Vector2 rectanglePosition28 = new Vector2(250, 250);
        public Vector2 rectanglePosition29 = new Vector2(350, 250);
        public Vector2 rectanglePosition30 = new Vector2(200, 300);
        public Vector2 rectanglePosition31 = new Vector2(50, 350);
        public Vector2 rectanglePosition32 = new Vector2(250, 350);

        public Vector2 rectangleSize1 = new Vector2(50, 5);
        public Vector2 rectangleSize2 = new Vector2(50, 5);
        public Vector2 rectangleSize3 = new Vector2(250, 5);
        public Vector2 rectangleSize4 = new Vector2(100, 5);
        public Vector2 rectangleSize5 = new Vector2(50, 5);
        public Vector2 rectangleSize6 = new Vector2(100, 5);
        public Vector2 rectangleSize7 = new Vector2(50, 5);
        public Vector2 rectangleSize8 = new Vector2(50, 5);
        public Vector2 rectangleSize9 = new Vector2(250, 5);
        public Vector2 rectangleSize10 = new Vector2(50, 5);
        public Vector2 rectangleSize11 = new Vector2(100, 5);
        public Vector2 rectangleSize12 = new Vector2(50, 5);
        public Vector2 rectangleSize13 = new Vector2(100, 5);
        public Vector2 rectangleSize14 = new Vector2(50, 5);
        public Vector2 rectangleSize15 = new Vector2(50, 5);
        public Vector2 rectangleSize16 = new Vector2(50, 5);
        public Vector2 rectangleSize17 = new Vector2(5, 250);
        public Vector2 rectangleSize18 = new Vector2(5, 50);
        public Vector2 rectangleSize19 = new Vector2(5, 50);
        public Vector2 rectangleSize20 = new Vector2(5, 50);
        public Vector2 rectangleSize21 = new Vector2(5, 100);
        public Vector2 rectangleSize22 = new Vector2(5, 50);
        public Vector2 rectangleSize23 = new Vector2(5, 50);
        public Vector2 rectangleSize24 = new Vector2(5, 250);
        public Vector2 rectangleSize25 = new Vector2(5, 50);
        public Vector2 rectangleSize26 = new Vector2(5, 50);
        public Vector2 rectangleSize27 = new Vector2(5, 100);
        public Vector2 rectangleSize28 = new Vector2(5, 50);
        public Vector2 rectangleSize29 = new Vector2(5, 50);
        public Vector2 rectangleSize30 = new Vector2(5, 50);
        public Vector2 rectangleSize31 = new Vector2(5, 50);
        public Vector2 rectangleSize32 = new Vector2(5, 50);


        public void update()
        {
            fence();
        }

        public void fence()
        {
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Draw.LineSize = 5;
            Draw.Rectangle(rectanglePosition1, rectangleSize1);
            Draw.Rectangle(rectanglePosition2, rectangleSize2);
            Draw.Rectangle(rectanglePosition3, rectangleSize3);
            Draw.Rectangle(rectanglePosition4, rectangleSize4);
            Draw.Rectangle(rectanglePosition5, rectangleSize5);  //5
            Draw.Rectangle(rectanglePosition6, rectangleSize6);
            Draw.Rectangle(rectanglePosition7, rectangleSize7);
            Draw.Rectangle(rectanglePosition8, rectangleSize8);
            Draw.Rectangle(rectanglePosition9, rectangleSize9);
            Draw.Rectangle(rectanglePosition10, rectangleSize10); //10
            Draw.Rectangle(rectanglePosition11, rectangleSize11);
            Draw.Rectangle(rectanglePosition12, rectangleSize12);
            Draw.Rectangle(rectanglePosition13, rectangleSize13);
            Draw.Rectangle(rectanglePosition14, rectangleSize14); //
            Draw.Rectangle(rectanglePosition15, rectangleSize15); //15
            Draw.Rectangle(rectanglePosition16, rectangleSize16);
            Draw.Rectangle(rectanglePosition17, rectangleSize17);
            Draw.Rectangle(rectanglePosition18, rectangleSize18);
            Draw.Rectangle(rectanglePosition19, rectangleSize19);
            Draw.Rectangle(rectanglePosition20, rectangleSize20); //20
            Draw.Rectangle(rectanglePosition21, rectangleSize21);
            Draw.Rectangle(rectanglePosition22, rectangleSize22);
            Draw.Rectangle(rectanglePosition23, rectangleSize23);
            Draw.Rectangle(rectanglePosition24, rectangleSize24);
            Draw.Rectangle(rectanglePosition25, rectangleSize25); //25
            Draw.Rectangle(rectanglePosition26, rectangleSize26);
            Draw.Rectangle(rectanglePosition27, rectangleSize27);
            Draw.Rectangle(rectanglePosition28, rectangleSize28);
            Draw.Rectangle(rectanglePosition29, rectangleSize29);
            Draw.Rectangle(rectanglePosition30, rectangleSize30); //30
            Draw.Rectangle(rectanglePosition31, rectangleSize31);
            Draw.Rectangle(rectanglePosition32, rectangleSize32); //32
        }

        static public bool FenceCheck(Vector2 checkPosition, Vector2 checkSize)
        {
            float checkLeft = checkPosition.X;
            float checkTop = checkPosition.Y;
            float checkRight = checkPosition.X + checkSize.X;
            float checkBottom = checkPosition.Y + checkSize.Y;

            foreach (Rectangle fence in fences)
            {
                float fenceLeft = fence.position.X;
                float fenceTop = fence.position.Y;
                float fenceRight = fence.position.X + fence.size.X;
                float fenceBottom = fence.position.Y + fence.size.Y;

                // Check if there is any overlap
                if (checkLeft < fenceRight && checkRight > fenceLeft &&
                    checkTop < fenceBottom && checkBottom > fenceTop)
                {
                    return false; // Overlap detected
                }
            }
            return true; // No overlaps
        }
    }
}
