using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class CheckLargNum
    {
        public void CheckLargNumber()
        {
            Console.WriteLine("Enter num1 ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter num3 ");
            int num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine(num1 + " large number");

            if (num2 > num1 && num2 > num3)
                Console.WriteLine(num2 + " large number");

            if (num3 > num1 && num3 > num2)
                Console.WriteLine(num3 + " large number");
        }
    }
}
