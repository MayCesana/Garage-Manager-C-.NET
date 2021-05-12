using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : FuelVehicle
    {
        private bool m_IsCarryHazardousMaterials;
        private readonly float m_MaxCarryWhight;
          
        public Truck(bool i_IsCarryHazardousMaterials, int i_FuelType, float i_MaxFuelAmount, float i_CurrentFuelAmount, float i_MaxCarryWhight, string i_ModelName, string i_LicenseNumber, Wheel[] i_Wheels) 
            : base(i_MaxFuelAmount, i_FuelType)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_Wheels = i_Wheels;
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            m_IsCarryHazardousMaterials = i_IsCarryHazardousMaterials;
            m_MaxCarryWhight = i_MaxCarryWhight;
            SetRemainingEnergyPercentage(i_CurrentFuelAmount, i_MaxFuelAmount);
        }
 

        public bool IsCarryHazardousMaterials
        {
            get { return m_IsCarryHazardousMaterials; }
        }
         
        public eFuelType FuelType
        {
            get { return m_FuelType; }
        }

        public override void Refuel(float i_AmountOfFuelToAdd, int i_FuelType)
        {

        }
    }
}
