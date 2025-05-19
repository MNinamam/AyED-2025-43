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
            bool salir = false;
            ////////////////////////////////////////
            do
            { 
                Console.WriteLine(" Bienvenido al programa");
                Console.WriteLine("Seleccione una opcion ingresando su numero correspondiente");
                Console.Write(" 1.OPCION.1 ");
                Console.Write(" 2.OPCION.2 ");
                Console.Write(" 3.OPCION.3 ");
                Console.Write(" 4.OPCION.4 ");

                string seleccion = Console.ReadLine();
                //////////////////////////////////////////////            
                switch (seleccion)
                {
                    case "1":
                        int n1, n2, suma;
                        Console.WriteLine(" Ingresa 2 numeros para sumarlos ");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        suma = n1 + n2;
                        Console.WriteLine( n1 + " + " + n2 + " = " + suma);
                    break;
                    case "2":
                        Console.WriteLine(" 😄 ¿Por qué los programadores odian el verano? Porque hay demasiados bugs. 🐞☀️ ");
                    break;
                    case "3":
                        Console.WriteLine(" No esperes el momento perfecto; haz que el momento sea perfecto. ✨ ");
                    break;
                    case "4":
                        Console.WriteLine(" Chau cra ");
                        salir = true;
                    break;
                    default:
                        Console.WriteLine(" Opcion invaldia, intente de nuevo ");
                    break ;
                }
            }while (!salir);
        }        
    }

}



            
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
            bool salir = false;
            ////////////////////////////////////////
            do
            { 
                Console.WriteLine(" Bienvenido al programa");
                Console.WriteLine("Seleccione una opcion ingresando su numero correspondiente");
                Console.Write(" 1.OPCION.1 ");
                Console.Write(" 2.OPCION.2 ");
                Console.Write(" 3.OPCION.3 ");
                Console.Write(" 4.OPCION.4 ");

                string seleccion = Console.ReadLine();
                //////////////////////////////////////////////            
                switch (seleccion)
                {
                    case "1":
                        int n1, n2, suma;
                        Console.WriteLine(" Ingresa 2 numeros para sumarlos ");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        suma = n1 + n2;
                        Console.WriteLine( n1 + " + " + n2 + " = " + suma);
                    break;
                    case "2":
                        Console.WriteLine(" 😄 ¿Por qué los programadores odian el verano? Porque hay demasiados bugs. 🐞☀️ ");
                    break;
                    case "3":
                        Console.WriteLine(" No esperes el momento perfecto; haz que el momento sea perfecto. ✨ ");
                    break;
                    case "4":
                        Console.WriteLine(" Chau cra ");
                        salir = true;
                    break;
                    default:
                        Console.WriteLine(" Opcion invaldia, intente de nuevo ");
                    break ;
                }
            }while (!salir);
        }        
    }

}



            
       