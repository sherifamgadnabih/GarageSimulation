using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage(2, 10);
            Vechile[] vechiles = new Vechile[22];
            for (int i = 0; i < vechiles.Length; i++)
            {
                vechiles[i] = new Vechile() { LicenseNo = "xteas" + i, Type = i % 2 == 0 ? VechileType.Car : VechileType.Bike, Model = "Model vechile" + i };
                garage.Park(vechiles[i]);
            }
        }
    }
}
