using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public static class VehicleCreator
    {
        public enum eKindsOfVehiclesHendeled { ElectricCar = 1, FuelCar, ElectricMotorcycle, FuelMotorcycle, Truck };
        
        public static Vehicle CreateVehicle(eKindsOfVehiclesHendeled i_VehicleType, string i_WheelsManufacturerName, float i_WheelsCurrentAirPressure, string i_ModelName, string i_LicenseNumber, float i_CurrentEnergy)
        {
            Vehicle vehicle = null;

            switch (i_VehicleType)
            {
                case eKindsOfVehiclesHendeled.ElectricCar:
                    {
                        vehicle = new ElectricCar(i_ModelName, i_LicenseNumber, i_CurrentEnergy, i_WheelsManufacturerName, i_WheelsCurrentAirPressure);
                        break;
                    }
                case eKindsOfVehiclesHendeled.FuelCar:
                    {
                        vehicle = new FuelCar(i_ModelName, i_LicenseNumber, i_CurrentEnergy, i_WheelsManufacturerName, i_WheelsCurrentAirPressure);
                        break;
                    }
                case eKindsOfVehiclesHendeled.ElectricMotorcycle:
                    {
                        vehicle = new ElectricMotorcycle(i_ModelName, i_LicenseNumber, i_CurrentEnergy, i_WheelsManufacturerName, i_WheelsCurrentAirPressure);
                        break;
                    }
                case eKindsOfVehiclesHendeled.FuelMotorcycle:
                    {
                        vehicle = new FuelMotorcycle(i_ModelName, i_LicenseNumber, i_CurrentEnergy, i_WheelsManufacturerName, i_WheelsCurrentAirPressure);
                        break; 
                    }
                case eKindsOfVehiclesHendeled.Truck:
                    {
                        vehicle = new Truck(i_ModelName, i_LicenseNumber, i_CurrentEnergy, i_WheelsManufacturerName, i_WheelsCurrentAirPressure);
                        break;
                    }
            }

            return vehicle;
        }
    }
}
