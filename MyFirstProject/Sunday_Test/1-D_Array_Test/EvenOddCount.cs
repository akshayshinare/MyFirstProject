using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    class EvenOddCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int c = 0;
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    c++;
                }
                else if (arr[i] % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("Event Count= "+c);
            Console.WriteLine("Odd count= "+count);
        }
    }
}
