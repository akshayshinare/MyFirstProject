using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class Fibo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int n = 0, n1 = 1, n3;
            Console.Write(n + " " + n1+" ");
            for (int i = 0; i <num; i++)
            {
                
                n3 = n + n1;
                
                Console.Write(n3+" ");
                n = n1;
                n1 = n3;
            }
        }
    }
}
