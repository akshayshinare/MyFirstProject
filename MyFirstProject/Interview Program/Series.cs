using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class Series
    {
        //1 3 7 15 31

        static void Main(string[] args)
        {
            int n = 1;
            Console.Write(n+" ");
            for (int i = 0; i <5; i++)
            {
                
                n = n*2 + 1;

                Console.Write(n+" ");
            }
        }
    }
}
