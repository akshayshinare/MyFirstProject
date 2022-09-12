using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class Cusckoo
    {
        public static int coo(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return 1 * coo(n - 1) + 2 * coo(n - 2) + 3 * 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(coo(n));
        }
    }
}
