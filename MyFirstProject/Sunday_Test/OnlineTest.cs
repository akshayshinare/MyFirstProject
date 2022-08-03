using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class OnlineTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            bool isodd = true;
            int i= 1;
            int r;
            while (num > 0)
            {
                r = num % 10;

                if (r %2== 0)
                {
                    isodd = false;
                    break;
                }
                else if (r== 0)
                {
                    isodd = false;
                }

                num = num / 10;
            }
            if (isodd == true)
            {
                Console.WriteLine("is Happy");
            }
            else
            {
                Console.WriteLine("not happy");
            }
        }
    }
}
