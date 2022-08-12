using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topik
{
    class ArrayReversePrint
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(" ", a));
            for(int i = 1; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
