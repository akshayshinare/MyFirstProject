using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Mobile
    {
        internal string memory_size="64GB";
    }
    
    class Apple : Mobile
    {
        public void show()
        {
            Console.WriteLine(memory_size);
        }

    }

    class SingleDemo
    {
        static void Main(string[] args)
        {
            Apple iphone = new Apple();
            iphone.show();
            Console.WriteLine(iphone.memory_size);
        }
    }
}
