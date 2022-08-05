using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class Profit
    {
        public double Display(double cost_price,double sel_price)
        {
            return (double) (sel_price - cost_price) / cost_price * 100;

        }

        static void Main(string[] args)
        {
            Profit p = new Profit();
          double Pro= p.Display(27.50, 28.60);

            Console.WriteLine("Profit=" + Pro);

        }
    }
}
