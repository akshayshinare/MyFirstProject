using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class StaticMethod
    {

        static int AreaofRactangle(int l,int b)
        {
            return l * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Area of ractangle" + AreaofRactangle(5, 6));
        }
    }
}
