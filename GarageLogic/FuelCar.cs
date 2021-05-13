using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelCar : FuelVehicle
    {
        private CarFeatures m_CarFeatures;

        public FuelCar(CarFeatures.eCarColor i_CarColor, CarFeatures.eNumberOfDoors i_DoorsNumber, int i_FuelType, float i_CurrentFuelAmount, float i_MaxFuelAmount) : base(i_MaxFuelAmount, i_FuelType)
        {
            m_CarFeatures = new CarFeatures(i_CarColor, i_DoorsNumber);
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            SetRemainingEnergyPercentage(i_CurrentFuelAmount, i_MaxFuelAmount);
        }

        public override void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            //compare i_FuelType=this.fuelType
        }
    }
}
