using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Enums;

namespace VehicleLib.Abstract
{
    public interface IMotor
    {
        public Fuel MotorFuel { get; protected set; }
        public int HorsePower { get; protected set; }

    }
}
