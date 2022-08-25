using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class RowSum
    {
        public static void SumOfRow(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" "+a[i,j]);
                    sum = sum + a[i, j];
                }
                Console.Write("  sum= "+sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 3, 6 }, { 6, 2, 3 } };
            RowSum.SumOfRow(arr);

            Console.WriteLine("..................................");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
