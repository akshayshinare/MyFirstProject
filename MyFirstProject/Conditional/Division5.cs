using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Division5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else
            {
                Console.WriteLine("Not divisible by 5");
            }
        }
    }
}
