using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Arrat_Topik
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter the array element");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("....Display Array....");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}
