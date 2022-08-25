using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class ArrayElementFreq
    {
        public static void Frequency(int[]a)
        {
            Console.WriteLine("Element Frequency");
            for(int i = 0; i < a.Length; i++)
            {
                int c = 1;
                bool isvisited = false;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for (int j=i+1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+c);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter arry size");
            int size = int.Parse(Console.ReadLine());

            int[] ar = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i<ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Display Array");
            Console.WriteLine(string.Join(" ",ar));
            ArrayElementFreq.Frequency(ar);
        }
    }
}
