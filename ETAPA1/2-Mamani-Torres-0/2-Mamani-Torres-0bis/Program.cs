using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] invitados;
            int[] comidaxpers;
            int total = 0;
            Double promedio;
            //////////////////////////////////////
            Console.WriteLine(" Ingresa la cantidad de invitados(max: 100) ");
            invitados = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine(" Ingresa la cantidad de comida que cada invitado consume(max:100) ");
            comidaxpers = new int[invitados.Count()];

            for (int i = 0; i < invitados.Count(); i++)
            {
                Console.WriteLine("Cuanta comida come el invitado " + (i + 1) + " : ");
                comidaxpers[i] = int.Parse(Console.ReadLine());
                total += comidaxpers[i];
                //promedio = invitados.Count() / total;
                //Console.WriteLine(" El total de comida es: " + total +  " y el promedio de comida x perosna es: " + promedio);
            }
            promedio = total / invitados.Count();
            Console.WriteLine(" El total de comida es: " + total + " y el promedio de comida x perosna es: " + promedio);
            Console.ReadKey();
        }

    }
}
