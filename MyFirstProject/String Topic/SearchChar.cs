using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class SearchChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s1 = Console.ReadLine();

            Console.WriteLine("enter charcter");
            char ch = Convert.ToChar(Console.ReadLine());

            int c = 0;

            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ch)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
