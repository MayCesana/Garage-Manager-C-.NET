using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public static class ConsoleUI
    {
        public static void MainMenu()
        {
            ShowMenu();
            int userCohise = InputHandler.GetOptionFromMainMenu();
            switch (userCohise)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine(@"What do you want to do? (enter the number of the operation): 
1.Add vehicle to the garage
2.Show the vehicles in the garage (license numbers)
3.Change vehicle status
4.Blow vehicle wheels
5.Reful
6.Charge electric vehicle batery ()
7.Show vehicle details");
        }

        private static int getVehicleType()
        {
            Console.WriteLine("Please Choose vehicle type from the types below: ");
            Console.WriteLine();
            foreach (string name in Enum.GetNames(typeof(VehicleCreator.eKindsOfVehiclesHendeled)))
            {
                Console.WriteLine(name);
            }
            
            return int.Parse(Console.ReadLine());
        }

        private static Vehicle getVehicleInputs()
        {
            VehicleCreator.eKindsOfVehiclesHendeled vehicleType = (VehicleCreator.eKindsOfVehiclesHendeled)getVehicleType();

            string modelName = InputHandler.GetStringForName();
            string licenseNumber = InputHandler.GetLicenseNumber();
            float currentEnergy = InputHandler.GetFloat();
            string wheelsManufacturerName = InputHandler.GetStringForName();
            float wheelsCurrentAirPressure = InputHandler.GetFloat();

            Vehicle newVehicle = VehicleCreator.CreateVehicle(vehicleType, wheelsManufacturerName, wheelsCurrentAirPressure, modelName, licenseNumber, currentEnergy);
            return newVehicle;
        }

        private static void addVehicleTotheGarage()
        {
            Vehicle vehicleToAdd = getVehicleInputs();
            foreach(KeyValuePair<string,object> param in vehicleToAdd.Features.m_VehicleParameters)
            {
                Console.WriteLine(param.Key);
                Console.WriteLine(", ");
            }

            List<object> parametersList = new List<object>();
            foreach (KeyValuePair<string, object> param in vehicleToAdd.Features.m_VehicleParameters)
            {
                object input = Console.ReadLine();
                Convert.ChangeType(input, param.Value as Type);
                parametersList.Add(input);
            }
            vehicleToAdd.Features.SetParameters(parametersList);

            //שם, טלפון
            

        }

        private static void blow(string i_LicenseNumber)
        {
            GarageManager.BlowWeelsToMax(i_LicenseNumber);
        }

        private static void reful(string i_LicenseNumber)
        {
            Console.WriteLine(@"What is the vehicle fuel type?
Press 0 to soler
    95 to oktan95
    96 to oktan96
    98 t0 oktan98 
");
            FuelVehicle.eFuelType fuelType = InputHandler.GetFuelType();
            Console.WriteLine("Please enter the amount of fuel to reful: ");
            float amountOfFuel = InputHandler.GetFloat();
            GarageManager.Reful(i_LicenseNumber, fuelType, amountOfFuel);
        }

        private static void ChargeBatery(string i_LicenseNumber)
        {
            Console.WriteLine("Please enter the amount of minutes you want to charge: ");
            float amountOfMinitsToCharge = InputHandler.GetFloat();
            try
            {
                GarageManager.Charge(i_LicenseNumber, amountOfMinitsToCharge);
            }
            catch (//)
            {
                Console.WriteLine("charge failed"); //אם הצליח - להדפיס שהצליח
            }//אם לא - חריגה

            Console.WriteLine("Vehicle Charged");
        }

        private static void ShowVehicleDetails(string i_LicenseNumber)
        {
            GarageManager.VehicleInTheGarage vehicle = GarageManager.GetVehicleInTheGarage(i_LicenseNumber);
        }

        public static void ShowFilterByStatusMenue()
        {
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("Press 1 to show all inRepair vehicles");
            Console.WriteLine("Press 2 to show all paidup vehicles");
            Console.WriteLine("Press 3 to show all fixed vehicles");
            Console.WriteLine("Press 4 to show all the vehicles");
        }

        public static void ChangeStatus()
        {
            string licenseNumber = InputHandler.GetLicenseNumber();

            GarageManager.VehicleInTheGarage foundVehicle = GarageManager.GetVehicle(licenseNumber);

            Console.WriteLine("Please choose the new status:");
            Console.WriteLine("Press 1 to inRepair");
            Console.WriteLine("Press 2 to paidup");
            Console.WriteLine("Press 3 to fixed");

            int newStatus = int.Parse(Console.ReadLine()); //check paras and input
            foundVehicle.VehicleStatus = (GarageManager.VehicleInTheGarage.eVehicleStatus

        }
    }
}
