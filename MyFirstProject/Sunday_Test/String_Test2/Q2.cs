using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test2
{
    class Q2
    {
        public static void Pair(int[]a,int n)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == n)
                    {
                        Console.WriteLine(a[i]+", "+a[j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sum number");
            int num = int.Parse(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Pair(a, num);
        }
    }
}
