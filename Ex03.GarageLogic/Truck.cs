using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : FuelVehicle
    {
        public Truck(string i_ModelName, string i_LicenseNumber, float i_CurrentFuelAmount, string i_ManufacturerName, float i_CurrentAirPressure) :
            base(120f, eFuelType.Soler, i_CurrentFuelAmount, 16, i_ManufacturerName, i_CurrentAirPressure, 26)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_CurrentFuelAmount = i_CurrentFuelAmount;
            m_Features = new TruckFeatures();
        }
 
        public bool IsCarryHazardousMaterials
        {
            get { return m_IsCarryHazardousMaterials; }
        }
         
        public eFuelType FuelType
        {
            get { return m_FuelType; }
        }

        public override void Refuel(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {
            
        }
    }
}
