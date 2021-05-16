using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenseNumber;
        protected float m_RemainingEnergyPercentage;
        protected Wheel[] m_Wheels;
        protected VehicleFeatures m_Features;

        protected Vehicle(float i_CurrentEnergyValue, float i_MaxEnergyValue, int i_NumberOfWeels, string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            Wheel[] wheels = new Wheel[i_NumberOfWeels];
            for (int i = 0; i < wheels.Length; ++i)
            {
                wheels[i] = new Wheel(i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure);
            }
            m_RemainingEnergyPercentage = (i_CurrentEnergyValue / i_MaxEnergyValue) * 100;
        }

        public float RemainingEnergyPercentage
        {
            get
            {
                return m_RemainingEnergyPercentage;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
        }

        public VehicleFeatures Features
        {
            get { return m_Features; }
        }

        public Wheel[] Wheels
        {
            get { return m_Wheels; }
        }


    }
}
