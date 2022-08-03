using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class PowerBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base value");
            int bnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter exponent value");
            int expo = int.Parse(Console.ReadLine());

            int power = 1;
            int i = 1;

            while(i<=expo)
            {
                power = power * bnum;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
