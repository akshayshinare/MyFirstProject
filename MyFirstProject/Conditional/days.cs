using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int day = int.Parse(Console.ReadLine());

            if(day==1)
            {
                Console.WriteLine("Monday");
            }
            else if(day==2)
            {
                Console.WriteLine("Tuesday");
            }
            else if(day==3)
            {
                Console.WriteLine("Wedansday");
            }
            else if(day==4)
            {
                Console.WriteLine("Thursday");
            }
            else if(day==5)
            {
                Console.WriteLine("Friday");

            }
            else  if(day=='6')
            {
                Console.WriteLine("Satarday");
            }
            else if(day==7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
