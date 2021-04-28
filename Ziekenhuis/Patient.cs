using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class Patient
    {
        public int totaalKost = 0;
        
        public string Name { get; set; }
        public int AantalUur { get; set; }

        //Een virtual methode BerekenKost zal de totaalkost berekenen.Deze bestaat uit 50euro+ 20euro per uur dat de patiënt in het ziekenhuis lag.

        //Maak een methode ToonInfo die steeds de naam van de patiënt toont gevolgd door het aantal uur en z'n kosten.

        public void ToonInfo()
        {
            Console.WriteLine($"{Name} heeft in het ziekenhuis {AantalUur} uur gelegen. Dit kost in het totaal: EUR {BerekenKost()}");
        }

        public virtual int BerekenKost()
        {
            totaalKost = AantalUur * 20 + 50;
            return totaalKost;
        }
    }
   
}
