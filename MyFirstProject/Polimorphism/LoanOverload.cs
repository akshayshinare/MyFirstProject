using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class LoanOverload
    {
        public double LoanCalculate(double inte_rate,double total_amo,double time)
        {
            return total_amo * inte_rate * time / 100;
        }
          public double LoanCalculate(double total_amo,int time)
        {
            if(time<=6)
            {
                return total_amo * 2 * time / 100;
            }
            else
            {
                return total_amo * 3 * time;

            }
        }

        static void Main(string[] args)
        {
            LoanOverload l = new LoanOverload();
            Console.WriteLine(l.LoanCalculate(5, 20000, 5));
            Console.WriteLine(l.LoanCalculate(20000, 7));
            Console.WriteLine(l.LoanCalculate(20000, 4));
        }
    }
}
