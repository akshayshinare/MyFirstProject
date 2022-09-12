using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Eception_Handling
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("addition=" + (a + b));
            }
            catch (FormatException e) //handler
            {
                Console.WriteLine("enter valid number");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("number too big");
            }

            for (int i = 1; i <= 20; i = i + 2)
                Console.WriteLine(i);
       }
    }
}
