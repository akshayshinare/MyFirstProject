using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class RemoveDublicate
    {
        static void Main(string[] args)
        {
            string s1 = "asabcc";
            string s2 = "";
           
            foreach(char ch in s1)
            {
                if (!s2.Contains(ch))
                {
                    s2 = s2 + ch;
                }
            }
            Console.WriteLine(s2);
        }
    }
}
