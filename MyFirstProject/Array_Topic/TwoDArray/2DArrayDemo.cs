using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class TwoDArrayDemo
    {
        static void Main(string[] args)
        {
            int[,] arr = {{4,6,2},
                          {8,2,6},
                          {5,9,2 } };

            int[,] a = new int[3, 3];
            Console.WriteLine("enter array element");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine(".......................");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("........................");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
