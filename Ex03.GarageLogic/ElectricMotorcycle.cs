using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicle
    {
        public ElectricMotorcycle(string i_ModelName, string i_LicenseNumber, float i_RemainingBatteryTime, string i_ManufacturerName, float i_CurrentAirPressure) :
            base(1.8f, i_RemainingBatteryTime, 2, i_ManufacturerName, i_CurrentAirPressure, 30)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_RemainingBatteryTime = i_RemainingBatteryTime;
            m_Features = new MotorcycleFeatures();
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



