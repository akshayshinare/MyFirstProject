using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class CountOddEle
    {
        public int CountOddElement(int[]a)
        {
            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                
                if (a[i] % 2 == 1)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            CountOddEle c = new CountOddEle();
            int ans = c.CountOddElement(arr);
            Console.WriteLine("Count of odd element" + ans);
        }
    }
}
