using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Online_Assignment_Loops
{
    class PerimeterRactangle
    {
        public int Perimeter(int length,int width)
        {
            return 2 * (length + width);
        }

        static void Main(string[] args)
        {
            PerimeterRactangle p = new PerimeterRactangle();
            int ans = p.Perimeter(5, 9);
            Console.WriteLine("Perimeter of Ractangle= " + ans);
        }
    }
}
