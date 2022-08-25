using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array_Topic.Home_Work
{
    class FreqGivenNumber
    {
        public void FindFrq(int[] b)
        {
            Console.WriteLine("enter one element in array");
            int num = int.Parse(Console.ReadLine());
            int c = 0;
            for(int i = 0; i < b.Length; i++)
            {

                if (b[i] == num)
                {
                    c++;
                }
            }
            Console.WriteLine("Frequency of this element= "+c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("enter array element");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            FreqGivenNumber f = new FreqGivenNumber();
            f.FindFrq(a);
        }
    }
}
