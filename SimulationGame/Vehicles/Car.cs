using SimulationGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Movement
{
    public class Car: IVehicle
    {
        public string Name { get; set; } = "Car";
        public string move()
        {
            return "Car Driving";
        }
    }
}
