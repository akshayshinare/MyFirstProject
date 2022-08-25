using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class ReverseArrayDemo
    {
        public static int[] Reverse(int[] a)
        {
            int j = a.Length - 1;
            for(int i = 0; i < a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter array elemet");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("display array");
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }

            int[] r = ReverseArrayDemo.Reverse(arr);

            Console.WriteLine("............");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
