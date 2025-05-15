using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine( " Ingrese su edad " );
            edad = int.Parse(Console.ReadLine());

            for (int i = 0; i < edad; i ++  )
            {
                Console.WriteLine(i+1);
            }
            Console.ReadKey();
        }
        
    }
}
