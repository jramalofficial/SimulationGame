using Microsoft.Extensions.DependencyInjection;
using SimulationGame.Interfaces;
using SimulationGame.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame
{
    public class PlayGround
    {
        private readonly IVehicleFactory _vehicleFactory;
        public PlayGround(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }
        public void StartGame()
        {
            var player = new Player();
            Console.WriteLine("\nChoose your vehicle: c = Car, b = Bus, o= get out of vehicle");

            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                var key = keyInfo.Key;
                var keyChar = keyInfo.KeyChar.ToString().ToLower();

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine(player.move());
                        break;

                    default:
                        if (keyChar == "o")
                        {
                            player.GetOff();
                        }
                        else
                        {
                            var vehicle = _vehicleFactory.CreateVehicle(keyChar);
                            if (vehicle!=null)
                            {
                                _vehicleFactory.CreateVehicle(keyChar);
                                player.GetIn(vehicle);
                            }
                            else
                            {
                                Console.WriteLine("Invalid key.");
                            }
                        }
                        break;
                }
            }
        }
    }
}
