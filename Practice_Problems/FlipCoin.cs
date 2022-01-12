using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class FlipCoin
    {
        public static void Toss()
        {
            Random random = new Random();
            int coin = random.Next(2);
            if (coin == 0)
                Console.WriteLine("Tails");
            else
                Console.WriteLine("Heads");
        }
    }
}
