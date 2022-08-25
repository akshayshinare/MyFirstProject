using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class CountTotalWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int c = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]==' ')
                {
                    c++;
                }
            }
            Console.WriteLine("Total Word= "+c);
        }
    }
}
