using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class MotorcycleFeatures
    {
        public enum eLicenseTypes { A = 1, B1, AA, BB };

        private eLicenseTypes m_LicenseType;
        private int m_EngineVolume; //CC

        public MotorcycleFeatures(eLicenseTypes i_LicenseType, int i_EngineVolume)
        {
            switch(i_LicenseType)
            {
                case "A":
                {
                    m_LicenseType = eLicensTypes.A;
                    break;
                }
                case "AA":
                {
                    m_LicenseType = eLicensTypes.AA;
                    break;
                }
                case "B1":
                {
                    m_LicenseType = eLicensTypes.B1;
                    break;
                }
                case "BB":
                {
                    m_LicenseType = eLicensTypes.BB;
                    break;
                }
            }
            m_EngineVolume = i_EngineVolume;
        }

        public eLicenseTypes LicensType
        {
            get { return m_LicenseType; }
        }

        public int EngineVolume
        {
            get { return m_EngineVolume; }
        }
    }
}
