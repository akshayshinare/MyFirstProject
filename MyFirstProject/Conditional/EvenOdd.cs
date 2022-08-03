using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());

            if(num1%2==0)
            {
                Console.WriteLine("This is Even Number");

            }
            else
            {
                Console.WriteLine("This is Odd Number");
            }
        }
    }
}
