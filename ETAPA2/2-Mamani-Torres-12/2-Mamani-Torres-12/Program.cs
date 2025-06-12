using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            Console.WriteLine( " Ingrese el tamaño de la matriz " );
            int tamaño = int.Parse(Console.ReadLine());
            int[] vector = new int[tamaño];
            int[,] matriz = new int[tamaño, tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {                   
                    matriz[i,j] = aleatorio.Next(0, 50);

                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();


            }
            int h = 0;
            for (int i = 0; i < tamaño; i++ )
            { 
                vector[i] = matriz[i, h];
                h++;
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
            
        }
    }
}
