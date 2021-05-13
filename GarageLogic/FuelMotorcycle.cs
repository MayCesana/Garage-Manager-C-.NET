using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelMotorcycle : FuelVehicle
    {
        private MotorcycleFeatures m_MotorcycleFeatures;
       
        public FuelMotorcycle(MotorcycleFeatures.eLicenseTypes i_LicenseType, int i_EngineVolume, int i_FuelType, float i_CurrentFuelAmount, float i_MaxFuelAmount) : base(i_MaxFuelAmount, i_FuelType)
        {
            m_MotorcycleFeatures = new MotorcycleFeatures(i_LicenseType, i_EngineVolume);
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            SetRemainingEnergyPercentage(i_CurrentFuelAmount, i_MaxFuelAmount);
        }

        public override void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            //compare i_FuelType=this.fuelType
        }
    }
}