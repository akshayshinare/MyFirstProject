using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{

    interface IMoveable
    {
       //int x = 4;// not allowed non static member
       static int y=45;
        void Move();
        public static void show()
        {
            Console.WriteLine("show method");
        }
        public int add()
        {
            return 2 + 3;
        }
    }
    class Bus : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("bus is moving...."+IMoveable.y);
        }
    }
    class InterfaceDemo1
    {
        static void Main(string[] args)
        {
           // Bus b = new Bus();
            //b.Move();

            IMoveable m = new Bus();
            m.Move();
            Console.WriteLine(m.add());
            IMoveable.show();
        }
       
    }
}
