using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;
            bool cobrarbeca;

            Console.WriteLine(" Ingrese su edad ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese sus ingresos mensuales ");
            ingresos = int.Parse(Console.ReadLine());

            cobrarbeca = false;

            if ( edad > 19 && ingresos <= 100000 )
            {
                cobrarbeca = true;
            }
           
            else if ( edad < 19 && ingresos == 0)
            {
                cobrarbeca = true;
            }
    
            else if ( edad == 19 && ingresos <= 50000 && ingresos > 0 )
            {
                cobrarbeca = true;
            }
            else
            {
                cobrarbeca = false;
            }
            /////////////////////////////////////////
            if ( cobrarbeca == true )
            {
                Console.WriteLine(" Podes recibir la beca Juan Pedro ");
            }
            else
            {
                Console.WriteLine(" No podes recibir la beca Juan Pedro ");
            }
            Console.ReadKey();

        }
    }
}
