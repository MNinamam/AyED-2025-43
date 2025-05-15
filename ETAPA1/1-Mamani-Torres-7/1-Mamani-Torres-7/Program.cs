using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            Console.WriteLine(" Ingrese una palabra ");
            palabra = Console.ReadLine();

            for ( int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadKey();


        }
    }
}
