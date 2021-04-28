using System;
using System.Collections.Generic;
using System.Text;


//Maak bovenstaande klassenhierarchie na. Animal is de parentklasse , mammal en reptile zijn childklassen van Animal en zo voort.

//Verzin voor iedere klasse een property die de parent klasse niet heeft. (bv Animal heeft "BeweegVoort", Reptile heeft "AantalSchubben", etc).

//Voorzie in de klasse Animal een virtual methode ToonInfo die alle properties van de klasse op het scherm zet. De overgeërfde klassen overriden
//    deze methode door de extra properties ook te tonen (maar gebruik base.ToonInfo om zeker de parentklasse werking te bewaren).

//Maak nu van iedere klasse een object en roep de ToonInfo methode van ieder object aan.

//Plaats deze dieren nu in een List<Animal> en kijk wat er gebeurt als je deze met een foreach aanroept om alle ToonInfo-methoden van ieder dier te gebruiken.


namespace Het_dierenrijk
{
    class Animal
    {
        public string Name { get; set; }
        public bool Beweegvoort { get; set; }

        public virtual void ToonInfo()
        {
            Console.WriteLine($"naam is {Name}.");
        }

    }

    class Mammel : Animal
    {
        public bool Vegetarisch { get; set; }

        public override void ToonInfo()
        {
            //Console.WriteLine($"naam is {Name} en is {Vegetarisch} vegetarisch.");
            base.ToonInfo();
            Console.WriteLine($", en is {Vegetarisch} vegetarisch.");
        }
    }

    class Reptile : Animal
    {
        public int AantalSchubben { get; set; }

        public override void ToonInfo()
        {
            //Console.WriteLine($"naam is {Name} en heeft {AantalSchubben} schubben.");
            base.ToonInfo();
            Console.WriteLine($", en heeft {AantalSchubben} schubben.");

        }
    }

}
