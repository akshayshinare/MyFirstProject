using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    class PerfectSquareArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };
            Console.WriteLine("display array");
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("....................");
            int c = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                
                for (int j = 0; j <arr[i]; j++)
                {
                    int square = j * j;
                    if (arr[i] == square)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            
        }
    }
}
