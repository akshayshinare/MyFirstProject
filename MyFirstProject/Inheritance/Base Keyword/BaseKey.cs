using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Base_Keyword
{
    class Vehical
    {
        public int wheels = 4;
        
        public Vehical(string type)
        {

            Console.WriteLine("Type= " + type);
            
        }

        public void Avarage()
        {
            Console.WriteLine("avarage=50");
        }
    }

    class Car:Vehical
    {
        int wheels=8;
        public Car():base("Disel")
        {
            Console.WriteLine("Swift "+base.wheels);
            base.Avarage();
        }

        public void CompanyName()
        {
            Console.WriteLine("Maruti");
          //  base.Avarage();
        }
    }

    class VehicalInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.CompanyName();
          

        }
    }

    
}
