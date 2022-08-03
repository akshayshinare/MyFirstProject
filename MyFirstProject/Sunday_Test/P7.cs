using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class P7
    {
        static void Main(string[] args)
        {
            /*8.	Write a code to check given number is Krishnamurthy number or not
                    e.g 145=  1!+4!+5!
	                          1+24+120
	                           145  
            the original number get back is known as Krishnamurthy.*/



            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            /*int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact); */

            
            int i = 1;

            while(num>0)
            {
               int r = num % 10;
                i++;
            }
            Console.WriteLine();
        }
    }
}
