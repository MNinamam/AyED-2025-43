using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Cortinez_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.Write(" Ingrese un numero ");

            n1 = int.Parse(Console.ReadLine());
            Console.Write(" Ingrese otro numero ");

            n2 = int.Parse(Console.ReadLine());
            resultado = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + resultado);
            Console.ReadKey();
        }
    }
}
