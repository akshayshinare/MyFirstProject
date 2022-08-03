using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Loops_Test3
{
    class Pattern2
    {
            /*   1
                10
               101
              1010
             10101  */

        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 6 - i; k++)
                {
                    if(k%2==0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();

                
                
            }
        }
    }
}
