using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class MaxFromCol
    {
        public static void MaxCol(int[,]a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[0, i];
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[j, i])
                    {
                        max = a[j, i];
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.Write("ColMax= "+max);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] array = { { 2, 3, 5 }, { 5, 8, 7 }, { 6, 3, 4 } };
            MaxFromCol.MaxCol(array);
        }
    }
}
