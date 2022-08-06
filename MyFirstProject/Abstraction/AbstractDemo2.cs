using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    abstract class Vehical
    {
        public abstract void Run();
    }
    abstract class Car : Vehical
    {

    }
    class BMW:Car
    {
        public override void Run()
        {
            Console.WriteLine("BMW is running......");
        }
    }
    class AbstractDemo2
    {
        static void Main(string[] args)
        {
            BMW b = new BMW();
            b.Run();
        }
    }
}
