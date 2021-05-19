using System;
using System.Collections.Generic;
using System.Text;

namespace UML2code_car_boat_Compositie
{
    class Engine
    {
        public string Name { get; set; }
        public Crankshaft MyCrankshaft { get; set; }
        public Piston[] MyPistons { get; set; }



        public Engine()
        {
            MyCrankshaft = new Crankshaft();

            MyPistons = new Piston[4];

            for (int i = 0; i < 4; i++)
            {
                MyPistons[i] = new Piston();
            }
        }
    }
}
