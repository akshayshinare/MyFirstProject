using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops.Pattern
{
    class Pattern2
    {
        /*  5 
            5 4 
            5 4 3
            5 4 3 2 
            5 4 3 2 1    */
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
               
                for (int j=5;j>=6-i;j--)
                {
                    
                    Console.Write(j);
                   
                }
                Console.WriteLine();
            }
        }

          

    }
}
