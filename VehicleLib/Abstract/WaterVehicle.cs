using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Classes;

namespace VehicleLib.Abstract
{
    public abstract class WaterVehicle : VehicleBase
    {
        public int Displacement { get; }


        public WaterVehicle(int displacement) : base()
        {
            Enviroment = Enums.MovementEnviroment.water;
            Displacement = displacement;

        }


        public new virtual string ToString()
        {

            return $"Typ: Wodny \n " +
                $"Wyporność: {Displacement} \n " + base.ToString();
        }


        

    }
}
