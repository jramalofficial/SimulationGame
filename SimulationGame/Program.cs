using Microsoft.Extensions.DependencyInjection;
using SimulationGame.Factory;
using SimulationGame.Interfaces;
using SimulationGame.Movement;
using System.Security.Authentication.ExtendedProtection;

namespace SimulationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var service = new ServiceCollection();
            service.AddTransient<PlayGround>();
            service.AddTransient<IVehicleFactory, VehicleFactory>();
          
            var serviceProvider = service.BuildServiceProvider();
            var playground=serviceProvider.GetService<PlayGround>();
            playground.StartGame();

        }
    }
}
