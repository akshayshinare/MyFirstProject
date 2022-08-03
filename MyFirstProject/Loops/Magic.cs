using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Magic
    {
        static void Main(string[] args)
        {
            int magicnumber = 56;
            Console.WriteLine(magicnumber);
            while (true)
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());

                if(num>magicnumber)
                {
                    Console.WriteLine("enterd number is greater pls try again");
                    continue;
                }
                else if(num<magicnumber)
                {
                    Console.WriteLine("enterd number is less pls try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("you guess correct........");
                    break;
                }
            }
        }
    }
}
