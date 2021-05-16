using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class MotorcycleFeatures : VehicleFeatures
    {
        public enum eLicenseTypes { A = 1, B1, AA, BB };

        public MotorcycleFeatures()
        {
            m_VehicleParameters = new Dictionary<string, object>();
            m_VehicleParameters.Add("License Types", typeof(string));
            m_VehicleParameters.Add("Engine Volume", typeof(int));
        }

        public override void SetParameters(List<object> i_parameters)
        {
            //m_LicenseType = i_LicenseType;
            //m_EngineVolume = i_EngineVolume;
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
