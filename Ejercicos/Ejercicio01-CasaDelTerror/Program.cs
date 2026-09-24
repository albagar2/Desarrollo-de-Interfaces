using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CasaDelTerror
{
    internal class Program
    {
        //clase base significa que es la clase padre de la que van a heredar las demas clases
        static void Main(string[] args)
        {
            try
            {
                Atraccion atraccion1 = new Atraccion("Montaña rusa", 12, 120, 5.0);
                Console.WriteLine("Bienvenido a la feria!!!");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Introduce tu edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduce tu altura en cm: ");
                int altura = int.Parse(Console.ReadLine());

                var valido = atraccion1.AdmitirVisitante(edad, altura);

                if (valido)
                {
                    Console.WriteLine("Puedes acceder a la atracción Casa del terror");
                    CasaDelTerror atraccion2 = new CasaDelTerror("Casa del terror", edad, altura, 5.5, 8);
                    atraccion2.AdmitirVisitante(edad, altura);
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no puedes acceder a la atracción Casa del terror");
                }

               
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debes introducir un número válido para la edad y la altura.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido un error inesperado: {ex.Message}");
            }
        }
    }
}
