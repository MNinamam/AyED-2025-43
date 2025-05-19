using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Mamani_Torres_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();
            ////////////////////////////////

            do
            {
                for (dia = 1; dia < 7; dia++) 
                {

                    Console.WriteLine(" Día " +dia+ " ¿Qué querés hacer ? ");
                    Console.WriteLine(" 1.Buscar comida "); 
                    Console.WriteLine(" 2.Dormir " ); 
                    Console.WriteLine(" 3.Explorar la isla "); 
                    Console.WriteLine(" 4.Ver estado del personaje "); 
                    Console.WriteLine(" 5.Salir del juego "); 
                    Console.WriteLine(" Elegi una opcion: ");

                    string seleccion = Console.ReadLine();

                    switch (seleccion)
                    {
                        case "1":
                            hambre = hambre + 20;
                            energia = energia - 15;
                            int probabilidad = rand.Next(1, 101);
                            if (probabilidad <= 30)
                            {
                                Console.WriteLine(" Comiste algo en mal estado. Salud -15 ");
                                salud = salud - 15;
                            }
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine(" Te desmayaste y no pudiste sobrevivir... Game Over ☠️ ");
                                sigueVivo = false;
                            }
                        break;

                        case "2":
                            energia = energia + 30;
                            hambre = hambre - 10;
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine(" Te desmayaste y no pudiste sobrevivir... Game Over ☠️ ");
                                sigueVivo = false;
                            }
                        break;

                        case "3":
                            energia = energia - 20;
                            hambre = hambre - 15;
                            probabilidad = rand.Next(1, 101);
                            if (probabilidad <= 50)
                            {
                                Console.WriteLine(" ¡Encontraste una planta curativa! Salud +10 ");
                                salud = salud + 10;
                            }
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine(" Te desmayaste y no pudiste sobrevivir... Game Over ☠️ ");
                                sigueVivo = false;
                            }
                        break;

                        case "4":
                            Console.WriteLine(" SALUD: " + salud + " HAMBRE: " + hambre + " ENERGIA: " + energia + " DIA " + dia);
                        break;

                        case "5":
                            Console.WriteLine(" El juego termino. ");
                            sigueVivo = false;
                        break;

                        default:
                            Console.WriteLine(" Opción inválida. Elegí una opción del 1 al 5 ");

                        break;

                    }
                }                   
            } while (!sigueVivo);
        }
    }
}
