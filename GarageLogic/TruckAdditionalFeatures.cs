using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class TruckAdditionalFeatures : VehicleAdditionalFeatures
    {
        public TruckAdditionalFeatures()
        {
            m_VehicleParameters = new Dictionary<string, object>();
            m_VehicleParameters.Add("Is Carry Hazardous Materials (true/false)", typeof(bool));
            m_VehicleParameters.Add("Maximum Carry Whight", typeof(float));
        }

        public override void SetAdditionalFeatures(List<object> i_Parameters)
        {
            m_VehicleParameters["Is Carry Hazardous Materials (true/false)"] = i_Parameters[0];
            m_VehicleParameters["Maximum Carry Whight"] = i_Parameters[1];
        }

        public bool IsCarryHazardousMaterials
        {
            get { return (bool)m_VehicleParameters["Is Carry Hazardous Materials (true/false)"]; }
        }

        public float MaximumCarryWhight
        {
            get { return (float)m_VehicleParameters["Maximum Carry Whight"]; }
        }
    }
}
