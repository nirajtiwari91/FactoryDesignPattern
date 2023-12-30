using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    // Vehicle factory with dictionary
    public class VehicleFactory
    {
        //Optimized Version of Factory Design Pattern
        Dictionary<string, IVehicle> _vehicleTypes = new Dictionary<string, IVehicle>();
        public VehicleFactory()
        {
            if (_vehicleTypes.Count == 0) //Lazy Loading example
            {
                _vehicleTypes.Add("car", new Car());
                _vehicleTypes.Add("motorcycle", new Motorcycle());
                // Add other vehicle types as needed
            }
        }

        public IVehicle CreateVehicleV1(string key)
        {
            if (_vehicleTypes.ContainsKey(key.ToLower()))
            {
                return _vehicleTypes[key.ToLower()];
            }
            return null;
        }

        //public IVehicle CreateVehicle(string type)
        //{
        //    switch (type.ToLower())
        //    {
        //        case "car":
        //            return new Car();
        //        case "motorcycle":
        //            return new Motorcycle();
        //        default:
        //            throw new ArgumentException("Invalid vehicle type");
        //    }
        //}


    }
}
