using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPs
{
    class AccessModifire
    {
        private int roll_no=30;
        internal string name = "Akshay";
        protected double per = 78.50;


       private void PrintRoll()
        {
            Console.WriteLine("my roll number is" + roll_no);
        }
        internal void Print_name()
        {
            Console.WriteLine("Name= " + name);
        }
        protected void Percentage()
        {
            Console.WriteLine("Percentage= " + per);
        }
         static void Main(string[] args)
        {
            AccessModifire a = new AccessModifire();
            Console.WriteLine(a.roll_no);
            a.PrintRoll();

            a.Print_name();
            a.Percentage();

        }
    }
}
