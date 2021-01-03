using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Abstract;
using VehicleLib.Classes;

namespace VehicleLib.Vehicles
{
    public class Amphibian : VehicleBase
    {
        public int Displacement { get; }
        public int WheelsCount { get; }

        public Motor VehicleMotor;

        public Amphibian(int displacement, int wheelsCount, OilMotor motor) : base()
        {
            Displacement = displacement;
            WheelsCount = wheelsCount;
            Enviroment = Enums.MovementEnviroment.ground;
            VehicleMotor = motor;
        }


        public void GetIntoWater()
        {
            Enviroment = Enums.MovementEnviroment.water;
        }

        public void GetOntoGround()
        {
            Enviroment = Enums.MovementEnviroment.ground;
        }


    }
}
