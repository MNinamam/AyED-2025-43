using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Mamani_Torres_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el mes ");

            int mes = Int32.Parse(Console.ReadLine());

            if ((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12))
                Console.WriteLine("tiene 31 dias");
            else if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                Console.WriteLine("tiene 30 dias");
            else
                Console.WriteLine("tiene 28 dias");

            Console.ReadKey();

        }
    }
}
