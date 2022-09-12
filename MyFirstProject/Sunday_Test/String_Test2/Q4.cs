using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test2
{
    class Q4
    {
        //Incomplite Program
        public static void Fascinating(int n)
        {
            string s = "";
            for(int i = 1; i <= 3; i++)
            {
                s = s + i * n;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

        }
    }
}
