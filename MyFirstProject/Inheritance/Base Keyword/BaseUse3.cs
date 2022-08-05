using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Base_Keyword
{
    class Laptop
    {
        public Laptop()
        {
            Console.WriteLine("Laptop");
        }
    }
    class Dell : Laptop
    {
        public Dell():base()
        {
            Console.WriteLine("Dell.....");
        }
    }
    class BaseUse3
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();

        }
    }
}
