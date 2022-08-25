using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class GreaterDigit
    {
        static int a=10;
             
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int r;
           
            int max = num % 10;
            while (num > 0)
            {
                r = num % 10;
                if (max < r)
                {
                    max = r;
                }
               num= num/ 10;
            }
            Console.WriteLine(max);
        }
    }
}
