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

        protected virtual void LoadBattery(float i_HoursToLoad)
        {
            if (i_HoursToLoad + m_RemainingBatteryTime <= m_MaxBatteryTime)
            {
                m_RemainingBatteryTime += i_HoursToLoad;
            }
        }
    }
}
