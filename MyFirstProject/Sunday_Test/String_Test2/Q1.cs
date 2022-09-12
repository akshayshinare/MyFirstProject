using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test2
{
    class Student
    {
        int sid;
        string sname;
        string[] h;
        public Student(int id,string n, string[]H)
        {
            sid = id;
            sname = n;
            h = H;
        }
        public void Display()
        {
            Console.WriteLine("Roll No:"+sid+"\nName:"+sname+"\nHobbie:"+h);
        }
    }
    class Q1
    {
        static void Main(string[] args)
        {
            string[] h = { "Playing", "Travelling" };
            Student s = new Student(1, "Akshay", h);
            s.Display();
        }
    }
}
