using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class Coprime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int c = 0;
            for(int i = 0; i < 100; i++)
            {
                if((num1%i==0) && (num2 % i == 0))
                {
                    Console.WriteLine(i);
                    c++;
                }
            }
            if (c == 1)
            {
                Console.WriteLine();
            }
        }
    }
}
