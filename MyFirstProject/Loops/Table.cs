using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Table
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num * i);
            }
            
            
        }
    }
}
