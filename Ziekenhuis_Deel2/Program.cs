using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deel 1
            //Maak een basisklasse Patient die een programma kan gebruiken om de doktersrekening te berekenen. Een patiënt heeft:

            //een naam
            //het aantal uur dat hij in het ziekenhuis heeft gelegen
            //Een virtual methode BerekenKost zal de totaalkost berekenen.Deze bestaat uit 50euro+ 20euro per uur dat de patiënt in het ziekenhuis lag.

            //Maak een methode ToonInfo die steeds de naam van de patiënt toont gevolgd door het aantal uur en z'n kosten.

            //Deel 2
            //Maak een specialisatieklasse VerzekerdePatient. Deze klasse heeft alles dat een gewone Patient heeft, echter de berekening van de kosten zal steeds gevolgd worden door een 10 % reductie.

            //Toon de werking aan van deze klasse.

            Patient Magda = new Patient() { Name = "Magda", AantalUur = 3 };
            Patient Danny = new Patient() { Name = "Danny", AantalUur = 698 };
            VerzekerdePatient Bieke = new VerzekerdePatient() { Name = "Bieke", AantalUur = 3 };
            VerzekerdePatient Louiseke = new VerzekerdePatient() { Name = "Louiseke", AantalUur = 698 };

            Magda.ToonInfo();
            Danny.ToonInfo();
            Bieke.ToonInfo();
            Louiseke.ToonInfo();
        }
    }
}
