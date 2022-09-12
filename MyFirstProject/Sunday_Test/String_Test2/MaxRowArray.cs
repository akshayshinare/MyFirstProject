using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test2
{
    class MaxRowArray
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = arr[i,0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("RowMax = " + max);
                Console.WriteLine();
                
            }
            
        }
    }
}
