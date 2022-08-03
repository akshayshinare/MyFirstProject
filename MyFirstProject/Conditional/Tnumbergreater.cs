using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Tnumbergreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1 > num2 ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2 : num3;

            Console.WriteLine(max);

        }
    }
}
