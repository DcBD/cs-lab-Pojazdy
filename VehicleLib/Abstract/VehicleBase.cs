using System;
using System.Collections.Generic;
using System.Text;
using VehicleLib.Abstract;
using VehicleLib.Enums;

namespace VehicleLib.Classes
{
    public abstract class VehicleBase
    {
        double _currentSpeed = 0;
        MovementEnviroment _enviroment;
        public double MinSpeed { get; set; }
        public double MaxSpeed { get; set; }

        public SpeedUnit SpeedUnit { get; set; }

        public double CurrentSpeed
        {
            get { return _currentSpeed; }
            set
            {

                if (!IsStarted)
                {
                    Console.WriteLine("Vehicle is not started!");
                    return;
                }

                if (value < 0) _currentSpeed = 0;
                else if (value < MinSpeed) _currentSpeed = MinSpeed;
                else if (value > MaxSpeed) _currentSpeed = MaxSpeed;
                else _currentSpeed = value;

            }
        }

        public bool IsStarted => State == VehicleState.start;

        public VehicleState State { get; set; }


        public MovementEnviroment Enviroment { 
            get => _enviroment; 
            set {
                _enviroment = value;

                OnEnviromentChanged();
            }
        }

        public VehicleBase()
        {
            State = VehicleState.stop;
        }


        public void Start()
        {
            if (IsStarted) throw new ArgumentOutOfRangeException("Vehicle is already moving");

            Console.WriteLine($"Starting vehicle: {this.GetType()}");
            this.State = VehicleState.start;
            this.CurrentSpeed = this.MinSpeed;
        }

        public void Stop()
        {
            if (!IsStarted) throw new ArgumentOutOfRangeException("Vehicle is stopped");

            Console.WriteLine($"Stopping vehicle: {this.GetType()}");

            this.State = VehicleState.stop;
            this.CurrentSpeed = 0;
        }

        public void Accelerate(double accelerateValue)
        {
            if (!IsStarted)
            {
                Console.WriteLine("Vehicle is not started!");
            }
            else
            {
                this.CurrentSpeed += accelerateValue;
                Console.WriteLine($"Accelerating vehicle speed by: {accelerateValue}, current speed is: {CurrentSpeed}{SpeedUnit}");
            }

        }

        public void Decelerate(double decelerateValue)
        {
            if (!IsStarted)
            {
                Console.WriteLine("Vehicle is not started!");

            }
            else
            {
                this.CurrentSpeed -= decelerateValue;
                Console.WriteLine($"Decelerating vehicle speed by: {decelerateValue}, current speed is: {CurrentSpeed}{SpeedUnit}");
            }

        }

        public void OnEnviromentChanged()
        {
            switch (Enviroment)
            {
                case MovementEnviroment.water:
                    MinSpeed = 1;
                    MaxSpeed = 40;
                    SpeedUnit = SpeedUnit.nmi;
                    return;
                case MovementEnviroment.ground:
                    MinSpeed = 1;
                    MaxSpeed = 350;
                    SpeedUnit = SpeedUnit.kmph;
                    return;
                case MovementEnviroment.air:
                    MinSpeed = 20;
                    MaxSpeed = 200;
                    SpeedUnit = SpeedUnit.mps;
                    return;
                default:
                    MinSpeed = 0;
                    MaxSpeed = 0;
                    SpeedUnit = SpeedUnit.kmph;
                    return;
            }
        }


        public string ToString()
        {
            return 
                $"Aktualne środowisko: {Enviroment} \n " +
                $"Stan: {IsStarted} \n " +
                $"Minimalna szybkość: {MinSpeed} \n " +
                $"Maksymalna szybkość: {MaxSpeed} \n " +
                $"Aktualna szybkość: {CurrentSpeed} \n ";
        }



    }
}
