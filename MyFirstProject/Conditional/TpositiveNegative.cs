using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class TpositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enyter number");
            int num = int.Parse(Console.ReadLine());

            string str = num >= 0 ? "positive number" : "Negative Number";
            Console.WriteLine(str);
        }
    }
}
