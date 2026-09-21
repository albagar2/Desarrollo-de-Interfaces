using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ2_CLASE
{

    // clase principal
    internal class Program
    {
        static void Main(string[] args)
        {

            Worker worker1 = new Worker("Pedro");

            worker1.SetName("Juan");

            worker1.Name = "Juan";
            worker1.Salary = 1500;

            Console.WriteLine($"Nombre del trabajador: {worker1.Name} y su salario es {worker1.Salary}");
        }
    }
}
