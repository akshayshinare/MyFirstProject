using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loops
{
    class Divisible3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=30;i++)
            {
                if(i%3==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
