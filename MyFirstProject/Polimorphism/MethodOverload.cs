using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class MethodOverload
    {
        double Area(double r)
        {
            return 3.14 * r * r;
        }

        int Area(int l,int b)
        {
            return l * b;
        }

        int Area(int ba,double h)
        {
            return ba * Convert.ToInt32(h);
        }

        float Area(float side)
        {
            return side * side;
        }

        static void Main(string[] args)
        {
            MethodOverload a = new MethodOverload();

            Console.WriteLine("Enter radius of circle");
            double r=double.Parse(Console.ReadLine());
            double circle = a.Area(r);
            Console.WriteLine("Area of circle=" + circle);

            Console.WriteLine("Enter length And Base");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int ractangle = a.Area(l, b);
            Console.WriteLine("Area of Ractangle"+ractangle);

            Console.WriteLine("Enter banse and height");
            int ba = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int traingle = a.Area(ba, h);
            Console.WriteLine("Area of Traingle" + traingle);

            Console.WriteLine("Enter side");
            float side = float.Parse(Console.ReadLine());
            float square = a.Area(side);
            Console.WriteLine("Area of Square= " + square);


        }
    }
}
