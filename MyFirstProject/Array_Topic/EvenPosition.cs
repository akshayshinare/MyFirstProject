using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class EvenPosition
    {
       /* public int EvenPosition(int[]b)
        {
            
        } */
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = int.Parse(Console.ReadLine());

            int[] B = new int[size];
            Console.WriteLine("enter element of array");
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("display array");
            for(int i = 0; i < B.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(B[i]);
                }
            }
        }
    }
}
