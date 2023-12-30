using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Motorcycle: IVehicle
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from Motorcycle!");
        }
    }
}
