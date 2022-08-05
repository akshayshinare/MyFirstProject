using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Animal1
    {
        protected int legs = 4;
        
    }

    class Lion : Animal1
    {
        public string name = "Lion";
        string f_type = "NonVeg";
        public void Lionshow()
        {
            Console.WriteLine(name + " " + f_type + " " + legs);
        }
      
    }
    class Cow : Animal1
    {
        public string name = "Cow";
        string f_type = "Grass";

        public void cowshow()
        {
            Console.WriteLine(name + " " + f_type + " " + legs);
        }
    }
    class Animalinfo
    {
        static void Main(string[] args)
        {
            Cow c = new Cow();
            c.cowshow();
            Lion l = new Lion();
            l.Lionshow();
        }
    }
}
