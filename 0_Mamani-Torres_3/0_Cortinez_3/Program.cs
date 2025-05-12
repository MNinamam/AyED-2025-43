using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Cortinez_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;

            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Edad = int.Parse (Console.ReadLine());
            Console.WriteLine(" Hola " + Nombre + " tu edad es " + Edad );
            Console.ReadKey();
        }
    }
}
