using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance.Overriding
{
    class Fruit1 
    {
        public virtual void Test()
        {
            Console.WriteLine("Test is sweet");
        }
    }
    class Apple : Fruit1
    {
       /* static override void Test()
        {
            Console.WriteLine("Apple test is sweet");
        } */
    }

}
