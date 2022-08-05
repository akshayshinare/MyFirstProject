using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Base_Keyword
{
    class Animal
    {
        public int legs = 4;
    }
    class Frog : Animal
    {
        public int legs = 2;

        public void show()
        {
            Console.WriteLine("Legs=" + legs + " " + "Animal Legs=" + base.legs);
        }
    }

    class Dog : Animal
    {
        public void Display()
        {
            Console.WriteLine("Dog Legs=" + base.legs);
        }
    }

    class BaseUses
    {
        static void Main(string[] args)
        {
            Frog f = new Frog();
            f.show();
            Dog d = new Dog();
            d.Display();
        }
    }
}
