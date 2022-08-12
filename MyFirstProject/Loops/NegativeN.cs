using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class NegativeN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter input");
            

            int sum = 0;

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<0)
                {
                    sum = sum + num;
                }
                else if (num == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Positive =" + num);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
