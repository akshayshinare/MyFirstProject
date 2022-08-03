using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
    class MethodDemo
    {
        //Accessmodifire return_type name of method()
        // {
        //logic;
        //}

        // no return type no parameter
        int y;
        public void show() //Method Declaration
        {
            Console.WriteLine("show method");   //method body
        }

        public double AreaofCircle()
        {
            double PI = 3.14;
            double area = PI * 3 * 3;
            return area;
        }

        public int Addition(int a, int b)
        {
            return (a + b);
        }
        public void Calculate(int x, string str)
        {
            Console.WriteLine(str);
            y = x * x * x;
        }

        public void Display()
        {
            Console.WriteLine(y);
        }


        static void Main(string[] args)
        {
            MethodDemo d = new MethodDemo();
            d.show(); // method calling

            double a = d.AreaofCircle();
            Console.WriteLine("Area of circle" + a);

            int result = d.Addition(5, 7);
            Console.WriteLine("Addition" + result);
            Console.WriteLine("Addition="+d.Addition(5, 10));

            d.Calculate(5, "Pune");
            d.Display();



        }
    }
}
