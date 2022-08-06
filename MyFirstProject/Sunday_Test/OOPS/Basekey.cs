using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
   class Animal
    {
        public int leg = 4;
        public Animal(string fo_type)
        {
            Console.WriteLine(fo_type);
        }

        public void show()
        {
            Console.WriteLine("Tiger" + leg);
        }

    }
    class Dog : Animal
    {
        public Dog() : base("Non veg")
        {
            Console.WriteLine("Dog");
            
        }
        public void Dshow()
        {
            Console.WriteLine(base.leg);
            base.show();
        }
    }


    class Basekey
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Dshow();
        }
    }
}
