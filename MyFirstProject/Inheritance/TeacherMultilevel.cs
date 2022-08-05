using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Department
    {
        internal string d_name = "Computer";

        public void Dshow()
        {
            Console.WriteLine("Department Name="+d_name);
        }

    }
    class ClassTeacher:Department
    {
        internal string class_name = "T.Y.Bcs";
        public void ClassShow()
        {
            Console.WriteLine("class name" + class_name);
        }
    }
    class Student:ClassTeacher
    {
        string s_name = "Akshay";

        public void StudShow()
        {
            Console.WriteLine(d_name + " " + class_name + " " + s_name);
        }
    }
    class DepartInfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.StudShow();
            ClassTeacher c = new ClassTeacher();
            c.ClassShow();
            Department d = new Department();
            d.Dshow();
        }
    }
}
