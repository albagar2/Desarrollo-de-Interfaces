using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Meat pig = new Meat("Solomillo", 500 , "cerdo ibérico");
            Vegetable lettuce = new Vegetable("Lechuga", 200);


            pig.Prepare();
            lettuce.Prepare();
        }
    }
}
