using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class CheckPrime
    {
        bool isPrimeNum(int num)
        {
            bool isprime = true;
            for(int i=2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }

            }
            return isprime;
        }
        static void Main(string[] args)
        {
            CheckPrime p = new CheckPrime();
            bool b = p.isPrimeNum(8);
            if (b == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
