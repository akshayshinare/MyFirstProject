using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
    class NationalGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Country Name ");
            string country = Console.ReadLine();

            switch (country)
            {
                case "India":
                    Console.WriteLine("Hocky");
                    break;
                case "China":
                    Console.WriteLine("Table Tenis");
                    break;
                case "Bangladesh":
                    Console.WriteLine("Kabaddi");
                    break;
                case "Italy":
                    Console.WriteLine("Foot Ball");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
