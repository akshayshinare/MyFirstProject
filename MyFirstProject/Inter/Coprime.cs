using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inter
{
    class Coprime
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 1, 1, 1, 1, 1 };

            int c = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]==0)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
