using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Vegetable : Ingredient
    {
        public Vegetable(string name, double amount) : base(name, amount)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"Lavando y cortando {Amount} gramos de {Name}");
        }
    }
}
