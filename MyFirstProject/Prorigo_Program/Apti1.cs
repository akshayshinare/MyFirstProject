using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Prorigo_Program
{
    class Apti1
    {
        static void Main(string[] args)
        {
            int val;
            for (val = -5; val <= 5; val++)
            {
                switch(val)
                {
                    case 0:
                        Console.Write("India");
                        break;
                }
                if(val>0)
                    Console.Write("B");
                else if(val<0)
                    Console.Write("x");
            }
        }
    }
}
