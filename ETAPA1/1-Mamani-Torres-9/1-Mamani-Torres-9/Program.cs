using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine(" Ingrese un numero entero positivo ");
            num = int.Parse(Console.ReadLine());

            for (int i = num+1; i > 0; i -- )
            {
                Console.WriteLine(i-1);
            }
            Console.ReadKey();

            

        }
    }
}
