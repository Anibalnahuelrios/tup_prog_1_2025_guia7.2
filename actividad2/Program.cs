using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, positivo, negativo;

            Console.WriteLine("escriba un numero");
           num = Convert.ToDouble(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("el numero es cero");
            }
            else
                if (num > 0)
            {
                Console.WriteLine("el numero es positivo");
            }
            else
                if (num < 0)
            {
                Console.WriteLine(" el numero es negativo");
            }
            Console.ReadKey();


        }
    }
}
