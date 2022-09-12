using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inter
{
    class StringRev
    {
        public static void RString(string s1)
        {
            
            string[] a = s1.Split();
            for(int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            string s = "This is a notepad";
            RString(s);
        }
    }
}
