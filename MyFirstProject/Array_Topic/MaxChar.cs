using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class MaxChar
    {
        public static char FindMax(char[] ch)
        {
            char max = ch[0];
            foreach(int x in ch)
            {
                Console.WriteLine((char)(x) + " " + x);
            }
            for(int i = 0; i < ch.Length; i++)
            {
                if (max < ch[i])
                {
                    max = ch[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            char[] c = { 'a', 'u', 'R', 'd', 'W' };

            int ans = MaxChar.FindMax(c);
            Console.WriteLine("Max char array= " + ans);
        }
    }
}
