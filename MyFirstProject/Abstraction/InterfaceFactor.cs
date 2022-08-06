using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    interface IFactble
    {
        public int Fact(int num);
    }

    class SumofFact : IFactble
    {
        public int Fact(int num)
        {

            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    
                }
            }
            return sum;
        }
    }

    class InterfaceFactor
    {
        static void Main(string[] args)
        {
            SumofFact s = new SumofFact();
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int ans=s.Fact(num);
            Console.WriteLine(ans);
        }
    }
}
