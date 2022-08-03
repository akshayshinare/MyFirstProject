using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
    class Animal
    {
        public string name_animal;
        public int Legs;
        public string food_type;

        static void Main(string[] args)
        {
            Animal Tiger = new Animal();
            Tiger.name_animal = "Tiger";
            Tiger.Legs = 4;
            Tiger.food_type = "Non Veg";

            Console.WriteLine(Tiger.name_animal + " " + Tiger.Legs + " " + Tiger.food_type + "");

            Animal Cow = new Animal();
            Cow.name_animal = "Cow";
            Cow.Legs = 4;
            Cow.food_type = "Grass";

            Console.WriteLine(Cow.name_animal + " " + Cow.Legs + " " + Cow.food_type + " ");
        }


    }
}
