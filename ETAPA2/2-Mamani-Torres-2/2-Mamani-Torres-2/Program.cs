using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mamani_Torres_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pasaexamen = false;
            bool pasatps = false;

            Console.WriteLine(" ¿ Cuantos TPs tienen ?");
            int TPS = int.Parse(Console.ReadLine());
            Console.WriteLine(" ¿ Cuantos examanes tienen ?");
            int examenes = int.Parse(Console.ReadLine());

            int[] notporexamen = new int[examenes];
            int[] notportps = new int[TPS];

            double totalexamen = 0;

            for (int i = 1; i <= examenes; i++)
            {
                Console.WriteLine(" ¿ Cuanto se sacaron en el examen N° " + i );
                notporexamen[i-1] = int.Parse(Console.ReadLine());
                totalexamen += notporexamen[i-1];

                double promedio = totalexamen / examenes; 
                 
                if (promedio >= 6)
                {
                    pasaexamen = true;
                }
                else
                {
                    pasaexamen = false;
                }
            }

            double totaltps = 0;
            for (int i = 1; i <= TPS; i++)
            {
                Console.WriteLine(" ¿ Cuanto se sacaron en el tp N° " + i);
                notportps[i - 1] = int.Parse(Console.ReadLine());

                totaltps += notportps[i-1];

                double porcentaje =  totaltps * 0.75;                  
                if (porcentaje >= 6)
                {
                    pasatps = true;

                }   
            }
            

            if (pasaexamen == true && pasatps == true)

            {
                Console.WriteLine(" Fhinias y Ferb Pasan ");
            }
            else
            {
                Console.WriteLine("Fhinias y Ferb No Pasan ");
            }
            Console.ReadKey();
            
        }
    }
}
