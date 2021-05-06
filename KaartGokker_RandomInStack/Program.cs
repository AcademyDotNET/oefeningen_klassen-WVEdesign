//Maak een klasse Speelkaart die je kan gebruiken om een klassieke kaart met getal en "kleur" voor te stellen.

//Een kaart heeft 2 eigenschappen, een getal van 1 tot en met 13 (boer=11, koningin = 12, heer = 13):
//Een kleur, de zogenaamde suite. Deze stel je voor via een enumtype en kan als waarden Schoppen, Harten, Klaveren of Ruiten zijn.
//Schrijf nu 2 loops die de 52 kaarten van een standaard pak in een List<SpeelKaart> lijst plaatst.

//Maak nu een applicatie die telkens een willekeurige kaart uit de deck trekt en deze aan de gebruiker toont. De kaart wordt na het tonen
//dus uit de lijst verwijderd. Door met een willekeurig getal te werken hoef je dus je deck niet te schudden.

using System;
using System.Collections.Generic;

namespace KaartGokker_RandomInStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // List methodes
            //*******************
            Console.WriteLine("\nList methode:\n");

            //Schrijf nu 2 loops die de 52 kaarten van een standaard pak in een List<SpeelKaart> lijst plaatst.
            List<Speelkaart> speelkaarten = new List<Speelkaart>();

            //Put into List :
            speelkaarten = CreateSuite(speelkaarten);

            //Willekeurige kaart eruit trekken
            speelkaarten = TrekKaart(speelkaarten);

            //Geeft de lijst weer van alle kaarten die overschieten.
            ShowSuite(speelkaarten);

            // Stack methodes https://www.tutorialsteacher.com/csharp/csharp-stack
            //*******************
            Console.WriteLine("\nStack methode:\n");

            // first create fresh List suite of cards and show it
            List<Speelkaart> speelkaart4stack = new List<Speelkaart>();
            speelkaart4stack = CreateSuite(speelkaart4stack);
            ShowSuite(speelkaart4stack);

            //Create Stack
            Stack<Speelkaart> stackSuite = new Stack<Speelkaart>();

            //Push willekeurig getrokken kaart

            stackSuite.Push(TrekKaartStack(speelkaart4stack));
            stackSuite.Push(TrekKaartStack(speelkaart4stack));
            stackSuite.Push(TrekKaartStack(speelkaart4stack));
            stackSuite.Push(TrekKaartStack(speelkaart4stack));
            stackSuite.Push(TrekKaartStack(speelkaart4stack));

            foreach (Speelkaart item in stackSuite)
                Console.WriteLine(item); //prints 4,3,2,1, 
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
        private static Speelkaart TrekKaartStack(List<Speelkaart> speelkaart4stack)
        {
            Random randoms = new Random();
            int i = randoms.Next(1, speelkaart4stack.Count + 1);

            Console.WriteLine(speelkaart4stack[i].Kleur + " " + speelkaart4stack[i].Nummer);
            Speelkaart getrokkenKaart = speelkaart4stack[i];
            speelkaart4stack.Remove(speelkaart4stack[i]);
            return getrokkenKaart;
        }

        private static List<Speelkaart> CreateSuite(List<Speelkaart> speelkaarten)
        {
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
            return speelkaarten;
        }

        private static void ShowSuite(List<Speelkaart> speelkaarten)
        {
            foreach (var item in speelkaarten)
            {
                Console.WriteLine($"kleur: {item.Kleur}, nummer: {item.Nummer}.");
            }
        }

        private static void ShowStackSuite(Stack<Speelkaart> stackSuite)
        {
            foreach (var item in stackSuite)
            {
                Console.WriteLine($"kleur: {item.Kleur}, nummer: {item.Nummer}.");
            }
        }
    }
}
