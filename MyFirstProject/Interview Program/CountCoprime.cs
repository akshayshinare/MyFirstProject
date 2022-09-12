using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class CountCoprime
    {
        public static int CountCop(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                int factors = 0;
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (i % divisor == 0 && n % divisor == 0)
                        factors++;
                }
                if (factors == 1)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Coprime count" + CountCop(num));
        }
    }
}
