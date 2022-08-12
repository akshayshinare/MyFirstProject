using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class MergeArray
    {
        public void Merge(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for(int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i];

                if (arr1[i] != arr2[i])
                {
                    arr3[i] =arr2[i] ;
                }
                
            }
            Console.WriteLine("merge array");
            foreach (int y in arr3)
            {
                Console.WriteLine(y);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] arry1 = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < arry1.Length; i++)
            {
                arry1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter 2nd array size");
            int num = int.Parse(Console.ReadLine());
            int[] arry2 = new int[num];
            for(int i = 0; i < arry2.Length; i++)
            {
                arry2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1st Array");
            foreach(int x in arry1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("2nd Array");
            foreach (int s in arry2)
            {
                Console.WriteLine(s);
            }
            MergeArray ma = new MergeArray();
            ma.Merge(arry1, arry2);
        }
    }
}
