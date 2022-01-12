using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class powerOfTwo : Program
    {
        public void Power()
        {
            Console.WriteLine("Enter 2^N value");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("________________________");
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int table = i * 2;
                    Console.WriteLine(2+" * "+i+" = "+table);
                }
            }
            else
            {
                Console.WriteLine(n+" is negative value");
            }

        }
    }
}
