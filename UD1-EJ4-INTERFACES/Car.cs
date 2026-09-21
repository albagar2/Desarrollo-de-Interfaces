using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Coche arrancando.");
        }

        public void Stop()
        {
            Console.WriteLine("Ccohe frenando.");
        }

        public void Acelerate()
        {
            Console.WriteLine("Coche acelerando.");
        }
    }
}
