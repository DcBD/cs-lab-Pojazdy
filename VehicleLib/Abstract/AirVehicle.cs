using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Classes;

namespace VehicleLib.Abstract
{
    public abstract class AirVehicle : VehicleBase
    {

        public AirVehicle() : base()
        {
            Enviroment = Enums.MovementEnviroment.ground;

        }

        public void TakeOff()
        {
            Enviroment = Enums.MovementEnviroment.air;
            Console.WriteLine("The vehicle is taking off (...)");
        }

        public void Land()
        {
            Enviroment = Enums.MovementEnviroment.ground;
            Console.WriteLine("The vehicle landed.");
        }

        public new virtual void Stop()
        {
            if(Enviroment == Enums.MovementEnviroment.air)
            {
                Console.WriteLine("You must land vehicle in order to stop it.");
                return;
            }

            base.Stop();
        }

        public new virtual string ToString()
        {

            return $"Typ: Powietrzny \n " + base.ToString();
        }

    }
}
