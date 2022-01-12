using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class Program
    {
       public static void Main(String[] args)
        {
            Console.WriteLine("\n ===== First problem ===== \n");
            FlipCoin.Toss();

            Console.WriteLine("\n ===== Second problem ===== \n");
            Practice_Problems.checkLeapYear ch = new checkLeapYear();
            ch.leapYear();

            Console.WriteLine("\n ==== Third problem ===== \n");
            Practice_Problems.powerOfTwo power = new powerOfTwo();
            power.Power();

            Console.WriteLine("\n ===== Forth problem =====\n");
            Practice_Problems.harmonicNum har=new harmonicNum();
            har.harmoic();

            Console.WriteLine("\n ===== Five problem =====\n");
            Practice_Problems.PrimeFactor pf = new PrimeFactor();
            pf.PFactor();

            Console.WriteLine("\n ===== Sixth problem =====\n");
            Practice_Problems.RandomNum ran = new RandomNum();
            ran.romdomNum();

            FlipCoin.Toss();
        }
    }
}