﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine(" Ingrese su edad. ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine(" Sos mayor de edad ");
            }
            else
            {
                Console.WriteLine(" Sos menor de edad ");
            }
            Console.ReadKey();
        }
    }
}
