using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topik
{
    class SumofEvenArray
    {
        public int EvenSum(int[]a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            SumofEvenArray s = new SumofEvenArray();
            int ans = s.EvenSum(arr);

            Console.WriteLine("Sum of Even Array" + ans);
        }
    }

}
