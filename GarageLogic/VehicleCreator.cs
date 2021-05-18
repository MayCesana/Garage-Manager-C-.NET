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
        
        public static Vehicle CreateVehicle(eKindsOfVehiclesHendeled i_VehicleType)
        {
            Vehicle vehicle = null;

            switch (i_VehicleType)
            {
                case eKindsOfVehiclesHendeled.ElectricCar:
                    {
                        vehicle = new ElectricCar();
                        break;
                    }
                case eKindsOfVehiclesHendeled.FuelCar:
                    {
                        vehicle = new FuelCar();
                        break;
                    }
                case eKindsOfVehiclesHendeled.ElectricMotorcycle:
                    {
                        vehicle = new ElectricMotorcycle();
                        break;
                    }
                case eKindsOfVehiclesHendeled.FuelMotorcycle:
                    {
                        vehicle = new FuelMotorcycle();
                        break; 
                    }
                case eKindsOfVehiclesHendeled.Truck:
                    {
                        vehicle = new Truck();
                        break;
                    }
            }

            return vehicle;
        }
    }
}
