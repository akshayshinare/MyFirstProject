using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int s;
            int sum = 0;

            while(num>0)
            {
                s = num % 10;
                sum = sum + (s * s * s);
                num = num / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("Is Armstrong Number");
            }
            else
            {
                Console.WriteLine("is not armstrong number");
            }
        }
    }
}
