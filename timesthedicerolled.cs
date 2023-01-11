using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class timesthedicerolled
    {
        public static void Times()
        {
            int position = 0;
            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                //
                position = position + dice;
                if (position == 100)
                {
                    Console.WriteLine("Player won the game :" + position);
                    break;
                }
                else if (position <= 0)
                {
                    Console.WriteLine("Starts the game again");
                }
                else
                {
                    //Console.WriteLine("");
                    Console.WriteLine("Position is :" + position);
                    Console.WriteLine("Roll dice again :" + dice);
                }
            }
        }
    }
}
