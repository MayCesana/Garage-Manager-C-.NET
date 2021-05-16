using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricCar : ElectricVehicle
    {
        public ElectricCar(string i_ModelName, string i_LicenseNumber, float i_RemainingBatteryTime, string i_ManufacturerName, float i_CurrentAirPressure) : 
            base(3.2f, i_RemainingBatteryTime, 4, i_ManufacturerName, i_CurrentAirPressure, 32)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_RemainingBatteryTime = i_RemainingBatteryTime;
            m_Features = new CarFeatures();
        }

        public override void ChargeBattery(float i_HoursToLoad)
        {
            if (i_HoursToLoad + m_RemainingBatteryTime <= r_MaxBatteryTime)
            {
                m_RemainingBatteryTime += i_HoursToLoad;
            }
            //else
            //{
            //    exeption
            //}
        }
    }
}
