using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test
{
    class ReverseMiddle
    {
        static string ReverseMidd(string s)
        {
            string rev = " ";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                string d = s.Substring(6, 6);
                string[] arr = s.Split(" ");
            }

            return rev;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            for(int i = 0; i < str.Length; i++)
            {
                string n = ReverseMidd(arr[i]);
                Console.WriteLine(n);
            }

            
        }
    }
}
