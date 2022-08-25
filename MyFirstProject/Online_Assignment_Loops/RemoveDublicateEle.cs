using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class RemoveDublicateEle
    {
        public static void DuplicateElement(int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                bool isPresnt = false;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (b[i] == b[j])
                    {
                        isPresnt = true;
                        break;
                    }
                }
                if (isPresnt == true)
                {
                    b[i] = 0;
                }
            }
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                {
                    Console.Write(" "+b[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            RemoveDublicateEle.DuplicateElement(a);
        }
    }
}
