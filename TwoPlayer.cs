using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class TwoPlayer
    {
        public static void Won()
        {
            /*int position1 = 0;                                 I TRIED THIS BUT, I AM NOT GETTING THE REQUIRED OUTPUT, SO PLEASE GIVE ME SOME TIME
             *                                                   THANK YOU.
            int position2 = 0;
            while (position1<=100 && position2<=100)
            {
                Random random= new Random();
                int dice=random.Next(1,7);
                //int dice2 = random.Next(1,7);
                //
                position1 = position1 + dice;
                position2 = position2 + dice;
                if (position1==100 && dice<=6)
                {
                    Console.WriteLine("Player1 won the game");
                }
                //else if (position2==100 && dice<=6)
                //{
                  //  Console.WriteLine("Player2 won the game");
                    //break;
                //}
                else 
                {
                    Console.WriteLine("Roll the dice again :" + dice);
                }
            }
        }
    }
}
