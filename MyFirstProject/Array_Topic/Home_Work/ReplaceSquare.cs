using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class ReplaceSquare
    {
        static void Main(string[] args)
        {
            int[] R = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine("display array");
            foreach(int x in R)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("................");
            for(int i = 0; i < R.Length; i++)
            {
                if (R[i] < 0)
                {
                    R[i] = R[i - 1] * R[i-1];
                }
                Console.WriteLine(R[i]);
            }
        }
    }
}
