using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test
{
    class MaxArray
    {
        
            public static void MaxCol(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int max = a[i, 0];
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (max < a[i, j])
                        {
                            max = a[i, j];
                        }
                     
                    }
                    Console.Write("Max= " + max);
                   
                }
            }
            static void Main(string[] args)
            {
                int[,] array = { { 22,31,9}, { 12,25,16 } };
                MaxArray.MaxCol(array);
            }
        }
}
