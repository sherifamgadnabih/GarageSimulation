using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSimulation
{
    public class ParkingSlot
    {
        #region Members
        private Vechile _Vechile { get; set; }
        #endregion

        #region Properties
        public int SlotNumber { get; set; }

        #endregion

        #region Methods
        public void OccupySlot(Vechile vechile)
        {
            this._Vechile = vechile;
        }
        public void FreeSlot()
        {
            this._Vechile = null;
        }
        public bool IsSlotFree()
        {
            return this._Vechile == null;
        }

        public bool IsOccupiedWith(Vechile vechile)
        {
            return vechile == _Vechile;
        }
        #endregion
    }
}
