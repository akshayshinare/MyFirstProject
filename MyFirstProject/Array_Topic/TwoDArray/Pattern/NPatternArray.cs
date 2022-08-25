using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray.Pattern
{
    class NPatternArray
    {
        
        public static void NPattern(int[,] b)
        {
            Console.WriteLine("N pattern");
            for(int i = 0; i < b.GetLength(0); i++)
            {
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    if (j == 0 || j == b.GetUpperBound(1)|| i == j)
                    {
                        Console.Write(b[i,j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("enter array element");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("...........................");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }

            NPatternArray.NPattern(a);

        }
    }
}
