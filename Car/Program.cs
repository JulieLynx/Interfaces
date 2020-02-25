using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank(40);
            tank.Fill(10);
            tank.Fill(20);
            Console.WriteLine(tank);

            Engine engine = new Engine(200);
            Console.WriteLine(engine);
        }
    }
}
