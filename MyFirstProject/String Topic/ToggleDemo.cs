using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class ToggleDemo
    {
        static void Toggle(string s)
        {
            string T = "";
            foreach(char c in s)
            {
                if (char.IsUpper(c))
                {
                    char ch = char.ToLower(c);
                    T = T + ch;
                }
                else if (char.IsLower(c))
                {
                    T=T+ char.ToUpper(c);
                }
            }
            Console.WriteLine(T);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string st = Console.ReadLine();

            Toggle(st);
        }
    }
}
