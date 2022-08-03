using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class BloodElegible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Weight");
            int wt = int.Parse(Console.ReadLine());


            if(age>=18)
            {
                if(wt>=50)
                {
                    Console.WriteLine("You are eligible");
                }
                else
                {
                    Console.WriteLine("You are not eligible");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible");
            }
        }
    }
}
