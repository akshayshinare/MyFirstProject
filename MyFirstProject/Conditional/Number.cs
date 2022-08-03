using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Number
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter 1st Number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine(num1 + "Is Greater");

            }
            else
            {
                Console.WriteLine(num2 + "Is Greater");
            }
        }
    }
}
