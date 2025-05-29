using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int productosvendidos;
            Console.Write(" ¿ Cunatos productos se vendieron durante el hotsale ? ");

            productosvendidos = int.Parse(Console.ReadLine());
            int[] PrecioDeCadaPro = new int[productosvendidos];

            for (int i = 0; i < productosvendidos; i++)
            {
                Console.Write(" Cual es el precio del producto " + (i+1) + " : ");

                PrecioDeCadaPro[i ] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < productosvendidos - 1; i++)
            {
                for (int j = i + 1; j < productosvendidos; j++)
                {
                    if (PrecioDeCadaPro[i] > PrecioDeCadaPro[j])
                    {
                        int aux = PrecioDeCadaPro[i];

                        PrecioDeCadaPro[i] = PrecioDeCadaPro[j];
                        PrecioDeCadaPro[j] = aux;
                    }
                }
            }

            Console.WriteLine(" El producto con el precio mas alto es: " + PrecioDeCadaPro[PrecioDeCadaPro.Length - 1]);
            Console.WriteLine(" El producto con el precio mas bajo es: " + PrecioDeCadaPro[0]);
        }
    }
}