using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class PerOryear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter year");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Percentage");
            int per = int.Parse(Console.ReadLine());

            if(year==2021)
            {
                if(per>=60)
                {
                    Console.WriteLine("You are eligible for interview");
                }
                else
                {
                    Console.WriteLine("You are Not eligible for interview");
                }
            }
            else
            {
                Console.WriteLine("You are Not eligible for interview");
            }
        }
    }
}
