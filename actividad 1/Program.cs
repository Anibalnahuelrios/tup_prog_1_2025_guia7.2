using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio, nota1, nota2, nota3;


            Console.WriteLine("escribe la primera nota");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escribe la segunda nota");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escribe la tercera nota");
            nota3 = Convert.ToDouble(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio > 6)
            {
                Console.WriteLine("usted promociona");
            }
            else if (4 <= promedio)

            {
                Console.WriteLine("usted va a regular");
            }
            else
            {
                Console.WriteLine("estas libre");
            }

                Console.WriteLine("el promedio de las notas es: " + promedio);
            Console.ReadKey ();

            
        
        }
    }
}
