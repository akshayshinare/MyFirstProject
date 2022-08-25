using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.String_Topic
{
    class VowelNextSubsequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s1 = Console.ReadLine();

            char[] ar = s1.ToCharArray();

            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == 'a')
                {
                    ar[i] = 'b';
                }
                else if (ar[i] == 'e')
                {
                    ar[i] = 'f';
                }
                else if (ar[i] == 'i')
                {
                    ar[i] = 'j';
                }
                else if (ar[i] == 'o')
                {
                    ar[i] = 'p';
                }
                else if (ar[i] == 'u')
                {
                    ar[i] = 'v';
                }
            } 

            Console.WriteLine(string.Join("",ar));

        }
    }
}
