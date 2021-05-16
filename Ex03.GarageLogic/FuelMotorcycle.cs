using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelMotorcycle : FuelVehicle
    {
        public FuelMotorcycle(string i_ModelName, string i_LicenseNumber, float i_CurrentFuelAmount, string i_ManufacturerName, float i_CurrentAirPressure) :
            base(6f, FuelVehicle.eFuelType.Octan98, i_CurrentFuelAmount, 2, i_ManufacturerName, i_CurrentAirPressure, 30)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            m_Features = new MotorcycleFeatures();
        }

        public override void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            //compare i_FuelType=this.fuelType
        }
    }
}