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

            Patient Magda = new Patient(){ Name = "Magda", AantalUur = 3};
            Patient Danny = new Patient() { Name = "Danny", AantalUur = 698 };

            Magda.ToonInfo();
            Danny.ToonInfo();
        }
    }
}
