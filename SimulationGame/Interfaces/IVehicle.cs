using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationGame.Interfaces
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public string move();
    }
}
