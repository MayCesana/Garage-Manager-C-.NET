using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicle
    {
        private MotorcycleFeatures m_MotorcycleFeatures;

        public ElectricMotorcycle(eLicenseTypes i_LicenseType, int i_EngineVolume)
        {
            m_MotorcycleFeatures = new MotorcycleFeatures(i_LicenseType, i_EngineVolume);
        }

        public override void ChargeBattery(float i_HoursToLoad)
        {
            if (i_HoursToLoad + m_RemainingBatteryTime <= m_MaxBatteryTime)
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



