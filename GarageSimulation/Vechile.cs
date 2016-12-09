using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GarageSimulation
{
    public enum VechileType
    {
        Car,
        Bike
    }
    public enum ParkingStatus
    {
        NotParked,
        Parked
    }
    public class Vechile
    {
        #region Properties
        public string Model { get; set; }
        public string LicenseNo { get; set; }
        public VechileType Type { get; set; }
        private int _countDownForExit = 30;
        public ParkingStatus Status { get; set; }
        #endregion

        #region Methods
        public void CountDownForExit()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (object sender , DoWorkEventArgs e) =>
            {
                while (_countDownForExit != 0)
                {
                    Thread.Sleep(1000);
                    _countDownForExit--;
                }
            };
            worker.RunWorkerAsync();
        }

        
        public bool IsReadyToExit()
        {
            return _countDownForExit == 0;
        }
        #endregion
    }
}
