using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    class MinFreqArray
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enetr array size");
            int size = int.Parse(Console.ReadLine());

            char[] ch = new char[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }

            for(int i = 0; i < ch.Length; i++)
            {
                int c = 1;
                bool isvisited = false;
                for(int j = i - 1; j >= 0; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int k = i + 1; k < ch.Length; k++)
                    {
                        if (ch[i] == ch[k])
                        {
                            c++;
                        }
                    }
                    if (c <= 1)
                    {
                        Console.WriteLine("minimum frequency= "+ch[i]);
                    }
                }
            }
        }
    }
}
