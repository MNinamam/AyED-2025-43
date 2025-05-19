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
            string nombre = "jugador1", seleccion;
            int salud = 100;
            int monedas = 50;
            int enemigosDerrrotados = 0;
            bool tieneEspada = false, salir = false;  
            ////////////////////////////////

            do
            {
                Console.WriteLine("                              ");
                Console.WriteLine(" 1 MOSTRAR ESTADO DEL JUGADOR ");
                Console.WriteLine(" 2 ENCONTRAR ESPADA MAGICA ");
                Console.WriteLine(" 3 PELEAR CONTRA UN ENEMIGO  ");
                Console.WriteLine(" 4 COMPRAR POCION DE VIDA (VALE 20 MONEDAS) ");
                Console.WriteLine(" 5 SALIR DEL JUEGO ");
                Console.WriteLine(" SELECCIONE UNA OPCION: ");

                seleccion = Console.ReadLine();

                switch (seleccion)
                {
                    case "1":
                        Console.WriteLine(" Nombre " + nombre + " Salud: " + salud + " Monedas:" + monedas + " Enemigos derrotados: " + enemigosDerrrotados + " Tiene Espada: " + tieneEspada);
                        break;
                    case "2":
                        if (tieneEspada == true)
                        {
                            Console.WriteLine(" Ya tenes la Espada ");
                        }
                        else
                        {
                            Console.WriteLine(" Encontraste la espada ");
                        }
                        tieneEspada = true;
                        break;
                    case "3":
                        if (tieneEspada == true)
                        {
                            salud = salud - 10;
                            enemigosDerrrotados = enemigosDerrrotados + 1;
                            Console.WriteLine(" ¡Ganaste la batalla! Salud -10 ");
                        }
                        else if (tieneEspada == false)
                        {
                            salud = salud - 30;
                            Console.WriteLine(" ¡Fue una pelea dura sin espada! Salud -30 ");
                        }
                        break;
                    case "4":
                        if (monedas >= 20)
                        {
                            monedas = monedas - 20;
                            salud = salud + 20;
                            Console.WriteLine(" Usaste una poción. +20 de salud. ");
                        }
                        else
                        {
                            Console.WriteLine(" No tenés suficientes monedas. ");
                        }
                        break;
                    case "5":
                        Console.WriteLine(" ¡Gracias por jugar! ");
                        salir = true;
                        break;
                    default:

                        Console.WriteLine(" Opción inválida. Elegí una opción del 1 al 5. ");
                    break;
                }
            } while (!salir);
        }
    }
}