using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.OOPS
{
    class Shopping
    {
        
       public void Transaction(string type)
        {
            
            Console.WriteLine("You got 15% discount");
        }
       public void Transaction()
        {
            Console.WriteLine("No Discount");
        }

        static void Main(string[] args)
        {
            
            Shopping s = new Shopping();
            Console.WriteLine("Enter Card Type 'CreditCard'or 'DebitCard' ");
            string type = Console.ReadLine();

            if (type == "CreditCard")
            {
                s.Transaction("CreditCard");
            }
            else if (type == "DebitCard")
            {
                s.Transaction();
            }
           
        }
    }
}
