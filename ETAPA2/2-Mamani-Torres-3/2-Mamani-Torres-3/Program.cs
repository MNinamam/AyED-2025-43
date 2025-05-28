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
            Console.Write(" ¿ Cunatos participantes hay ? ");
            int participantes = int.Parse(Console.ReadLine());
            int[] puntajexparticpante = new int[participantes];


            for (int i = 1; i <= participantes; i++)
            {
                Console.WriteLine(" Cual es el puntaje del participante N° " + i);
                puntajexparticpante[i - 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < participantes - 1; i++)
            {
                for (int j = i + 1; j < participantes; j++)
                {
                    if (puntajexparticpante[i] > puntajexparticpante[j])
                    {
                        int aux = puntajexparticpante[i];

                        puntajexparticpante[i] = puntajexparticpante[j];
                        puntajexparticpante[j] = aux;


                    }
                }
            }

            Console.WriteLine(" El mayor puntaje es " + puntajexparticpante[puntajexparticpante.Count() - 1]);
            Console.WriteLine(" El menor puntaje es " + puntajexparticpante[0] );
            Console.WriteLine(" Los puntajes ordenados de menor a mayor: ");
            for (int i = 0; i < participantes; i++)
            {
                Console.WriteLine(puntajexparticpante[i]);  
            }
                
            Console.ReadKey();
        }
    }
}
