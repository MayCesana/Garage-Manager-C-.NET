using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class TruckFeatures : VehicleFeatures
    {
        public TruckFeatures()
        {
            m_VehicleParameters = new Dictionary<string, object>();
            m_VehicleParameters.Add("Is Carry Hazardous Materials", typeof(bool));
            m_VehicleParameters.Add("Maximum Carry Whight", typeof(float));
        }

        public override void SetParameters(List<object> i_Parameters)
        {
            //
        }
    }
}
