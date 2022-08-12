using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class AddEvenAddOdd
    {
        public void Add(int[] y)
        {
            int k = 0;
            int[] B = new int[5];
            int[] C = new int[5];
            for(int i = 0; i < B.Length; i++)
            {
                if (y[i] % 2 == 0)
                {
                    B[k] = y[i];
                    k++;
                }
                else if (y[i] % 2 == 1)
                {
                    C[i] = y[i];
                }
            }
            Console.WriteLine("Even Array");
            foreach(int z in B)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine("Odd Array");
            foreach (int w in C)
            {
                Console.WriteLine( w);
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 4, 5, 3, 2, 1 };

            Console.WriteLine("Display Array");
            foreach(int x in A)
            {
                Console.WriteLine(x);
            }

            AddEvenAddOdd a = new AddEvenAddOdd();
            a.Add(A);
        }
    }
}
