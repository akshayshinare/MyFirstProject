using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class SumofArrayElement
    {
        public int Sum(int[]A)
        {
            int sum = 0;
            for(int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] A = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            SumofArrayElement s = new SumofArrayElement();
            int ans = s.Sum(A);

            Console.WriteLine("Sum of array element= " + ans);
        }
    }
}
