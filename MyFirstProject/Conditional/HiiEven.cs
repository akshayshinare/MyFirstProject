using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditional
{
    class HiiEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if(num%2==0)
            {
                if(num>2 && num<6)
                {
                    Console.WriteLine("Hii Even");
                }
                else
                {
                    Console.WriteLine("only Even");
                }
            }
            else if((num>5 && num<10) &&( num%2!=0))
            {
                Console.WriteLine("Hello odd");
            }
            else
            {
                Console.WriteLine("only odd");
            }
            
        }
    }
}
