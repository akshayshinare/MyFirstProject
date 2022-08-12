using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topik
{
    class CharRev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of element");
            int size = int.Parse(Console.ReadLine());

            char[] Array = new char[size];
            Console.WriteLine("enter character element");
            for(int i =0; i<Array.Length; i++)
            {
                Array[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Display Reverse Array");
            for(int i = Array.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Array[i]);
            }

        }
    }
}
