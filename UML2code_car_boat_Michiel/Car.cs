using System;
using System.Collections.Generic;
using System.Text;

namespace UML2code_car_boat_Michiel
{
    class Car
    {
        public Car(bool _engine, int pistonCount)
        {
            if (_engine)
            {
               // Engine = new Engine(pistonCount);
            }
            CreateWheels();
        }
        void CreateWheels()
        {
            Wheel[] wheels = new Wheel[4];
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i] = new Wheel();
            }
        }

    }
}
