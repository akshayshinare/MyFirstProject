using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class Series
    {
        static void Main(string[] args)
        {
            int mul=0;
            for (int i = 1;i < 8; i++)
            {
                mul = mul * 2 + 1;
                Console.Write(" "+mul);
            }
           
        }
    }
}
