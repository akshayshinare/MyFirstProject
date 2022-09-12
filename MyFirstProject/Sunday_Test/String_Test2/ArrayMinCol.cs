using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test2
{
    class ArrayMinCol
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 22, 31, 9 }, { 12, 5, 16 }, { 34, 42, 2 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int min = arr[0, i];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[j, i])
                    {
                        min = arr[j, i];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("ColMin= " + min);
                Console.WriteLine();
            }
        }
    }
}
