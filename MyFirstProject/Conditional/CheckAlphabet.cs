using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class CheckAlphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch>='A' && ch<='Z')
            {
                Console.WriteLine(ch+" is Alphabet");
            }

            else if(ch>='a' && ch<='z')
            {
                Console.WriteLine(ch+" Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine(ch+" Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }
        }
    }
}
