using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Enums;

namespace VehicleLib.Abstract
{
    public interface IVehicle
    {
        public double MinSpeed { get; set; }
        public double MaxSpeed { get; set; }

        public SpeedUnit SpeedUnit { get; set; }

        public double CurrentSpeed { get; set; }

        public bool IsStarted { get; }

        public VehicleState State { get; set; }

        public MovementEnviroment Enviroment { get; set; }

        public void Start();

        public void Stop();

        public void Accelerate(double accelerateValue);

        public void Decelerate(double decelerateValue);


    }
}
