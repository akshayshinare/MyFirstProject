using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class PrimeMethod
    {
        int SumofPrime(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                int num = i;
                bool isPrime = true;
                for(int j=2;j<num;j++)
                {
                    if (num % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime=true)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            PrimeMethod p = new PrimeMethod();
            int ans = p.SumofPrime(10);
            Console.WriteLine(ans);
        }
    }
}
