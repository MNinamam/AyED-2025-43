using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string op1, op2, op3, seleccion;

            Console.WriteLine(" Bienvenido al programa");
            Console.WriteLine ("Seleccione una opcion ingresando su numero correspondiente");
            Console.Write(" 1.OPCION.1 ");
            Console.Write(" 2.OPCION.2 ");
            Console.Write(" 3.OPCION.3 ");
            Console.Write(" 4.OPCION.4 ");
            seleccion = Console.ReadLine();

            while (seleccion != "4")
            {
                if (seleccion == "1")
                {
                    int n1, n2, suma;
                    Console.WriteLine(" Ingrese 2 números enteros para sumarlos ");
                    n1 = int.Parse(Console.ReadLine());
                    n2 = int.Parse(Console.ReadLine());
                    suma = n1 + n2;
                    Console.WriteLine(n1 + " + " + n2 + " = " + suma);
                }
                else if (seleccion == "2")
                {
                    Console.WriteLine(" Seleccionaste la opcion 2 te felicito CRACK ");
                }
                else if (seleccion == "3")
                {
                    int n3, n4, resta;

                    Console.WriteLine(" Ingrese 2 numeros enteros para restarlos ");

                    n3 = int.Parse(Console.ReadLine());
                    n4 = int.Parse(Console.ReadLine());
                    resta = n3 - n4;

                    Console.WriteLine(n3 + " + " + n4 + " = " + resta);
                }
                else if (seleccion == "4")
                {
                    Console.WriteLine(" CHAU CRA ");
                }
            }
            Console.ReadKey();
     

        }
    }
}
