using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal interface IVehicle
    //Contrato donde las clases con este contrato se tiene que acoger a los metodos y propiedades que se definan en el contrato
    {
        // en las inerfaces no se pone el identificador de acceso, ya que por defecto es public, y no se pueden poner modificadores de acceso
        //en java se pone como implements aqui lo ponemos como : IVehicle
        void Start();

        void Stop();
    }
}
