using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine(" Ingrese el tamaño de las filas ");
            int tamfilas = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el tamaño de las columnas ");
            int tamcolumnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamfilas, tamcolumnas];

            for (int i = 0; i < tamfilas; i++)
            {
                for (int j = 0; j < tamcolumnas; j++)
                {
                    matriz[i, j] = aleatorio.Next(0, 100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
