using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray.Pattern
{
    class SparseMatrix
    {
        public static void Sparse(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int c1 = 0;
                int c2 = 0;
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0)
                    {
                        c1++;
                    }
                    else
                    {
                        c2++;
                    }
                }
                if (c1 > c2)
                {
                    Console.WriteLine("Sparse");
                }
                else
                {
                    Console.WriteLine("not sparse Matrix");
                }
            }
        }
        static void Main(string[] args)
        {
            int[,]aa= new int[4, 4];

            Console.WriteLine("enter array element");
            for(int i = 0; i < aa.GetLength(0); i++)
            {
                for(int j = 0; j < aa.GetLength(1); j++)
                {
                    aa[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
