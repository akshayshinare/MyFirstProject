using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.Loops_Test3
{
    class Base
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter index");
            int y = int.Parse(Console.ReadLine());

            int z = 1;
            while(y>0)
            {
                z = z * x;
                y--;
            }
            Console.WriteLine(z);
        }
    }
}
