using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese la cantidad de filas ");
            int filas = int.Parse(Console.ReadLine());
            string[,] matriz = new string[filas, 3];

            int j = 0;
            for (int i = 0; i < filas; i++) 
            {
                Console.WriteLine(" Ingrese la calificacion del alumno " );
                matriz[i, j] = (int.Parse(Console.ReadLine())).ToString();

                Console.WriteLine(" Ingrese el nombre del alumno " );
                matriz[i, (j+1)] = Console.ReadLine();

                Console.WriteLine(" Ingrese la edad del alumno " );
                matriz[i, (j+1)] = (int.Parse(Console.ReadLine())).ToString();

                Console.Write(matriz[i,j]+"\t");
            }
            Console.WriteLine();
            Console.ReadKey();
        } 
        
    }
}
