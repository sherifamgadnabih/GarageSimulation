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
            Random rnd = new Random();

            Vechile[] vechiles = new Vechile[40];
            for (int i = 0; i < vechiles.Length; i++)

            {
                vechiles[i] = new Vechile() { LicenseNo = "xteas" + i, Type = i % 2 == 0 ? VechileType.Car : VechileType.Bike, Model = "Model vechile" + i, Status = ParkingStatus.NotParked };
            }
            char c = ' ';
            while (c != 'C')
            {
                for (int i = 0; i < vechiles.Length; i++)
                {
                    if (vechiles[i].Status == ParkingStatus.NotParked)
                    {
                        garage.Park(vechiles[i]);
                    }
                    if (vechiles[i].IsReadyToExit())
                    {
                        garage.Exit(vechiles[i]);
                    }






                }
                Console.WriteLine("Press C to end the Simulation or press any other character to continue");
                c = Console.ReadLine()[0];
            }


        }
    }
}

