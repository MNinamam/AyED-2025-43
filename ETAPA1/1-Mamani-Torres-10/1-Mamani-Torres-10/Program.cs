﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine( " Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine( " Buzz ");
                }
                else
                    Console.WriteLine(i);

                

            }
            Console.ReadKey();
        }
    }
}
