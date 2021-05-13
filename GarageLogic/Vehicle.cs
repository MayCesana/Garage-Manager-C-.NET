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

        public void SetRemainingEnergyPercentage(float i_CurrentValue, float i_MaxValue)
        {
            m_RemainingEnergyPercentage = (i_CurrentValue / i_MaxValue) * 100;
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

        public Wheel[] Wheels
        {
            get { return m_Wheels; }
        }


    }
}
