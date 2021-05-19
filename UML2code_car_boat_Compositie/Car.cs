using System;
using System.Collections.Generic;
using System.Text;

namespace UML2code_car_boat_Compositie
{
    class Car
    {
        public string Name { get; set; }
        public Wheel MyWheels { get; set; }
        public Engine MyEngins { get; set; }

        public Car()
        {
            MyWheels = new Wheel();

            MyEngins = new Engine();
        }

    }
}
