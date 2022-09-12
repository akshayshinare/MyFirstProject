using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class MaxFromArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 9, 4, 6, 3, 7 };

            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
