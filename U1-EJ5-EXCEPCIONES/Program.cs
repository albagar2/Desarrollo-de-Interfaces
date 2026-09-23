using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ5_EXCEPCIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                // COGEMOS UN FICHERO DE TEXTO CREADO Y LO LEEMOS 

                //CREACION DE UN FICHERO DE TEXTO
                string pathfile = @"C:\Users\nocturno\Desktop\Desarrollo de Interfaces\ficheros\fichero1.txt";

                // si ponemos una sola barra lo coge como especial y da error, por eso ponemos doble barra o antes de las comillas ponemos @


                // Vamos a usar StreamWriter para crear el fichero de texto y escribir en él
                StreamWriter myfile = File.CreateText(pathfile);
                // el createText crea el fichero y lo abre para escribir en él, si no existe lo crea, si existe lo sobreescribe

                // Escribimos en el fichero de texto
                myfile.WriteLine("Ejemplo de excepciones del tema 1");
                myfile.WriteLine("Ejemplo 5. Miercoles 23 de septiembre de 2026");


                myfile.Close(); // cerramos el fichero para que se guarde y no se quede abierto


                StreamReader fileReader = new StreamReader(pathfile); // abrimos el fichero para leerlo
                string text = fileReader.ReadToEnd(); // leemos todo el contenido del fichero
                Console.WriteLine(text); // mostramos el contenido del fichero en la consola
                fileReader.Close(); // cerramos el fichero para que se guarde y no se quede abierto



                // PARA OCULTAR EL ERROR AL USUARIO , USAMOS TRY CATCH, PARA QUE NO SE CIERRE EL PROGRAMA Y NOS MUESTRE EL ERROR
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("No se encontró el archivo: " + ex.Message);

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No tiene permisos para acceder al archivo: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error de entrada/salida: " + ex.Message);
            }
            catch (Exception ex)
            { // catch genérico para cualquier otro tipo de excepción, ponerla al ser generica
                Console.WriteLine("Error al trabajar con el fichero: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ejecutamos este codigo siempre, entre o no entre en el try catch");
            }
        }
    }
}
