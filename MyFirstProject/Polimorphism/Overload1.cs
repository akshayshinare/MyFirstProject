using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Polimorphism
{
    class Overload1
    {
        /* write code overload area method to find out the addition,subtraction,multi,division. */

        int Calculate(int a,int b)
        {
            return a + b;
        }

        int Calculate(int x,float y)
        {
            return x - (Convert.ToInt32(y));
        }

        double Calculate(double c, double k)
        {
            return c * k;
        }

        int Calculate(int i,double j)
        {
            return i / (Convert.ToInt32(j));
        }
        
        static void Main(string[] args)
        {
            Overload1 m = new Overload1();
            int add = m.Calculate(5, 10);
            Console.WriteLine(" Addition= " + add);

            int sub = m.Calculate(10, 5.0f);
            Console.WriteLine("Subtraction= " + sub);

            double mul = m.Calculate(2.0, 4.0);
            Console.WriteLine("Multiplication=" + mul);

            int div = m.Calculate(20, 5.0);
            Console.WriteLine("Division=" + div);
        }
    }
}
