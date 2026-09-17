using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ1_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de Variables
                // e inicialización de un array de 3 elementos de tipo string
            String[] people = new string[3];
            
            int count = 0;


            // Pedimos al usuario datos de entrada 
            while (count < people.Length)
            {
                // Console.WriteLine("Escribe la palabra número " + (count + 1));

                // En el lenguaje C# si hay una variable se pone $ 
                Console.WriteLine($"Escribe la palabra número {count + 1}:");
                people[count] = Console.ReadLine();
                count++;
            }

            // Mostramos los datos de nuevo en pantalla
            foreach (String i in people)
            {
                Console.WriteLine(i);
            }

        }
    }
}
