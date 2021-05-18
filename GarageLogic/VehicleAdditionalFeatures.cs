using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class VehicleAdditionalFeatures
    {
        public Dictionary<string, object> m_VehicleParameters;

        public abstract void SetAdditionalFeatures(List<object> i_Parameters);
    }
}
