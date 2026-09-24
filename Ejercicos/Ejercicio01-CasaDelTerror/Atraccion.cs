using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CasaDelTerror
{
    internal class Atraccion
    {
        public string Nombre { get; set; }
        public int EdadMinima { get; set; }
        public int AlturaMinima { get; set; }
        public double Precio { get; set; }

        public Atraccion (string nombreA, int edad, int altura, double precioA)
        {
            Nombre = nombreA;
            EdadMinima = edad;
            AlturaMinima = altura;
            Precio = precioA;
        }

        public virtual bool AdmitirVisitante(int edad, int altura)
        {
            if (edad >= 14 && altura >= 130)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
