using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops.Pattern
{
    class Pattern3
    {
        /*  5 5 5 5 5
            4 4 4 4
            3 3 3 
            2 2 
            1   */
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
