using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class EmailValidation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Email Id");
            string email = Console.ReadLine();

            int a = email.IndexOf('@');
            int b = email.IndexOf('.');

            if(a>1 && b>2 && a < b)
            {
                Console.WriteLine("valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }

        }
    }
}
