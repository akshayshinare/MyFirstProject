using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class P8
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;

            for(int i=0;i<=20;i++)
            {
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;

                Console.WriteLine(num3);
            }
            
        }
    }
}
