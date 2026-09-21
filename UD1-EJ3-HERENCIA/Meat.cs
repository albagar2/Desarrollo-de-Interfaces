using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Meat : Ingredient
    {
        public string Type { get; set; } // Tipo de carne (res, cerdo, pollo, etc.)
        public Meat(string name, double amount, string type) : base(name, amount)
        {
            Type = type;
        }

        // Sobrescribimos el método Prepare para la carne
        public override void Prepare()
        {
            base.Prepare(); // Llamamos al método base para mostrar la preparación general
            Console.WriteLine($"Preparando la carne de tipo {Type}");
        }
    }
}
