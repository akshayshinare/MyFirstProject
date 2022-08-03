using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ContentMent
{
    class EmpConstruct
    {
        int eid;
        string ename;
        int salary;
        string dep_type;

        public EmpConstruct(int eid, string ename, int salary, string dep_type)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
            this.dep_type = dep_type;
        }
        public void showEmp()
        {
            Console.WriteLine(eid + " " + ename + " " + salary + " " + dep_type);
        }

    }

    class Department
    {
        int dep_id;
        string dep_name;
        EmpConstruct Em;

        public Department(int dep_id, string dep_name,EmpConstruct Em)
        {
            this.dep_id = dep_id;
            this.dep_name = dep_name;
            this.Em = Em;
        }
        void DisplayDepartment()
        {
            Console.WriteLine(dep_id + " " + dep_name);
            Em.showEmp();
        }

        static void Main(string[] args)
        {
            EmpConstruct e = new EmpConstruct(101,"Shubham",25000,"Computer");
            Department d = new Department(505, "Computer", e);

            d.DisplayDepartment();

        }
    }
}
