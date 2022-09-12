using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class ArithmaticProgression
    {
        static void Main(string[] args)
        {
            //Arithmatic Progression
            Console.WriteLine("enter second number");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter position");
            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;

            for (int i = 4; i <= n; i++)
            {
                a3 = a3 + d;

            }
            Console.WriteLine(a3);
        }
    }
}
