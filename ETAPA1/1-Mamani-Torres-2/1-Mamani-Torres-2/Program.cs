using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, division;

            Console.WriteLine(" Ingrese 2 núumeros ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            

            if (numero2 == 0)
            {
                Console.WriteLine(" Error ");
            }
            else
            {
                division = numero1 / numero2;
                Console.WriteLine(+numero1 + " % " + numero2 + " = " + division);
            }
            Console.ReadKey(); 
        }
    }
}
