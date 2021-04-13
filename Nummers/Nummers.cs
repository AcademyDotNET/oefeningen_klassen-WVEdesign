using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public Nummers()
        {

        }
        public void Paar1()
        {
            if (Getal1 < Getal2)
            {
                Console.WriteLine("num1 kleiner dan num2");
            }
            else if (Getal1 >= Getal2)
            {
                Console.WriteLine("num1 groter dan num2");
            }
        }
    }
}

