using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class CarFeatures
    {
        public enum eCarColor { Red = 1, White, Black, Silver };
        public enum eNumberOfDoors { TwoDoors = 2, ThreeDoor, FourDoors, FiveDoors };

        private eCarColor m_CarColor;
        private eNumberOfDoors m_NumberOfDoors;

        public CarFeatures(int i_Color, int i_DoorsNumber)
        {
            m_CarColor = (eCarColor)i_Color;
            m_NumberOfDoors = (eNumberOfDoors)i_DoorsNumber;
        }

        public eCarColor CarColor
        {
            get { return m_CarColor; }
        }
        public eNumberOfDoors NumberOfDoors
        {
            get { return NumberOfDoors; }
        }
    }
}
}
