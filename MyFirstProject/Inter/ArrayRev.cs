using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inter
{
    class ArrayRev
    {
        public static void RArray(int[]a)
        {
            for(int i = a.Length-1; i>= 0; i--)
            {
                Console.Write(a[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
            RArray(arr);
        }
    }
}
