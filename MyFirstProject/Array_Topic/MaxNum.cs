using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{

    class MaxNum
    {
        public int FindMax(int[] a)
        {
            int max = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] MaxArray = new int[size];
            Console.WriteLine("enter array element");
            
                for(int i = 0; i < MaxArray.Length; i++)
                {
                    MaxArray[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Display Array");
            foreach(int x in MaxArray)
            {
                Console.WriteLine(x);
            }
            MaxNum m = new MaxNum();
            int ans = m.FindMax(MaxArray);

            Console.WriteLine("Maximum Number= " + ans);
        }
    }
}
