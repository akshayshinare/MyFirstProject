﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
