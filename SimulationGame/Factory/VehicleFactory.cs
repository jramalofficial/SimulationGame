using SimulationGame.Interfaces;
using SimulationGame.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Factory
{
    public class VehicleFactory: IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "c":
                    return new Car();
                case "b":
                    return new Bus();
                default:
                    return null;
            }
        }
    }  
}
