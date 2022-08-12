using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
    class Human
    {
        public string name = "xyz";
        public Human()
        {
            Console.WriteLine("Name=" + name);
        }
    }
    class Person : Human
    {
        public string m_name = "Akshay";
        public Person():base()
        {
            Console.WriteLine("Name=" + m_name);
        }
    }
    class Student : Person
    {
        public Student(int sid,int sage)
        {
            Console.WriteLine(base.m_name + " " + sid + " " + sage);
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Student s = new Student(101,25);
            
        }

    }
}
