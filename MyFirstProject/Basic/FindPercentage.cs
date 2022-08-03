using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class FindPercentage
    {
        static void Main(string[] args)
        {
            int sub1 = 87;
            int sub2 = 90;
            int sub3 = 80;
            int sub4 = 75;

            int Per = (sub1 + sub2 + sub3 + sub4)/ 4;

            Console.WriteLine("Percentage" + Per);
        }
    }
}
