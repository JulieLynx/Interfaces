using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Engine
    {
        uint power;
        double consumption;
        //bool started;
        public uint Power
        {
            get => power;
            set
            {
                power = (value >= 50 && value <= 1000)? value: throw new Exception("Bad engine power");
            }
        }
        public double Consumption
        {
            get => consumption;
            private set => consumption = value;
        }
        public bool Started { get; set; }

        public Engine(uint power)
        {
            Power = power;
            consumption = .0002 * (Power / 15);
            Started = false;
        }
        public override string ToString()
        {
            return $"Power:{Power}hp, Consumption {Consumption*3600} l/100 km, engine  {(Started?"started":"stopped")}";
        }
    }
}
