using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Array_Test2
{
    class SeperateZero
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 0, 2, 0, 3, 4, 0, 5 };
            Console.WriteLine("Display array");
            for(int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }

            Console.WriteLine(".................................");
            int[] a = new int[8];
            for(int i = 0; i < a.Length; i++)
            {
                if (0 > arry[i])
                {
                    a[i] = arry[i];
                }
                Console.WriteLine(a[i]);
            }
        }
    }
}
