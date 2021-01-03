using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Abstract;

namespace VehicleLib.Vehicles
{
    public class Ship : WaterVehicle
    {
        public Motor VehicleMotor  { get; set; }
        public Ship(int displacement, OilMotor motor) : base(displacement)
        {
            VehicleMotor = motor;
        }

    }
}
