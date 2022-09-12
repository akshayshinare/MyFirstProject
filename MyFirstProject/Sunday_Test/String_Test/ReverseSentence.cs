using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test.String_Test
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string str = "Help others";

            for(int i = str.Length - 1; i > 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
