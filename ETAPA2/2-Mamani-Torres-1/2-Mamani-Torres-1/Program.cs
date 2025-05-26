using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2_Mamani_Torres_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" De cuantas vueltas es la carrera ?");
            int vueltas = int.Parse(Console.ReadLine());
            int[] tievueltas = new int[vueltas];

            for (int i = 1; i <= vueltas; i++)
            {
                Console.WriteLine(" Cual fue le tiempo de la vuelta N: " + i + " ? ");
                tievueltas[i-1] = int.Parse(Console.ReadLine());
            }

            double tiempoTotal = 0;
            int mejortiempo = tievueltas[0];
            int mejorvuelta = 1;

            for (int y = 0; y < vueltas; y++)
            {
                tiempoTotal += tievueltas[y];

                if (tievueltas[y] < mejortiempo)
                {
                    mejortiempo = tievueltas[y];
                    mejorvuelta = y + 1;
                }
            }
            double promedio = tiempoTotal / vueltas;

            Console.WriteLine("Tiempo total de carrera: " + tiempoTotal + " segundos ");
            Console.WriteLine("Promedio por vuelta: " + promedio + " segundos");
            Console.WriteLine("Mejor vuelta: Vuelta " + mejorvuelta + " con " + mejortiempo + " segundos");

            Console.ReadKey();
        }     
    }
}