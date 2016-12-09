using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageSimulation
{
    public class Garage
    {
        #region Members
        private ParkingLevel[] _Levels;
        private int _LevelNo;
        private int _SLotsNumberPerLevel;
        #endregion

        #region Constructors
        public Garage(int levelNO, int slotNumberPerLevel)
        {
            _LevelNo = levelNO;
            _SLotsNumberPerLevel = slotNumberPerLevel;
            _Levels = new ParkingLevel[_LevelNo];
            InitializeGarageLevels();
        }
        #endregion

        #region Methods
        private void InitializeGarageLevels()
        {
            for (int i = 0; i < _Levels.Length; i++)
            {
                _Levels[i] = new ParkingLevel(_SLotsNumberPerLevel);
                _Levels[i].LevelNumber = i + 1;
            }

        }
        public void Park(Vechile vechile)
        {
            bool carParked = false;
            foreach (var level in _Levels)
            {
                if (level.HasFreeSlot())
                {
                    ParkingSlot slot = level.GetNearestFreeSlot();
                    slot.OccupySlot(vechile);
                    Console.WriteLine(string.Format("{0} {1} parked at level {2} slot {3}", vechile.Model, vechile.Type.ToString(), level.LevelNumber, slot.SlotNumber));
                    Console.WriteLine();
                    carParked = true;
                    break;
                }
            }
            if (!carParked)
            {
                Console.WriteLine(string.Format("{0} {1} is rejected because there is no free space at the garage", vechile.Model, vechile.Type.ToString()));
                Console.WriteLine();
            }
        }
        #endregion


    }
}
