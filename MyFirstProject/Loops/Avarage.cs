using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Avarage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int c = 0;
            int avg;

            while(num>0)
            {
                sum = sum + num % 10;
                num = num / 10;
                c++;
            }
            avg = sum / c;
            Console.WriteLine("Sum of digit" + sum);
            Console.WriteLine("Avarage" + avg);

        }
    }
}
