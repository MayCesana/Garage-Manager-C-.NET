using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricCar
    {
        private CarFeatures m_CarFeatures;

        public ElectricCar(int i_CarColor, int i_DoorsNumber)
        {
            m_CarFeatures = new CarFeatures(i_CarColor, i_DoorsNumber);
        }
    }
}
