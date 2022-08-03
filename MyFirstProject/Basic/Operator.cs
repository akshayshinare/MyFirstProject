using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class Operator
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;

            int x = --a - ++b - a;

            Console.WriteLine(x + " " + a + " " + b);

            x = b++ + ++a + b;
            Console.WriteLine(x + " " + a + " " + b);

            x = a++ + --b - a;
            Console.WriteLine(x + " " + a + " " + b);


        }


    }
}
