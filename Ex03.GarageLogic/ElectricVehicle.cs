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
        protected readonly float r_MaxBatteryTime; //by hours

        protected ElectricVehicle(float i_MaxBatteryTime, float i_RemainingBatteryTime, int i_NumberOfWheels, string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure) : 
            base(i_RemainingBatteryTime, i_MaxBatteryTime, i_NumberOfWheels, i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure)
        {        
            r_MaxBatteryTime = i_MaxBatteryTime;
        }

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
