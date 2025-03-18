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
        public float secondsElapsed;
        Player player;

        public void update()
        {
            timer();
            secondsElapsed += Time.DeltaTime;

            player = new Player();
            player.winCondition();
            player.PlayGame();

            if (player.isWinner)
            {
                secondsElapsed += Time.DeltaTime;
                Console.WriteLine("YES YES YES");
            }
            else
            {
                player.PlayGame();
            }
        }

        public void timer()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Blue;
            Draw.LineSize = 2;
            Draw.Rectangle(305, 350, 100, 50);

            string DeltaTime = secondsElapsed.ToString();

            Text.Size = 20;
            Text.Draw(DeltaTime, 310, 355);

            //Console.WriteLine(secondsElapsed);


        }

    }
}
