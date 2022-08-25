using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    class ZeroToOne
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine("Display Array");
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
            }

            Console.WriteLine("...........................");
            foreach(int y in arr)
            {
                Console.WriteLine(y);
            }
        }
    }
}
