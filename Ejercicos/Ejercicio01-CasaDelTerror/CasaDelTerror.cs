using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_CasaDelTerror
{
    internal class CasaDelTerror : Atraccion
    {

        public int NivelDeMiedo { get; set; }

        public CasaDelTerror(string nombreA, int edad, int altura, double precioA, int nivelMiedo) : base(nombreA, edad, altura, precioA)
        {
            NivelDeMiedo = nivelMiedo;
        }


        public override Boolean AdmitirVisitante(int edad, int altura)
        {
            base.AdmitirVisitante(edad, altura);
            Console.WriteLine("Disfruta de la casa del terror");

        }
    }
}
