using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
   abstract class NewClass
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 5, 15, 4, 7, 8 };
           // Console.WriteLine("enter number");
           // int num = int.Parse(Console.ReadLine());

            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("max number"+max);

            
        }
       
        
    }
}
