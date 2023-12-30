using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Factory Design Pattern:
            Car carobj = new Car();
            Motorcycle motorcycleobj = new Motorcycle();
            carobj.sayHello();
            motorcycleobj.sayHello();
            Console.ReadLine();


            //With Factory Design Pattern:
            //VehicleFactory factory = new VehicleFactory();
            //IVehicle car = factory.CreateVehicle("car");
            //IVehicle motorcycle = factory.CreateVehicle("motorcycle");
            //car.sayHello();
            //motorcycle.sayHello();
            //Console.ReadLine();

            //With Factory Design Pattern Optimized Version:
            //VehicleFactory factory = new VehicleFactory();
            //IVehicle car = factory.CreateVehicleV1("car");
            //IVehicle motorcycle = factory.CreateVehicle("motorcycle");
            //car.sayHello();
            //motorcycle.sayHello();
            //Console.ReadLine();
        }
    }
}
