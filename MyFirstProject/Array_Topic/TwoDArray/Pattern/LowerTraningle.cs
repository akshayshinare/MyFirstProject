using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray.Pattern
{
    class LowerTraningle
    {

        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];

            for(int i = 0; i < a.GetLowerBound(0); i++)
            {
                for(int j = 0; j < a.GetUpperBound(1); j++)
                {
                    if (i >= j)
                    {
                        Console.WriteLine("enter element");
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("....................");
            for(int i = 0; i < a.GetUpperBound(0); i++)
            {
                for(int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
