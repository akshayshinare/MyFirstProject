using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class Replace
    {
 
        static void Main(string[] args)
        {
            int[] arry = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };

            Console.WriteLine("display array");
            for(int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }

            Console.WriteLine("After Replace Array");
            for(int i = 0; i < arry.Length; i++)
            {
                if (arry[i]==0)
                {
                    arry[i] = 1;
                }
                Console.WriteLine(arry[i]);
            }

        }
    }
}
