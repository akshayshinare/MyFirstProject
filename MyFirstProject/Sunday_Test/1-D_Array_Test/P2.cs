﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Sunday_Test._1_D_Array_Test
{
    
        class Test
        {
            static int mcCartyCounter = 100;
            public static int mcCarthy(int n)
            {
                mcCartyCounter++;
                if (n > 100)
                    return n - 10;
                else
                    return mcCarthy(n + 11);
            }
            public static void main(String[] args)
            {
                Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);
            }
        }

}

