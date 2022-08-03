using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            bool isprime = true;

            int i = 2;
            while(i<num)
            {
                if(num%i==0)
                {
                    isprime = false;
                    break;
                }
                i++;
            }
            if(isprime==true)
            {
                Console.WriteLine("is prime");
            }
            else
            {
                Console.WriteLine("is not prime");
            }

        }
    }
}
