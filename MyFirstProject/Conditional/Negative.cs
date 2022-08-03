using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class Negative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("Number Is Positive");
            }
            else if(0>num)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
