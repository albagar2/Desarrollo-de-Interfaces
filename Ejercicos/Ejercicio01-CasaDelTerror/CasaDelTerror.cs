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
            if (!base.AdmitirVisitante(edad, altura))
            {
                return false;
            }

            Console.WriteLine("Disfruta de la casa del terror");
            Console.WriteLine($"Nivel de miedo: {NivelDeMiedo}");
            Console.WriteLine("El visitante puede disfrutar de la atración Casa del terror");

            return true;

        }
    }
}
