using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class Optiongame
    {
        public static void Options() 
        {
            Random random= new Random();
            int dice=random .Next(1,7);
            int option=random .Next(0,3);
            //
            if (dice <= 6)
            {
                if (option == 0)
                {
                    Console.WriteLine("Position of player is same :" + (dice = dice + option));
                }
                else if (option == 1)
                {
                    Console.WriteLine("Player moves ahead for Got ladder :" + (dice = dice + option));
                }
                else
                {
                    Console.WriteLine("Player moves behind for Got hit by snake :" + (dice = dice - option));
                }
            }

        }
    }
}
