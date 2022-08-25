using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "akshayshinare";
            string str1="";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(str1);
        }
    }
}
