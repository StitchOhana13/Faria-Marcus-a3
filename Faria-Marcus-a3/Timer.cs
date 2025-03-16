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
        float secondsElapsed = Time.SecondsElapsed;

        public void update()
        {
            timer();
        }

        public void timer()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Blue;
            Draw.LineSize = 2;
            Draw.Rectangle(305, 350, 100, 50);

            Text.Size = 20;
            Text.Draw($"{secondsElapsed}", 310, 355);
        }
    }
}
