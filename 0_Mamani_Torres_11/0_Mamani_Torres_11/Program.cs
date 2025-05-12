using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Mamani_Torres_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, P, A, H, sumadr;

            Console.WriteLine(" Ingrese un ancho (x) ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese la altura (y) ");
            y = double.Parse(Console.ReadLine());
            A = (x * y) / 2;
            Console.WriteLine(" El area del triangulo es " + A);
            sumadr = Math.Pow(x, 2) + Math.Pow(y, 2);
            H = Math.Sqrt(sumadr);
            Console.WriteLine(" La diagonal del triangulo es " + H);
            P = H + x + y;
            Console.WriteLine(" El perimetro es " + P);
            Console.ReadKey();
        }
    }
}


