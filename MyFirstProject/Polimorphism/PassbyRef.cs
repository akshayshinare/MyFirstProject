using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class PassbyRef
    {
        public void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }
        static void Main(string[] args)
        {
            PassbyRef s = new PassbyRef();
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);

            Console.WriteLine("----------------------------------");
            s.Swap(ref num1, ref num2); //pass by reference
            Console.WriteLine(num1 + " "+num2);

        }
    }
}
