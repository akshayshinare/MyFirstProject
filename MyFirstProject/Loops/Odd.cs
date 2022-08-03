using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Odd
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
