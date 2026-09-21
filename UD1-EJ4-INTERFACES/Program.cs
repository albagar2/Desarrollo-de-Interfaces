using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ4_INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // solo con objetos comunes que son los del interfaces
            IVehicle car1 = new Car();

            // con objetos de la clase concreta
            Car car2 = new Car();


            IVehicle motorbike1 =new MotorBike(); 

            car1.Start();

            car2.Acelerate();

            motorbike1.Stop();
        }
    }
}
