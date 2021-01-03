using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Abstract;

namespace VehicleLib.Vehicles
{
    public class Plane : AirVehicle
    {
        public Motor VehicleMotor { get; set;  }
        public Plane(Motor motor) : base()
        {
            VehicleMotor = motor;
        }
    }
}
