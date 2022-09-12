using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string s1 = "listen";
            string s2 = "silent";

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            if (string.Join("", arr1) == string.Join("", arr2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
