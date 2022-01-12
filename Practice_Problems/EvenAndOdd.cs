using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class EvaAndOdd
    {
        public void checkEvAndOdd()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)

                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");

        }
    }
}
