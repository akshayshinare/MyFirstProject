using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class AssendingDessendingArray
    {
        public void AssDess(int[]a)
        {
            for(int i = 0; i < a.Length/2; i++)
            {
                for(int j = i+1; j < a.Length/2; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            for (int i = a.Length/2; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("....................");
            foreach(int y in a)
            {
                Console.WriteLine(y);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] d = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < d.Length; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("display array");
            foreach(int x in d)
            {
                Console.WriteLine(x);
            }

            AssendingDessendingArray a = new AssendingDessendingArray();
            a.AssDess(d);
        }
    }
}
