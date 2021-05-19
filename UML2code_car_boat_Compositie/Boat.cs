using System;
using System.Collections.Generic;
using System.Text;

namespace UML2code_car_boat_Compositie
{
    class Boat
    {
        public string Name { get; set; }
        public Propeller[] MyPropellers { get; set; }
        public Engine MyEngin { get; set; }

        public Boat()
        {
            MyPropellers = new Propeller[2];
            for (int i = 0; i < 2; i++)
            {
                MyPropellers[i] = new Propeller();
            }

            MyEngin = new Engine();

        }
    }
}
