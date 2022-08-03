using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class AbcdReverse
    {
        static void Main(string[] args)
        {
            for(char i='D';i>='A';i--)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
