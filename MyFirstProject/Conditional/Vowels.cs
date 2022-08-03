using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Character");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch=='A')
            {
                Console.WriteLine("is Vowel");
            }
            else if (ch =='e' || ch=='E')
            {
                Console.WriteLine("is Vowel");
            }
            else if(ch=='i' || ch=='I')
            {
                Console.WriteLine("is Vowel");
            }
            else if(ch=='o' || ch=='O')
            {
                Console.WriteLine("is Vowel");
            }
            else if(ch=='u' || ch=='U')
            {
                Console.WriteLine("is Vowel");
            }
            else
            {
                Console.WriteLine("is not Vowel");
            }

        }
    }
}
