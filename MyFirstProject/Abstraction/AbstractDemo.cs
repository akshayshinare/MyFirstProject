using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    abstract class Animal
    {
        public abstract void Eat(); // Abstract Method

        public Animal(int leg)  // constructor
        {
            Console.WriteLine("Animal" +leg);
        }
        public void run() //non abstract method
        {
            Console.WriteLine("Animal is Running...");
        }
    }
    class Dog : Animal
    {
        public Dog():base(4)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Dog is eating.......");
        }
    }

    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();
            d.run();
        }
    }
}
