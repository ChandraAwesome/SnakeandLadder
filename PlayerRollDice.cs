using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class PlayerRollDice
    {
        public static void RollingDice() 
        {
            Random random= new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Player got the number after roll the dice is : "+dice);
        } 
    }
}
