using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class SwapNum
    {
       public void numSwap()
        {
            int num1= 54;
            int num2 = 23;
            Console.WriteLine("Before swap num1= " + num1 + " num2= " + num2);
            num1 = num1 * num2;       
            num2 = num1 / num2;       
            num1 = num1 / num2;     
            Console.Write("After swap num2= " + num1 + " num2= " + num2);
        }
    }
}
