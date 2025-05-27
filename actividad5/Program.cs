using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, posicion, menor;

            menor = 3000;
            posicion = 0;

            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("ingrese el numero" + (i + 1));
                num = Convert.ToDouble(Console.ReadLine());

                if (num < menor)
                {

                    menor = num;
                    posicion = i + 1;
                }

                
            }
            Console.WriteLine("el numero menor es :  "   +menor + "  en la posicion : "+posicion);
            Console.ReadKey();


        }
    }
}
