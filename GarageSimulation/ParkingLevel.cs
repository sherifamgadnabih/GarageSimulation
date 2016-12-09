using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSimulation
{
    class ParkingLevel
    {
        #region Members
        private ParkingSlot[] slots;
        private int _slotsNumber;

        #endregion

        #region Constructors
        public ParkingLevel(int slotsNumber)
        {
            _slotsNumber = slotsNumber;
            slots = new ParkingSlot[_slotsNumber];
            InitializeParkingSlots();
        }

        private void InitializeParkingSlots()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                slots[i] = new ParkingSlot() { SlotNumber = i };
            }
        }
        #endregion

        #region Properties
        public int LevelNumber { get; set; }

        #endregion

        #region Methods
        public bool HasFreeSlot()
        {
            return slots.Any(s => s.IsSlotFree());
        }
        public ParkingSlot GetNearestFreeSlot()
        {
            return slots.First(s => s.IsSlotFree());
        }

        public bool HasVechile(Vechile vechile)
        {
            return slots.Any(s => s.IsOccupiedWith(vechile));
        }

        public void Exit(Vechile vechile)
        {
            ParkingSlot slot = slots.Single(s => s.IsOccupiedWith(vechile));
            slot.FreeSlot();
        }
        #endregion

    }
}
