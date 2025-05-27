using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, mayor = double.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el valor : ");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero > mayor)
                {
                    mayor = numero;
                }
            }

            Console.WriteLine("El número mayor ingresado es: " + mayor );
            Console.ReadKey();
        }
    }
}
