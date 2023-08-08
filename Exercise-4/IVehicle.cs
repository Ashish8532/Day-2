using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    // Define an interface for vehicles.
    public interface IVehicle
    {
        // Method signature for driving a vehicle.
        void Drive();
    }

    // Define a class representing a Car, which implements the IVehicle interface.
    public class Car : IVehicle
    {
        // Implement the Drive method for the Car class.
        public void Drive()
        {
            Console.WriteLine("Drive car safely.");
        }
    }

    // Define a class representing a Truck, which implements the IVehicle interface.
    public class Truck : IVehicle
    {
        // Implement the Drive method for the Truck class.
        public void Drive()
        {
            Console.WriteLine("Drive Truck within the speed limit.");
        }
    }
}
