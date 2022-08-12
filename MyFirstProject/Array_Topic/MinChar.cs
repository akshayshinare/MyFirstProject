using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic
{
    class MinChar
    {
        public char FindMin(char[] c)
        {
            char max = c[0];

            foreach(char b in c)
            {
                Console.WriteLine(b);
            }
            for(int i = 0; i < c.Length; i++)
            {
                if (max > c[i])
                {
                    max = c[i];
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            char[] a = { 'a', 's', 'W', 'x', 'v' };
            MinChar m = new MinChar();
            char ans = m.FindMin(a);

            Console.WriteLine("Minimum= " + ans);

        }
    }
}
