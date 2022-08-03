using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops.Conditional_Assignment
{
    class Maximum3digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("num1 is greater");
                }
                else
                {
                    Console.WriteLine("num3 is greater ");
                }
            }
            else if(num2>num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
        }
    }
}
