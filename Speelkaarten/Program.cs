//Maak een klasse Speelkaart die je kan gebruiken om een klassieke kaart met getal en "kleur" voor te stellen.

//Een kaart heeft 2 eigenschappen, een getal van 1 tot en met 13 (boer=11, koningin = 12, heer = 13):
//Een kleur, de zogenaamde suite. Deze stel je voor via een enumtype en kan als waarden Schoppen, Harten, Klaveren of Ruiten zijn.
//Schrijf nu 2 loops die de 52 kaarten van een standaard pak in een List<SpeelKaart> lijst plaatst.

//Maak nu een applicatie die telkens een willekeurige kaart uit de deck trekt en deze aan de gebruiker toont. De kaart wordt na het tonen
//dus uit de lijst verwijderd. Door met een willekeurig getal te werken hoef je dus je deck niet te schudden.

using System;
using System.Collections.Generic;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrijf nu 2 loops die de 52 kaarten van een standaard pak in een List<SpeelKaart> lijst plaatst.
            List<Speelkaart> speelkaarten = new List<Speelkaart>();
            for (int i = 1; i < 5; i++)
            {

                for (int j = 1; j < 14; j++)
                {
                    Speelkaart speelkaart = new Speelkaart();
                    speelkaart.Nummer = j;
                    speelkaart.Kleur = (Suit)i;
                    speelkaarten.Add(speelkaart);         // telkens speelkaart add met kleurindex i en nummerindex j
                }
            }

            // geeft de lijst weer van alle kaarten die overschieten.
            speelkaarten = TrekKaart(speelkaarten);

            foreach (var item in speelkaarten)
            {
                Console.WriteLine($"kleur: {item.Kleur}, nummer: {item.Nummer}.");
            }
            //for (int n = 0; n < speelkaarten.Count; n++)
            //{
            //    Console.WriteLine(speelkaarten[n].Kleur + " " + speelkaarten[n].Nummer);
            //    // Console.WriteLine($"{speelkaarten[n].Kleur}{speelkaarten[n].Nummer}");
            //}

        }

        private static List<Speelkaart> TrekKaart(List<Speelkaart> speelkaarten)
        {
            //     Maak nu een applicatie die telkens een willekeurige kaart uit de deck trekt en deze aan de gebruiker toont.
            //    De kaart wordt na het tonen dus uit de lijst verwijderd.Door met een willekeurig getal te werken hoef je
            //    dus je deck niet te schudden.
            Random random = new Random();
            int i = random.Next(1, speelkaarten.Count + 1);


            //geeft de kaart weer die verwijderd is geweest.
            Console.WriteLine(speelkaarten[i].Kleur + " " + speelkaarten[i].Nummer);
            speelkaarten.Remove(speelkaarten[i]);
            return speelkaarten;
        }
    }
}
