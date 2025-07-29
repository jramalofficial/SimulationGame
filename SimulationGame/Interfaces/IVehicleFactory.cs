using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Interfaces
{
    public interface IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType);
    }
}
