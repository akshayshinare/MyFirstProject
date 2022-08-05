using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Person
    {
        internal string p_name = "Akshay";

        public void show()
        {
            Console.WriteLine("Name=" + p_name);
        }

    }

    class Employee : Person
    {
        internal int salary = 80000;

        public void showSalary()
        {
            Console.WriteLine(p_name+" "+salary);
        }
    }

    class Manager : Employee
    {
        int comition = 3000;

        public void showmanager()
        {
            Console.WriteLine(p_name + " " + salary + " " + comition);
        }
    }

    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.show();
            m.showSalary();
            m.showmanager();
        }
        
    }
    
}
