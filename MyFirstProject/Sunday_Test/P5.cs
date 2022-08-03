using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test
{
    class P5
    {
       /* A number is said to be the Harshad number if it is divisible by the sum of its digit.For example, 
        if number is 156, then sum of its digit will be 1 + 5 + 6 = . Since156 is divisible by 12. So, 
        156 is a Harshad number. Some of the other examples of Harshad number are 8, 54, 120, etc. */
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0;
            int d;
            for(int i=0;num!=0;i++)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            d = num1 / sum;

            Console.WriteLine("sum of Digit= "+sum);
            Console.WriteLine("Division= "+d);

            if(num1%sum==0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not Harshad Number");
            }
        }

    }
}
