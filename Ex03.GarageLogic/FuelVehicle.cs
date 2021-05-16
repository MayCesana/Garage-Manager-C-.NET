using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class FuelVehicle : Vehicle
    {
        public enum eFuelType { Soler=0, Octan98=98, Octan95=95, Octan96=96 };

        protected readonly eFuelType r_FuelType;
        protected float m_CurrentFuelAmount;
        protected readonly float r_MaxFuelAmount;

        protected FuelVehicle(float i_MaxFuelAmount, eFuelType i_FuelType, float i_CurrentFuelAmount, int i_NumberOfWheels, string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure) : 
            base(i_CurrentFuelAmount, i_MaxFuelAmount, i_NumberOfWheels, i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure)
        {
            r_MaxFuelAmount = i_MaxFuelAmount;
            r_FuelType = i_FuelType;
        }

        public abstract void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType);

    }
}
