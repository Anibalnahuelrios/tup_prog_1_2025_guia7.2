using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double puntosjuador1, puntosjugador2, setganadosjug1, setganadosjug2;
            string jugador1, jugador2;



            puntosjuador1 = 0;
            puntosjugador2 = 0;
            setganadosjug1 = 0;
            setganadosjug2 = 0;


            Console.WriteLine("ingrese el nombre del jugador 1");
            jugador1 = Console.ReadLine();

            Console.WriteLine("ingrese el nombre del jugador 2");
            jugador2 = Console.ReadLine();

            for (int i = 0; i < 3; ++i) 
            {
                Console.WriteLine("ingrese los puntos del : " + jugador1);
                puntosjuador1 = Convert.ToInt32(jugador1);

                Console.WriteLine("ingrese los puntos del : " + jugador2);
                puntosjuador1 = Convert.ToInt32(jugador2);

                if (puntosjuador1 > puntosjugador2)
                {
                    setganadosjug1 = setganadosjug1 + 1;
                    Console.WriteLine("el set :" + (i + 1) + "lo gano " + jugador1);

                }
                else
                {
                    setganadosjug2 = setganadosjug2 + 1;
                    Console.WriteLine("el set : " + i + "lo gano : " + jugador2);

                }

                if (setganadosjug2 > setganadosjug1)
                {
                    Console.WriteLine("el gandor del juego es : " + jugador1);

                }
                else
                {
                    Console.WriteLine("gano el : " + jugador2);
                }
                Console.ReadKey();



            }

        }
    }
}
