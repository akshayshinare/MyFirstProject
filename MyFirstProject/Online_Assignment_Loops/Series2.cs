using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class Series2
    {
        static void Main(string[] args)
        {
            int mul = 2;
            for(int i = 1; i <= 8; i++)
            {
                mul = mul * 2 - 1;
                Console.WriteLine(mul);
            }
        }
    }
}
