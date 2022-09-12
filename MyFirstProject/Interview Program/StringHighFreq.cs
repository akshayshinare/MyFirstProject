using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Interview_Program
{
    class StringHighFreq
    {
        static void Main(string[] args)
        {
            string s = "ThinkQuotient";
             s=s.ToLower();
            char[] arr = s.ToCharArray();

            for(int i = 0; i < arr.Length; i++)
            {
                int c = 1;
                bool isvisited = false;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        isvisited = true;
                        break;
                    }
                }

                if (isvisited == false)
                {
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                        }
                    }
                    Console.WriteLine(arr[i] + "= " + c);
                }


            }
        }
    }
}
