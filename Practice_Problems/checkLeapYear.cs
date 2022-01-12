using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class checkLeapYear : Program
    {
        public int input()
        {
            Console.WriteLine("Enter year");
             String n = Console.ReadLine();
             int year = Convert.ToInt32(n);
            if (n.Length == 4)
                return year;
            else
                return 0;
        }
        public void leapYear() 
        {
            while (true)
            {
                int num=input();
                if(num == 0)
                    Console.WriteLine(" \n Enter 4 digit vlaue \n");
                else
                {
                    if (((num % 4 == 0) && (num % 100 != 0)) || (num == 400))
                    {
                        Console.WriteLine(num + " is leap year");
                    }
                    else
                    {
                        Console.WriteLine(num + " is not a leap year");
                    }
                    break;
                }
            }
        }
    }
}
