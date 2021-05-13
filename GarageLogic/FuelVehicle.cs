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

        protected readonly eFuelType m_FuelType;
        protected float m_CurrentFuelAmount;
        protected readonly float m_MaxFuelAmount;

        protected FuelVehicle(float i_MaxFuelAmount, int i_FuelType)
        {
            m_MaxFuelAmount = i_MaxFuelAmount;
            m_FuelType = (eFuelType)i_FuelType;
        }

        public abstract void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType);

    }
}
