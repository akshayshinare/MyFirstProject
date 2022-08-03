using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class PerClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Percentage");
            double Per = double.Parse(Console.ReadLine());

            if(Per>=70)
            {
                Console.WriteLine("You are distinction");
            }
            else if(Per>60)
            {
                Console.WriteLine("You are First Class");
            }
            else if(Per>50)
            {
                Console.WriteLine("You are Second Class");
            }
            else if(Per>35)
            {
                Console.WriteLine("You are Pass Class");
            }
            else
            {
                Console.WriteLine("You are Faill!");
            }
        }
    }
}
