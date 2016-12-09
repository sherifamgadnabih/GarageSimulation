using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSimulation
{
    public enum VechileType
    {
        Car,
        Bike
    }
    public class Vechile
    {
        #region Properties
        public string Model { get; set; }
        public string LicenseNo { get; set; }
        public VechileType Type { get; set; }
        #endregion
    }
}
