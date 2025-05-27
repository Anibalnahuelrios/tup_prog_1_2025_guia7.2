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

            Console.WriteLine("Ingrese el nombre del primer alumno");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ahora ingrese la nota del primer alumno");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del segundo alumno");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ahora ingrese la nota del segundo alumno");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del tercer alumno");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Ahora ingrese la nota del tercer alumno");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            if (nota1 > nota2 && nota2 > nota3)
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre1 + ", " + nombre2 + ", " + nombre3);
            }
            else if (nota1 > nota2 && nota3 > nota2)
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre1 + ", " + nombre3 + ", " + nombre2);
            }
            else if (nota2 > nota1 && nota1 > nota3)
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre2 + ", " + nombre1 + ", " + nombre3);
            }
            else if (nota2 > nota1 && nota3 > nota1)
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre2 + ", " + nombre3 + ", " + nombre1);
            }
            else if (nota3 > nota1 && nota1 > nota2)
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre3 + ", " + nombre1 + ", " + nombre2);
            }
            else
            {
                Console.WriteLine("El orden de los alumnos es: " + nombre3 + ", " + nombre2 + ", " + nombre1);
                Console.ReadKey();
            }
        }
    }
}