using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
    class BinaryTodecomal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Binary number");
            int num = int.Parse(Console.ReadLine());
           
            int dec = 0;
            int bas = 1;
            int r;

            while (num > 0)
            {
                r = num % 10;
                dec = dec + r * bas;
                num = num / 10;
                bas = bas * 2;
            }
            Console.WriteLine(dec);
        }
    }
}
