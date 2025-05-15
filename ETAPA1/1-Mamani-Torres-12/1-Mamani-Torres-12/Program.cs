using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string pr;

            Console.WriteLine(" ¿ Desea finalzar el trabajo ? ");
            pr = Console.ReadLine();

            while (pr != "SI")
            {
                Console.WriteLine(" ¿ Desea finalzar el trabajo ? ");
                pr = Console.ReadLine();                               
            }
           
            Console.ReadKey();
        }
    }
}
