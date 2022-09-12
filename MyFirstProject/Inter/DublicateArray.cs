using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inter
{
    class DublicateArray
    {
        public static void DArray(int[]a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.Write(i+" "+j+" ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 1, 5, 6, 4, 2, };
            DArray(arr);
        }
    }
}
