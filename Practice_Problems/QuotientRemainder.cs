using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class QuotientRemainder

    {
        public void checkQuotientRemainder()
        {
            Console.WriteLine("Enter divident vlaue :- ");
            int divident = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor vlaue :- ");
            int divisor = Int32.Parse(Console.ReadLine());

            int remainder = divident % divisor;
            int quotient = divident / divisor;

            Console.WriteLine("Quotient " + quotient);
            Console.WriteLine("Remainder " + remainder);
        }
    }
}
