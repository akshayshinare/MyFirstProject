using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            int mul = 0;
            for(int i = 0; i < num2; i++)
            {
                mul = mul +num1 ;
            }
            Console.WriteLine(mul);

        }
    }
}
