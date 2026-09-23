using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ6_LISTAS
{
    internal class Card
    {
        // clase de cromos para despues crear lista de este tipo de objeto

        // enumerado para definir las categorias de los cromos
        public enum CategoryCard { Bronce, Plata, Oro }
        // propiedades de la clase
        public int NumberCard { get; set; }
        // propiedad de tipo string para el nombre del cromo
        public string NameCard { get; set; }
        // propiedad de tipo CategoryCard para la categoria del cromo
        public CategoryCard MyCategoryCard { get; set; }


        //creamos un constructor vacio
        public Card(){ }

        //y otro constructor que reciba los parametros de las propiedades
        public Card(int number, string name, CategoryCard category)
        {
            NumberCard = number;
            NameCard = name;
            MyCategoryCard = category;
        }





    }
}
