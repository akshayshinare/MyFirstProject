using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class P3
    {
        //WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("square");
                }
            }
        }
    }
}
