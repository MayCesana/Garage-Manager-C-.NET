using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class ElectricVehicle : Vehicle
    {
        protected float m_RemainingBatteryTime; //by hours
        protected float m_MaxBatteryTime; //by hours

        public float RemainingBatteryTime
        {
            get { return m_RemainingBatteryTime; }
        }

        public float MaxBatteryTime
        {
            get { return m_MaxBatteryTime; }
        }

        public abstract void ChargeBattery(float i_HoursToLoad);
        
    }
}
