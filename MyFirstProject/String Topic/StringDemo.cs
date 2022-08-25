using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            string s1 = "ThinkQuetient";
            int c = 0;
            int cons = 0;

            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u')
                {
                    c++;
                }
                else
                {
                    cons++;
                }
            }
            Console.WriteLine("Vowel"+c);
            Console.WriteLine("Consonent"+cons);

            Console.WriteLine("reverse string");
            for(int i = s1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
}
