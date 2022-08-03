using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Static_Keyword
{
    class StaticDemo3
    {
        static StaticDemo3()
        {
            Console.WriteLine("HIIIII");
        }

        StaticDemo3()
        {
            Console.WriteLine("Default");
        }

        static void Main(string[] args)
        {
            StaticDemo3 d = new StaticDemo3();
            StaticDemo3 d2 = new StaticDemo3();
        }
    }
}
