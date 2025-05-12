using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Mamani_Torres_10bis
{
    class Program
    {
        static void Main(string[] args)
        {
            int grados;
            Console.WriteLine(" Ingrese una cantidad de grados ");
            grados = int.Parse(Console.ReadLine());
            Double faren = (grados * 1.8) + 32;
            Console.WriteLine(" De grados a farenheit es " + faren);
            Double kelvin = grados + 273.5;
            Console.WriteLine(" De gradso a kelvin es " + kelvin);
            Console.ReadKey();
        }
    }
}
