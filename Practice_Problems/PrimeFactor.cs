using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class PrimeFactor : Program
    {
        bool flag=false;
        public void PFactor()
        {
            Console.WriteLine(" Enter number to find the prime factors ");
            int num=Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            for(int i=2; i<=num; i++)
            {
                if(num%i==0)
                {
                    flag=true;
                    for(int j=2; j<=i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                        if (flag == true)
                            Console.WriteLine(" Prime factors :- "+i);
                }
            }
        }
    }
}
