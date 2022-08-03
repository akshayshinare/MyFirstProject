using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class TarnaryEvenodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

             string str =  num %2 ==0  ? "Even Number" : "Number is Odd";
            Console.WriteLine(str);
        }
    }
}
