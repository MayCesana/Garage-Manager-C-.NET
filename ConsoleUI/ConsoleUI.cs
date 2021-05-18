using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using System.Threading;

namespace Ex03.ConsoleUI
{
    public static class ConsoleUI
    {
        public enum eGarageMenu { AddVehicle = 1, ShowLicenseNumbers, ChangeVehicleStatus, InflateWheels, Reful, Charge, ShowVehicleDetails, Exit };
        public static void MainMenu()
        {
            eGarageMenu userCohise = 0;
            while (userCohise != eGarageMenu.Exit)
            {
                Thread.Sleep(1500);
                Console.Clear();
                ShowMenu();
                try
                {
                    int option = InputHandler.GetOptionFromMenu(Enum.GetNames(typeof(eGarageMenu)).Length);
                    userCohise = (eGarageMenu)option;
                    Console.Clear();
                    switch (userCohise)
                    {
                        case eGarageMenu.AddVehicle:
                            {
                                addVehicleTotheGarage();
                                break;
                            }
                        case eGarageMenu.ShowLicenseNumbers:
                            {
                                showLicenseNumbers();
                                break;
                            }
                        case eGarageMenu.ChangeVehicleStatus:
                            {
                                changeStatus();
                                break;
                            }
                        case eGarageMenu.InflateWheels:
                            {
                                inflate();
                                break;
                            }
                        case eGarageMenu.Reful:
                            {
                                reful();
                                break;
                            }
                        case eGarageMenu.Charge:
                            {
                                chargeBatery();
                                break;
                            }
                        case eGarageMenu.ShowVehicleDetails:
                            {
                                showVehicleDetails();
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(4000);

                }
            }
        }

        private static string getLicenseNumber()
        {
            Console.WriteLine("Please enter the license number: ");
            return InputHandler.GetLicenseNumber();
        }

        public static void ShowMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine();
            string menu = string.Format(@"What do you want to do? (enter the number of the operation): 
{0}.Add vehicle to the garage
{1}.Show the vehicles in the garage (license numbers)
{2}.Change vehicle status
{3}.Blow vehicle wheels
{4}.Reful (for fuel vehicles)
{5}.Charge electric vehicle batery
{6}.Show vehicle details
{7}.Exit", (int)eGarageMenu.AddVehicle, (int)eGarageMenu.ShowLicenseNumbers, (int)eGarageMenu.ChangeVehicleStatus, (int)eGarageMenu.InflateWheels,
           (int)eGarageMenu.Reful, (int)eGarageMenu.Charge, (int)eGarageMenu.ShowVehicleDetails, (int)eGarageMenu.Exit);
            Console.WriteLine(menu);
        }
     
        private static int getVehicleType()
        {
            int typeIndex = 1;

            Console.WriteLine("Please Choose vehicle type from the types below: ");
            Console.WriteLine();
            foreach (string name in Enum.GetNames(typeof(VehicleCreator.eKindsOfVehiclesHendeled)))
            {
                Console.WriteLine(typeIndex + ". " + name);
                typeIndex++;
            }

            return InputHandler.GetOptionFromMenu(Enum.GetNames(typeof(VehicleCreator.eKindsOfVehiclesHendeled)).Length);
        }

        private static void getVehicleDetails(out string o_ModelName, out float o_CurrentEnergy, out string o_WheelsManufacturerName, out float o_WheelsCurrentAirPressure)
        {
            Console.Clear();
            Console.WriteLine("Please fill the information below- ");
            Console.WriteLine("Vehicle model name: ");
            o_ModelName = InputHandler.GetStringForName();
            Console.WriteLine("Vehicle current energy(fuel in liters or battery in hours): ");
            o_CurrentEnergy = float.Parse(Console.ReadLine());
            Console.WriteLine("wheels manufacturer name: ");
            o_WheelsManufacturerName = InputHandler.GetStringForName();
            Console.WriteLine("wheels current air pressure: ");
            o_WheelsCurrentAirPressure = float.Parse(Console.ReadLine());
        }

        private static void addVehicleTotheGarage()
        {
            Vehicle newVehicle = null;
            string modelName, licenseNumber, wheelsManufacturerName, phoneNumber, ownerName;
            float currentEnergy, wheelsCurrentAirPressure;
            List<object> featuresList;

            licenseNumber = getLicenseNumber();

            if(GarageManager.IsInTheGarage(licenseNumber))
            {
                Console.WriteLine("This vehicle is already exist! status changed to: InRepair.");
                GarageManager.ChangeVehicleStatus(licenseNumber, GarageManager.VehicleInTheGarage.eVehicleStatus.inRepair);
            }
            else
            {
                VehicleCreator.eKindsOfVehiclesHendeled vehicleType = (VehicleCreator.eKindsOfVehiclesHendeled)getVehicleType();
                newVehicle = VehicleCreator.CreateVehicle(vehicleType);
                getVehicleDetails(out modelName, out currentEnergy , out wheelsManufacturerName, out wheelsCurrentAirPressure);
                getOwnerDetails(out ownerName, out phoneNumber);
                featuresList = getVehicleAdditionalFeatures(newVehicle);
                GarageManager.AddNewVehicle(ownerName, phoneNumber, newVehicle, licenseNumber, modelName, currentEnergy, wheelsManufacturerName, wheelsCurrentAirPressure, featuresList);
                Console.WriteLine("Vehicle added successfully!");
            }
        }

        private static List<object> getVehicleAdditionalFeatures(Vehicle i_Vehicle)
        {
            List<object> parametersList = new List<object>();
            object input;

            foreach (KeyValuePair<string, object> param in i_Vehicle.Features.m_VehicleParameters)
            {
                Console.WriteLine(param.Key + ": ");
                input = Console.ReadLine();
                Convert.ChangeType(input, param.Value as Type);
                parametersList.Add(input);
            }

            return parametersList;
        }

        private static void getOwnerDetails(out string o_OwnerName, out string o_PhoneNumber)
        {
            Console.WriteLine("Please enter the vehicle owner name: ");
            o_OwnerName = InputHandler.GetStringForName();
            Console.WriteLine("Please enter the owner phone number: ");
            o_PhoneNumber = InputHandler.GetPhoneNumber();
        }

        private static void inflate()
        {
            string licenseNumber = getLicenseNumber();
            GarageManager.InflateWeelsToMax(licenseNumber);

            Console.WriteLine("Vehicle wheels successfully inflated");
        }

        private static void reful()
        {
            string licenseNumber = getLicenseNumber();
            Console.WriteLine(@"What is the vehicle fuel type?
Press 0 to soler
    95 to oktan95
    96 to oktan96
    98 t0 oktan98 
");
            FuelVehicle.eFuelType fuelType = InputHandler.GetFuelType();
            Console.WriteLine("Please enter the amount of fuel to reful: ");
            float amountOfFuel = float.Parse(Console.ReadLine());
            float newFuelStatus = GarageManager.Reful(licenseNumber, fuelType, amountOfFuel);

            string msg = string.Format(@"The vehicle successfully refueled and the current fuel status is: {0}",
            newFuelStatus);
            Console.WriteLine(msg);
        }

        private static void chargeBatery()
        {
            string licenseNumber = getLicenseNumber();
            Console.WriteLine("Please enter the amount of minutes you want to charge: ");
            float amountOfMinitsToCharge = float.Parse(Console.ReadLine());
            float newBatteryStatus = GarageManager.Charge(licenseNumber, amountOfMinitsToCharge);

            string msg = string.Format(@"The vehicle successfully charged and the current battery status is: {0}%",
            newBatteryStatus);
            Console.WriteLine(msg);
        }

        private static void showVehicleDetails()
        {
            string licenseNumber = getLicenseNumber();
            GarageManager.VehicleInTheGarage vehicle = GarageManager.GetVehicle(licenseNumber);
            string vehicleGenericDetails = string.Format(@"owner name: {0}
License number: {1}
Vehicle model name: {2}
Vehicle Status: {3}
Wheels manufacturer name: {4}, Wheels current air pressure: {5}
", vehicle.OwnerName, vehicle.Vehicle.LicenseNumber, 
vehicle.Vehicle.ModelName, vehicle.VehicleStatus, vehicle.Vehicle.Wheels[0].ManufacturerName, vehicle.Vehicle.Wheels[0].CurrentAirPressure);

            string vehicleEnergyDetails;

            if (vehicle.Vehicle is FuelVehicle)
            {
                vehicleEnergyDetails = string.Format(@"Feul Type: {0}, Fuel status: {1}%", (vehicle.Vehicle as FuelVehicle).FuelType, (vehicle.Vehicle.RemainingEnergyPercentage));
            }
            else
            {
                vehicleEnergyDetails = string.Format(@"Battery status: {0}%", vehicle.Vehicle.RemainingEnergyPercentage);
            }

            Console.WriteLine(vehicleGenericDetails + vehicleEnergyDetails);

            foreach (KeyValuePair<string, object> param in vehicle.Vehicle.Features.m_VehicleParameters)
            {
                Console.WriteLine(param.Key + ": " + param.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Enter to return to the menu");
            Console.ReadLine();
        }

        private static void showFilterByStatusMenu()
        {
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("Press 1 to show all inRepair vehicles");
            Console.WriteLine("Press 2 to show all paidup vehicles");
            Console.WriteLine("Press 3 to show all fixed vehicles");
            Console.WriteLine("Press 4 to show all the vehicles");
        }

        private static void showLicenseNumbers()
        {
            showFilterByStatusMenu();

            int choise = InputHandler.GetOptionFromMenu(4);
            string[] licenseNumbersList;

            if(choise == 4)
            {
                licenseNumbersList = GarageManager.GetVehicleLicenseNumberList();
            }
            else
            {
                licenseNumbersList = GarageManager.GetVehicleLicenseNumberList(choise);
            }

            Console.Clear();
            foreach(string licenseNumber in licenseNumbersList)
            {
                Console.WriteLine(licenseNumber);
            }

            Console.WriteLine("Enter to return to the menu");
            Console.ReadLine();
        }
        
        private static void changeStatus()
        {
            string licenseNumber = getLicenseNumber();

            Console.WriteLine("Please choose the new status:");
            Console.WriteLine("Press 1 to inRepair");
            Console.WriteLine("Press 2 to paidup");
            Console.WriteLine("Press 3 to fixed");

            int newStatus = InputHandler.GetOptionFromMenu(3);
            GarageManager.ChangeVehicleStatus(licenseNumber, (GarageManager.VehicleInTheGarage.eVehicleStatus)newStatus);

            Console.WriteLine("status changed");
        }
    }
}
