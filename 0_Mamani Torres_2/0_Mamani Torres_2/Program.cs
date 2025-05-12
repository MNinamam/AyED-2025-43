using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Mamani_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int edad;

            Console.WriteLine(" Ingrese su nombre ");
            Nombre = Console.ReadLine();
            Console.WriteLine(" Ingrese su edad ");
            edad = int.Parse (Console.ReadLine());
            Console.WriteLine(" Hola " + Nombre + " tu edad es " + edad);
            Console.ReadKey();
        }
    }
}
