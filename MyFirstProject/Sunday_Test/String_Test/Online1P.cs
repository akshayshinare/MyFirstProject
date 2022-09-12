using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test
{
    class Online1P
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter word");
            string s2 = Console.ReadLine();
            int c = 0;
            string[] arr = s1.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == s2)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
