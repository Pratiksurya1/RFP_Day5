using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Vowel
    {
        public void checkeAlfa()
        {

            Console.WriteLine("Enter char vlaue ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine(ch + " is vowel");
            else if (ch < 'a' && ch > 'z')
                Console.WriteLine(ch + " is not vowel");
            else
                Console.WriteLine(ch + " is not vowel ");

        }
    }
}