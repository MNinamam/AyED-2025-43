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
            int gradosC;

            Console.WriteLine(" Ingresar cantidad de grados ");
            gradosC = int.Parse(Console.ReadLine());

            if (gradosC <= 0)
            {
                Console.WriteLine(" Se congela");
            }
            else if (gradosC >= 100)
            {
                Console.WriteLine(" Hierve ");
            }
            else if (gradosC >= 1 && gradosC < 100)
            {
                Console.WriteLine(" Esta en estado liquido ");
            }


        }
    }
}
