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

        public CarFeatures(eCarColor i_Color, eNumberOfDoors i_DoorsNumber)
        {
            m_CarColor = i_Color;
            m_NumberOfDoors = i_DoorsNumber;
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
