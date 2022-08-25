using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class FirstOccurenceString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s1 = Console.ReadLine();

            Console.WriteLine("enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            int Sindex = s1.IndexOf(ch);

            Console.WriteLine(Sindex);
        }
    }
}
