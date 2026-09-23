using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ6_LISTAS
{
    internal class Program
    {
        //vamos a crear la lista fuera del main para que sea accesible desde cualquier metodo de la clase
        // como el metodo main es static la variable tiene que ser static tambien
        static List<Card> ListCard = new List<Card>();

        static void Main(string[] args)
        {
            // LAS LISTAS SON DINAMICAS, SE PUEDEN AÑADIR ELEMENTOS Y ELIMINAR ELEMENTOS SIN NECESIDAD DE REDIMENSIONARLA
            // ES UNA COLECCION DE ELEMENTOS DEL MISMO TIPO, SE PUEDE ACCEDER A ELLOS POR SU INDICE, SE PUEDE RECORRER CON UN BUCLE FOR O FOREACH
            // HACEMOS EN CLASES


            //vamos a crear un cromo y lo añadimos a la lista
            Card card1 = new Card(101, "Messi", Card.CategoryCard.Oro);
            ListCard.Add(card1);
            ListCard.Add(new Card(102, "Ronaldo", Card.CategoryCard.Bronce));

            //vamos a recorrer la lista y mostrar los cromos
            Console.ForegroundColor = ConsoleColor.Blue; // cambiamos el color de la consola a azul

            CheckListCard();

            //vamos a realizar otras operaciones
            List<Card> AuxList = new List<Card>()
            {
                new Card(103, "Ferrán Torres", Card.CategoryCard.Plata),
                new Card(104, "Neymar", Card.CategoryCard.Oro)
            };

            //eliminamos objetos de la lista, no podemos eliminar los dos ultimos creados porque no los hemos añadido a la lista principal
            ListCard.Remove(card1); //eliminamos el cromo de Ronaldo

            //añadimos la lista auxiliar a la lista principal
            ListCard.AddRange(AuxList);

            //mostramos la lista de nuevo
            Console.ForegroundColor = ConsoleColor.Green; // cambiamos el color de la consola a verde

            CheckListCard();

            Console.ResetColor(); // reseteamos el color de la consola a su valor por defecto
        }

        //no hay que pasar la lista porque es una variable global, pero si la lista fuera local al main habria que pasarla como parametro
        private static void CheckListCard()
        {
            foreach (Card card in ListCard)
            {
                Console.WriteLine($"Número: {card.NumberCard} , nombre: {card.NameCard} y su categoria es {card.MyCategoryCard}");
            }
        }
    }
}
