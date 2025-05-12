using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña, usuario;

            contraseña = ("contraseña");
            Console.WriteLine(" Ingrese la contraseña ");
             usuario = Console.ReadLine().ToLower();
            if ( usuario == contraseña )
            {
                Console.WriteLine(" La contraseña ingresada coincide con la guardada ");
            }
            else
            {
                Console.WriteLine(" La contraseña ingresada no coincide con la guardada ");
            }
            Console.ReadKey();
        }
    }
}
