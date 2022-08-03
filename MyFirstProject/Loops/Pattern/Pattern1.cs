using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("$");
                }
                for(int k = 1; k<=6-i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
