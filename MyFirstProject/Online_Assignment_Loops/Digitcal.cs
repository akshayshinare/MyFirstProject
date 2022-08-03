using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class Digitcal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            
            
            int r;
            int c=0;

            while(num>0)
            {
                r = num % 10;
                num = num / 10;
                c++;
            }
            Console.WriteLine("count= " + c);
        }
    }
}
