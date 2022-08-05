using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Vehical
    {
        protected int wheels = 4;
    }

    class Car : Vehical
    {
        internal string cname = "Audi";
        public void Showcar()
        {
            Console.WriteLine(cname + " " + wheels);
        }
    }

    class Truck : Vehical
    {
        public void showtruck()
        {
            wheels = 8;
            Console.WriteLine("Truck Wheels=" + wheels);
        }
    }

    class HirarchicalDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Showcar();
            Truck t = new Truck();
            t.showtruck();
        }
    }
}
