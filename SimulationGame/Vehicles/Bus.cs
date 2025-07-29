using SimulationGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Movement
{
    public class Bus : IVehicle
    {
        public string Name { get; set; } = "Bus";
        public string move()
        {
            return "Bus is moving";
        }
    }
}
