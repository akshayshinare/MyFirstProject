using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Loops_Test3
{
    class MobileNum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Mobile Number");
            long num =long.Parse(Console.ReadLine());
            long r;
            int c = 0;
            while (num > 0)
            {
                r = num % 10;
                num = num / 10;
                c++;
            }
            Console.WriteLine("Frequency of digit= "+c);
        }
    }
}
