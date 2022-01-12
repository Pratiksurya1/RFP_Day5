using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class harmonicNum : Program
    {
        float sum=1;
        public void harmoic()
        {
            Console.WriteLine("Enter Nth harmonic vlaue...");
           int n= Int32.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    sum += (float)1 / i;
                }
                Console.WriteLine("Ans :- "+sum);
            }
            else
            {
                Console.WriteLine(n+" is negative value...");
            }
            
        }
    }
}
