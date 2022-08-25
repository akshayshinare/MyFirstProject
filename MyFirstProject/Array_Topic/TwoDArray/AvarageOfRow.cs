using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.TwoDArray
{
    class AvarageOfRow
    {
        public static void Avarage(int[,] b)
        {
            for (int i = 0; i<b.GetLength(0);i++)
            {
                int sum = 0;
                int avg;
                int c = 0;
                for(int j = 0; j < b.GetLength(1); j++)
                {
                    sum = sum + b[i, j];
                    Console.Write(" "+b[i,j]);
                    c++;
                }
                avg = sum / c;
                Console.WriteLine("  avarage= "+avg);
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 5 }, { 5, 3, 6 }, { 3, 4, 5 } };
            AvarageOfRow.Avarage(a);
        }
    }
}
