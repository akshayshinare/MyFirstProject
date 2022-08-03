using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class SumofEven
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i=2;i<=10;i+=2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
