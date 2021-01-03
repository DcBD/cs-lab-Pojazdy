using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLib.Abstract
{
    public class OilMotor : Motor
    {
        public OilMotor(int horsePower) : base(Enums.Fuel.oil, horsePower) { }
    }
}
