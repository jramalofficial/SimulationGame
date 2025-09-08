using Microsoft.Extensions.DependencyInjection;
using SimulationGame.Interfaces;
using SimulationGame.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame
{
    public class Player :IVehicle
    {
        public string Name { get; set; }

        public IVehicle vehicle;
        public Player()
        {
            vehicle = this;
        }
        public string move()
        {
            if (vehicle == this)
            {
                return "Player walking";
            }
            return vehicle.move();
        }
        public void GetIn(IVehicle movType)
        {
            vehicle = movType;
            Console.WriteLine($"Get into {vehicle.Name}");
        }

        public void GetOff()
        {
            if (vehicle != this)
            {
                Console.WriteLine($"Get off from {vehicle.Name}");
                vehicle = this;
            }
            else
            {
                Console.WriteLine("Player is already walking");
            }
        }

      
    }
}
