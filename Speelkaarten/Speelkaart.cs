using System;
using System.Collections.Generic;
using System.Text;

namespace Speelkaarten
{
       enum Suit
    {
        Schoppen = 1,
        Harten,
        Klaveren,
        Ruiten
    }

    class Speelkaart
    {
        //    Maak een klasse Speelkaart die je kan gebruiken om een klassieke kaart met getal en "kleur" voor te stellen.

        //    Een kaart heeft 2 eigenschappen(==properties); 
        //    1. een getal van 1 tot en met 13 (boer=11, koningin= 12, heer= 13):
        //    2. Een kleur, de zogenaamde suite.Deze stel je voor via een enumtype en kan als waarden Schoppen, Harten, Klaveren of Ruiten zijn.

        public Suit Kleur { get; set; } //kleur, de zogenaamde suite.Deze stel je voor via een enumtype
        public int Nummer { get; set; } //een getal van 1 tot en met 13 (boer=11, koningin= 12, heer= 13)
    }
}
