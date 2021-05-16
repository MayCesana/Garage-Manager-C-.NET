using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class CarFeatures : VehicleFeatures
    {
        public enum eCarColor { Red = 1, White, Black, Silver };
        public enum eNumberOfDoors { TwoDoors = 2, ThreeDoor, FourDoors, FiveDoors };
        public CarFeatures()
        {
            m_VehicleParameters = new Dictionary<string, object>();
            m_VehicleParameters.Add("Car color", typeof(string));
            m_VehicleParameters.Add("Number Of Doors", typeof(int));
        }
   
        public override void SetParameters(List<object> i_Parameters) 
        {
            //r_VehicleParameters.Add("Car color", typeof(string));
            //r_VehicleParameters.Add("Number Of Doors", typeof(int));

            //לתקן
            //m_CarColor = i_Color;
            //m_NumberOfDoors = i_DoorsNumber;
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
