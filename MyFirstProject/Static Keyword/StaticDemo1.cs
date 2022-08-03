using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Static_Keyword
{
    class StaticDemo1
    {
        static int x = 0;

        StaticDemo1()
        {
            x++;
            Console.WriteLine(x);
        }

        void display()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(x);
            StaticDemo1 s = new StaticDemo1();
            StaticDemo1 s1 = new StaticDemo1();
            StaticDemo1 s2 = new StaticDemo1();

            Console.WriteLine(StaticDemo1.x);
        }
    }
}
