using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    public class StartPositionwith0
    {
        public static void Player()
        {
            Random random= new Random();
            int dice = random.Next(1,7);
            //
            int position = 0;
            if (dice<6)
                Console.WriteLine("Player position starts with : "+position);
        }
        
    }
}
