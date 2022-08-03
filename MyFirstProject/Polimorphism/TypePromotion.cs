using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class TypePromotion
    {
        void Addition(int a,float b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            TypePromotion t = new TypePromotion();
            //  t.Addition(5, 2.5f);
            t.Addition(5, 5l);
        }
    }
}
