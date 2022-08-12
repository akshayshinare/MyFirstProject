using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topik
{
    class FloatArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());

            float[] Array = new float[size];
            Console.WriteLine("enter float element");
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = float.Parse(Console.ReadLine());
            }

            //display array
            Console.WriteLine("Array Display");
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]+" ");
            }
        }
    }
}
