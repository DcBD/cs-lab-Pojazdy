using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Classes;

namespace VehicleLib.Abstract
{
    public abstract class GroundVehicle : VehicleBase
    {
        public int WheelsCount { get; }

        public GroundVehicle(int wheelsCount) : base()
        {
            WheelsCount = wheelsCount;
            Enviroment = Enums.MovementEnviroment.ground;

        }

        public new virtual string ToString()
        {

            return $"Typ: Lądowy \n " +
                $"Ilość kół: {WheelsCount} \n " + base.ToString();
        }
    }
}
