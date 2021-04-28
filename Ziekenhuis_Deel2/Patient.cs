using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{

    
    class Patient
    {
        public double totaalKost = 0;

        public string Name { get; set; }
        public int AantalUur { get; set; }

        //Een virtual methode BerekenKost zal de totaalkost berekenen.Deze bestaat uit 50euro+ 20euro per uur dat de patiënt in het ziekenhuis lag.

        //Maak een methode ToonInfo die steeds de naam van de patiënt toont gevolgd door het aantal uur en z'n kosten.

        public void ToonInfo()
        {
            Console.WriteLine($"{Name} heeft in het ziekenhuis {AantalUur} uur gelegen. Dit kost in het totaal: EUR {BerekenKost()}");
        }

        public virtual double BerekenKost()
        {
            totaalKost = AantalUur * 20 + 50;
            return totaalKost;
        }
    }
    class VerzekerdePatient : Patient
    {
        //Deel 2
        //Maak een specialisatieklasse VerzekerdePatient. Deze klasse heeft alles dat een gewone Patient heeft, echter de berekening van de kosten zal steeds gevolgd worden door een 10 % reductie.

        //Toon de werking aan van deze klasse.
        public override double BerekenKost()
        {
            totaalKost = base.BerekenKost();
            return totaalKost - (totaalKost * 0.1);
        }
    }
}
