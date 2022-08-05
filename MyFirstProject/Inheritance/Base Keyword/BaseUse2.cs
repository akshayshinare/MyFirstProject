using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Base_Keyword
{
    class Bird
    {
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
    class Sparrow : Bird
    {
        public void fly()
        {
            Console.WriteLine("sparow is flying......");
            base.fly();
        }
    }
    class BaseUse2
    {
        static void Main(string[] args)
        {
            Sparrow p = new Sparrow();
            p.fly();
        }
    }
}
