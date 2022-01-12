using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    public class RandomNum
    {
        public void romdomNum()
        {
            Random random = new Random();
            int num = random.Next(2);
            if (num == 0)
                Console.WriteLine("emp is presant");
            else
                Console.WriteLine("emp is absent ");
        }
    }
}
