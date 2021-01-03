using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Abstract;

namespace VehicleLib.Vehicles
{
    public class Car : GroundVehicle
    {
        public Motor VehicleMotor { get; }
        public Car(Motor motor, int wheelsCount = 4) : base(wheelsCount: wheelsCount)
        {
            VehicleMotor = motor;
        }
    }
}
