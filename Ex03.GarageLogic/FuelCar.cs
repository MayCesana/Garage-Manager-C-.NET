using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelCar : FuelVehicle
    { 
        public FuelCar(string i_ModelName, string i_LicenseNumber, float i_CurrentFuelAmount, string i_ManufacturerName, float i_CurrentAirPressure) :
            base(45f, FuelVehicle.eFuelType.Octan95, i_CurrentFuelAmount, 4, i_ManufacturerName, i_CurrentAirPressure, 32)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            m_Features = new CarFeatures();
        }

        public override void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            //compare i_FuelType=this.fuelType
        }
    }
}
