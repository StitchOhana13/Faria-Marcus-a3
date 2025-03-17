using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MohawkGame2D;

namespace Faria_Marcus_a3
{
    internal class Timer
    {
        public float secondsElapsed = Time.SecondsElapsed;

        public void update()
        {
            timer();
            float secondElapsed = Time.SecondsElapsed;
        }

        public void timer()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Blue;
            Draw.LineSize = 2;
            Draw.Rectangle(305, 350, 100, 50);

            string elapsedTime = secondsElapsed.ToString();

            Text.Size = 20;
            Text.Draw(elapsedTime, 310, 355);
        }
    }
}
