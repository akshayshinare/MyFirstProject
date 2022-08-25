using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class SumOfCol
    {
        public static void SumCol(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(" " + a[i, j]);
                    sum = sum + a[j,i];
                }
                Console.WriteLine("   Sum Of Col= "+sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] aa = { { 5, 1, 3 }, { 2, 4, 1 }, { 8, 3, 6 } };
            SumOfCol.SumCol(aa);
        }
    }
}
