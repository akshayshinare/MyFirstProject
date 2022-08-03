using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
