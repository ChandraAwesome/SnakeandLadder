using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Exactwinning
    {
        public static void Exactwin() 
        {
            int position = 0;
            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                position = position + dice;
                if (position == 100)
                {
                    Console.WriteLine("Player won the game :" + position);
                    break;
                }
                else if (position >= 100)
                {
                    int sameposition = position - dice;
                    Console.WriteLine("same position :"+sameposition);
                }
                else
                {
                    //Console.WriteLine("");
                    //Console.WriteLine("Position is :"+position);
                    Console.WriteLine("Roll dice again :" + dice);
                }
            }

        }
    }
}
