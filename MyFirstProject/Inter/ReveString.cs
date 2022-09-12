using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inter
{
    class ReveString
    {
        public static void Rstring(string s)
        {
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
        static void Main(string[] args)
        {
            string s = "Akshay";
            Rstring(s);
        }
    }
}
