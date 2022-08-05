using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Overriding
{
    class Fruit
    {
        public virtual void Test()
        {
            Console.WriteLine("Test is sweet");
        }
    }
    class Mango : Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Mango is sweet");
            base.Test();
        }
    }
    class Banana : Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Banan is Sweet");
        }
    }

    class OverrideDemo
    {
        static void Main(string[] args)
        {
            Fruit f = new Mango();
            f.Test();

            Fruit f1 = new Banana();
            f1.Test();
        }
    }
}
