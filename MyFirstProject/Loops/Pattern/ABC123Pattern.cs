using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops.Pattern
{
    class ABC123Pattern
    {
        //1
        //A B
        //1 2 3
        //A B C D

        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write((char)(j + 64));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
