using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int c = 0;
            for(int i=1;i<=4;i++)
            {
                for(int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                
                for(int k =1; k<=i+c; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
                c++;
            }
        }
    }
}
