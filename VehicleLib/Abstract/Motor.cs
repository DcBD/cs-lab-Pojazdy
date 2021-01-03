using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Enums;

namespace VehicleLib.Abstract
{
    public class Motor
    {
        public Fuel MotorFuel { get; protected set; }
        public int HorsePower { get; protected set; }

        public Motor(Fuel fuel, int horsePower)
        {
            MotorFuel = fuel;
            HorsePower = horsePower;
        }
    }
}
