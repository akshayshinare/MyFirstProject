using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class Odd521
    {
        static void Main(string[] args)
        {
            int num = 521;
            while (num>=229)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine(num);
                }
                num--;
            }
        }
         
        
    }
}
