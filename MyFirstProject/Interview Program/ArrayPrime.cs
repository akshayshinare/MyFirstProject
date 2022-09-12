using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class ArrayPrime
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 3, 5, 7, 9, 2 };
           for(int j=0;j<arr.Length;j++)
            {
                bool isprimr = true;
                //int x = arr[j];
                for(int i = 2; i <= arr[j]; i++)
                {
                    if (arr[j] % i == 0)
                    {
                        isprimr = false;
                        break;

                    }
                }
                if (isprimr)
                {
                    Console.Write(arr[j]+" ");
                }
            }
        }
    }
}
