using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class MyCar
    {
        Engine engine;
        Tank tank;
        uint speed;
        uint max_speed;
        public Engine Engine
        {
            get => engine;
            private set => engine = value;
        }
        public Tank Tank { get => tank; private set => tank = value; }
        public uint Speed { get => speed; set => speed = value < max_speed ? value : max_speed; }
        public uint MaxSpeed {
            get => max_speed;
            private set => max_speed = value <= 420 ? value : throw new Exception("Error: You violated the laws of physics 0_0");
        }
        public MyCar(Engine engine, Tank tank)
        {
            Engine = engine;
            Tank = tank;
            if(Engine.Power >= 50 && Engine.Power <=100)
            {
                MaxSpeed = Engine.Power * 130 / 100;
            }
            else if (Engine.Power >= 50 && Engine.Power <= 100)
            {
                MaxSpeed = Engine.Power * 130 / 100;
            }
        }
    }
}
