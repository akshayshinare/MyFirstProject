using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class PlusPattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j==3||i==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
