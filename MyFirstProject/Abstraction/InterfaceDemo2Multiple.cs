using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    interface IDrwable
    {
        void Draw();
    }
   /* interface IPrintable
    {
        void Print();
    }*/

    abstract class Circle
    {
        public abstract void DrawCircle();
    }
    class Shape : Circle,IDrwable
    {
        public void Draw()
        {
            Console.WriteLine("Draw shape");
        }
        public override void DrawCircle()
        {
            Console.WriteLine("Circle");
        }
    }

    class InterfaceDemo2Multiple
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Draw();
           // s.Print();
        }
    }
}
