using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class PalindromString
    {
        static void Main(string[] args)
        {

            string s2 = "ko";
            string s = "";

            for(int i =s2.Length-1 ; i>=0; i--)
            {
                s = s + s2[i];
            }

            if (s2==s)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            } 
        }
    }
}
