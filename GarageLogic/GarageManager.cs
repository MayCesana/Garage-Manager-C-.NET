using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GarageManager
    {
        public class VehicleInTheGarage
        {
            public enum eVehicleStatus { inRepair = 0, Paidup, Fixed };
            private string m_OwnerName;
            private string m_OwnerPhoneNumber;
            private eVehicleStatus m_VehicleStatus;
            private Vehicle m_Vehicle;

            public VehicleInTheGarage(string i_OwnerName, string i_OwnerPhoneNumber, Vehicle i_Vehicle)
            {
                m_OwnerName = i_OwnerName;
                m_OwnerPhoneNumber = i_OwnerPhoneNumber;
                m_Vehicle = i_Vehicle;
                m_VehicleStatus = eVehicleStatus.inRepair;
            }

            public string OwnerName
            {
                get
                {
                    return m_OwnerName;
                }
            }

            public string OwnerPhoneNumber
            {
                get
                {
                    return m_OwnerPhoneNumber;
                }
            }

            public Vehicle Vehicle
            {
                get
                {
                    return m_Vehicle;
                }
            }

            public eVehicleStatus VehicleStatus
            {
                get
                {
                    return m_VehicleStatus;
                }
                set
                {
                    m_VehicleStatus = value;
                }

            }
        }

        private Dictionary<string, VehicleInTheGarage>[] m_AllVehiclesInTheGrage;

        public GarageManager()
        {
            m_AllVehiclesInTheGrage = new Dictionary<string, VehicleInTheGarage>[3];
            for (int i = 0; i < 3; i++)
            {
                m_AllVehiclesInTheGrage[i] = new Dictionary<string, VehicleInTheGarage>();
            }
        }

        public void AddNewVehicle(string i_OwnerName, string i_OwnerPhone, Vehicle i_VehicleToAdd)
        {
            //if()//is in the garage)
            //{
            //    //change statuse and change dictionary
            //}
            //else
            //{
               VehicleInTheGarage newVehicle = new VehicleInTheGarage(i_OwnerName, i_OwnerPhone, i_VehicleToAdd);
               m_AllVehiclesInTheGrage[0].Add(newVehicle.Vehicle.LicenseNumber, newVehicle);
            //}
        }

        public string[] GetVehicleLicenseNumberList()
        {
            int index =0, resultListSize = m_AllVehiclesInTheGrage[0].Count + m_AllVehiclesInTheGrage[1].Count + m_AllVehiclesInTheGrage[2].Count;
            string[] licenseNumberList = new string[resultListSize];
            for (int i=0; i<3; i++)
            {
                foreach(string licenseNumber in m_AllVehiclesInTheGrage[i].Keys)
                {
                    licenseNumberList[index] = licenseNumber;
                    index++;
                }
            }

            return licenseNumberList;
        }

        public string[] GetVehicleLicenseNumberList(int i_Status)
        {
            int index = 0;
            string[] licenseNumberList = new string[m_AllVehiclesInTheGrage[i_Status].Count];
            foreach(string licenseNumber in m_AllVehiclesInTheGrage[i_Status].Keys)
            {
                licenseNumberList[index] = licenseNumber;
                index++;
            }

            return licenseNumberList;
        }

        public void ChangeVehicleStatus(string i_LicenseNumber, int i_NewStatus)
        {
            bool isExist = false;

            for (int i = 0; i < 3; i++)
            {
                if (m_AllVehiclesInTheGrage[i].ContainsKey(i_LicenseNumber) == true)
                {
                    isExist = true;
                    m_AllVehiclesInTheGrage[i][i_LicenseNumber].VehicleStatus = (VehicleInTheGarage.eVehicleStatus)i_NewStatus;
                    break;
                }
            }

            if(!isExist)
            {
                //exception
            }
        }

        private VehicleInTheGarage FindVehicleInArray(string i_LicenseNumber)
        {
            bool isExist = false;
            VehicleInTheGarage foundVehicle = null;

            foreach (Dictionary<string, VehicleInTheGarage> listByStastus in m_AllVehiclesInTheGrage)
            {
                if (listByStastus.ContainsKey(i_LicenseNumber) == true)
                {
                    isExist = true;
                    foundVehicle =  listByStastus[i_LicenseNumber];
                    break;
                }
            }

            if (!isExist)
            {
                //exception
            }

            return foundVehicle;
        }

        public void BlowWeelsToMax(string i_LicenseNumber)
        {
            VehicleInTheGarage foundVehicle = FindVehicleInArray(i_LicenseNumber);
            foreach (Wheel wheel in foundVehicle.Vehicle.Wheels)
            {
                float amountOfAirToBlow = wheel.MaxAirPressure - wheel.CurrentAirPressure;
                wheel.BlowWheel(amountOfAirToBlow);
            }
               
        }

        public void Reful(string i_LicenseNumber, FuelCar.eFuelType i_FuelType, float i_AmountOfFuel)
        {
            VehicleInTheGarage foundVehicle = FindVehicleInArray(i_LicenseNumber);
            (foundVehicle.Vehicle as FuelVehicle).Refuel(i_AmountOfFuel, i_FuelType);
        }

        public void Charge(string i_LicenseNumber, float i_AmountOfMinitsToCharge)
        {
            VehicleInTheGarage foundVehicle = FindVehicleInArray(i_LicenseNumber);
            (foundVehicle.Vehicle as ElectricVehicle).ChargeBattery(i_AmountOfMinitsToCharge);
            //check if as worked
        }

        public VehicleInTheGarage GetVehicleInTheGarage(string i_LicenseNumber)
        {
            return FindVehicleInArray(i_LicenseNumber);
        }
    }
}
