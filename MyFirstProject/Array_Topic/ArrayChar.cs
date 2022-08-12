using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topik
{
    class ArrayChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size = int.Parse(Console.ReadLine());
            char[] ch = new char[size];

            Console.WriteLine("enter the char element");
            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(".........................");
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }
        }
    }
}
