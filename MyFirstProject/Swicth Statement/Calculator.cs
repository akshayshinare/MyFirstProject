using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swicth_Statement
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Choice \n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter your choice");

            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("Addition   " +(num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction  " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication  " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division  " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

                    

            }
        }
    }
}
