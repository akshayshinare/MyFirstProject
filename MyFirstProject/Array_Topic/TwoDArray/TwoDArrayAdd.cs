using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class TwoDArrayAdd
    {
        public static void Addition(int[,] a, int[,] b)
        {
            int[,] c = new int[2, 2];
            Console.WriteLine("Addition Of Two Array");
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                   c[i,j]= a[i, j] + b[i, j];
                    Console.Write(" "+c[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,]a1= { { 2, 6 }, { 5, 4 } };
            int[,] a2 = { { 2, 1 }, { 3, 2 } };

            Console.WriteLine("Display 1st Array");
            for(int i = 0; i < a1.GetLength(0); i++)
            {
                for(int j = 0; j < a1.GetLength(1); j++)
                {
                    Console.Write(" "+a1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Display 2nd Array");
            for(int i = 0; i < a2.GetLength(0); i++)
            {
                for(int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.Write(" "+a2[i,j]);
                }
                Console.WriteLine();
            }

            TwoDArrayAdd.Addition(a1, a2);
        }
    }
}
