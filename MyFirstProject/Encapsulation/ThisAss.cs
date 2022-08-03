using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Encapsulation
{
    class ThisAss
    {
        
        string emp_comp;
        int emp_sal;
        int no_ofemp;
        int total_sal;

        ThisAss(string emp_comp,int emp_sal,int no_ofemp)
        {
            this.emp_comp = emp_comp;
            this.emp_sal = emp_sal;
            this.no_ofemp = no_ofemp;
            
        }

        ThisAss(): this("TATA",20000,10)
        {
            total_sal = no_ofemp * emp_sal;
            this.Display();

        }

        void Display()
        {
            Console.WriteLine("Company Name= " + emp_comp + " Employee Salary= " + emp_sal + " number of employee= " + no_ofemp+" Total Salary= "+total_sal);
        }

        static void Main(string[] args)
        {
            ThisAss emp = new ThisAss();
          //  emp.Display();
        }
    }
}
