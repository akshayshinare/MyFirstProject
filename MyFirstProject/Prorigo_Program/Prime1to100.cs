using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class Prime1to100
    {
        static void Main(string[] args)
        {
         
            for(int i = 2; i < 100; i++)
            {
                int c = 0;
                for (int j = 2; j <i; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
