using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops.Pattern
{
    class Pattern4
    {
        /* 1
           2 1
           3 2 1
           4 3 2 1
           5 4 3 2 1  */

        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=5;j>=6-i;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
         
    }
}
