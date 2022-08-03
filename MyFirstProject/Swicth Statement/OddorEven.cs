using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Swicth_Statement
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            switch(num%2)
            {
                case 0: Console.WriteLine("Even");
                    break;
                case 1: Console.WriteLine("Odd");
                    break;

            }
        }
    }
}
