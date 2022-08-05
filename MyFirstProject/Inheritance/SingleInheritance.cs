using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Animal
    {
        public string A_legs="4Legs";
    }

    class Tiger : Animal
    {
        public void show()
        {
            Console.WriteLine(A_legs);
        }
    }

    class AnimalDisp
    {
        static void Main(string[] args)
        {
            Tiger t = new Tiger();
            t.show();
            Console.WriteLine(t.A_legs);
        }
    }
}
