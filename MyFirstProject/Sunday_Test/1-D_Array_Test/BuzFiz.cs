using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    class BuzFiz
    {
        static void Main(string[] args)
        {
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            for(int i = 1; i < 50; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("buzzfizz");
                    c3++;
                }
               else if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                    c1++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    c2++;
                }
               
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("buzz= " + c1);
            Console.WriteLine("fizz= " + c2);
            Console.WriteLine("buzzfizz= " + c3);
        }
    }
}
