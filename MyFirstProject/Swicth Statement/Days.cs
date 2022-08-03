using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swicth_Statement
{
    class Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wedansday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Satarday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }
    }
}
