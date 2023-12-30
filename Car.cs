using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Car: IVehicle
    {
        public void sayHello()
        {
            Console.WriteLine("Hello from Car!");
        }
    }
}
