﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightpoint
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1; i < 101; i++)

                if (i % 3  == 0)
                {
                    Console.WriteLine("right");
                }
            else if (i % 5 == 0)
                {
                    Console.WriteLine("point");
                }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
