using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CasaDelTerror
{
    internal class Atraccion
    {
        string nombre { get; set; }
        int edadMinima { get; set; }
        int alturaMinima { get; set; }
        double precio { get; set; }

        public Atraccion (string nombreA, int edad, int altura, double precioA)
        {
            nombre = nombreA;
            edadMinima = edad;
            alturaMinima = altura;
            precio = precioA;

        }

        public virtual Boolean AdmitirVisitante(int edad, int altura)
        {

        }

    }
}
