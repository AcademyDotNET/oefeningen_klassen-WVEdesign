using System;

namespace Studentklasse
{
    class Program // Handboek1 pagina 71
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.KlasLokaal(KlasLokaal.EA1);
            student1.Naam("Wouter");
            student1.Leeftijd(40);
            student1.PuntenComm(68);
            student1.PuntenProg(74);
            student1.PuntenWeb(89);



            /*       student1.Klas = Klassen.EA2;
                   student1.Leeftijd = 21;
                   student1.Naam = "Joske Vermeulen";
                   student1.PuntenCommunicatie = 12;
                   student1.PuntenProgrammingPrinciples = 15;
                   student1.PuntenWebTech = 13;
            */
            student1.GeefOverzicht();
        }
    }
}
