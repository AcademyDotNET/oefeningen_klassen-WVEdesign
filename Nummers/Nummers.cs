using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Nummers //handboek pagina 76
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public Nummers()
        {

        }
        public int Som()
        {
            return (int)Getal1 + Getal2;
        }
        public int Verschil()
        {
            return (int)Getal1 - Getal2;
        }
        public int Product()
        {
            return (int)Getal1 * Getal2;
        }
        public double Quotient()
        {
            return (double)Getal1 / Getal2;
        }
    }
}

