using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Array_Test2
{
    class SwapArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 };

            int b = array.Length - 1;
           
            for(int i = 0; i < 2; i++)
            {
                int c = array[i];

                array[i] = array[b];
                array[b] = c;
                b--;
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+array[i]);
            }
        }
    }
}
