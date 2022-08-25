using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class SentenceRever
    {
        static string Reverse(string s)
        {
            string rev = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            string s = "Shanaya goes to bishops school";
            string[] sarr = s.Split(" ");

            for(int i = 0; i < sarr.Length; i++)
            {
                string r = Reverse(sarr[i]);
                Console.Write(r+" ");
            }
        }
    }
}
