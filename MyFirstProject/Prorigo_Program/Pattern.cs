using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
