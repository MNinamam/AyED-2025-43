using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Cortinez_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, superficie, volumen;
            Console.Write(" Ingrese un numero para el radio de la esfera ");
            radio = int.Parse(Console.ReadLine());
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            superficie = 4 * Math.PI * Math.Pow(radio, 2);
            Console.WriteLine(" La superficie de la esfera es = " + superficie);
            volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);
            Console.WriteLine(" El volumen de la esfera es = " + volumen);
            Console.ReadKey();
        }
    }
}
