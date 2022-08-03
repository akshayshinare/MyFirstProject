using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class LoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            int r;
            int sum = 0;
            while(num>0)
            {
                r = num % 10;
                sum = sum + r;

                num = num / 10;
            }
            if(sum%10==0)
            {
                Console.WriteLine("IMEI Number");
            }
            else
            {
                Console.WriteLine("not ImEI number");
            }
        }
    }
}
