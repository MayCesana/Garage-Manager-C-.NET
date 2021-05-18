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

        protected FuelVehicle(float i_MaxFuelAmount, eFuelType i_FuelType)
        {
            r_MaxFuelAmount = i_MaxFuelAmount;
            r_FuelType = i_FuelType;
        }

        public abstract eFuelType FuelType { get; }

        public override float CurrentEnergy
        {
            get { return m_CurrentFuelAmount; }
        }

        public override void setCurrentEnergy(float i_CurrentEnergy)
        {
            if (i_CurrentEnergy > r_MaxFuelAmount)
            {
                throw new ValueOutOfRangeException(0, r_MaxFuelAmount, "Fuel amount is bigger than the maximum");
            }
            else
            {
                m_CurrentFuelAmount = i_CurrentEnergy;
                SetRemainingEnergyPercentage(m_CurrentFuelAmount, r_MaxFuelAmount);
            }
        }

        public void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            if(i_FuelType != r_FuelType)
            {
                throw new ArgumentException("Fuel type doesn't match to vehicle fuel type!");
            }
            else if(i_AmountOfFuelToAdd + m_CurrentFuelAmount > r_MaxFuelAmount)
            {
                throw new ValueOutOfRangeException(0, r_MaxFuelAmount - m_CurrentFuelAmount,"You are trying to reful over the maximum");
            }
            else
            {
                m_CurrentFuelAmount += i_AmountOfFuelToAdd;
                SetRemainingEnergyPercentage(m_CurrentFuelAmount, r_MaxFuelAmount);
            }
        }

    }
}
