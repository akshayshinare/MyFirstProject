using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class ArraDiff
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 12, 15, 13, 18, 20, 45 };

            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int a = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
               int dif = arr[i] - num;

                if (a>dif)
                {
                    a = arr[i];
                }
            }
            Console.WriteLine(a);
            
        }
    }
}
