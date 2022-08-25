using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class NameValidation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Name");
            string name = Console.ReadLine();

            bool isdigit = false;
            for(int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    Console.WriteLine("enter valid name");
                    break;
                }
                
            }
            
        }
    }
}
