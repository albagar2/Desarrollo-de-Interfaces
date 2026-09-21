using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ2_CLASE
{
    internal class Worker
    {
        // EN JAVA SE USA ASI
        private string name;
        
        public string GetName()
        {
            return name;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        //constructor
       /* public WorkerPrueba(string name)
        {
            this.name = name;
        }

        */
        // EN C# SE USA ASI
        public string Name { get; set; }

        private double _salary;
        public double Salary
        {
            //get { return Salary; } 
            get => _salary;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Valor negativo. Ponemos el salario a cero ");
                    _salary = 0;

                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Worker(string name)
        {
            Name = name;
        }
    }
}
