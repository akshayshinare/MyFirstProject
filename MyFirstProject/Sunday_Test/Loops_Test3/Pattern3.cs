using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Loops_Test3
{
    class Pattern3
    {
        //1
        //2 1
        //3 2 1
        //4 3 2 1
        //5 4 3 2 1

        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
}
