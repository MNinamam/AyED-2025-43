using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Ingrese el tamaño de las filas ");
            int tamfilas = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese el tamaño de las filas ");
            int tamcolumnas = int.Parse(Console.ReadLine());

            int[,] matrices = new int[tamfilas, tamcolumnas];

            for (int i = 0; i < tamfilas; i++)
            {
                for (int j = 0; j < tamcolumnas; j++)
                {
                    Console.Write(matrices[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
