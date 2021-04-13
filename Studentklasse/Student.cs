using System;
using System.Collections.Generic;
using System.Text;

namespace Studentklasse // Handboek1 pagina 71
{
    public enum KlasLokaal
    {
        EA1,
        EA2,
        EA3,
        EA4,
        EA5,
        EA6
    };
    class Student
    {
        public KlasLokaal klas;
        public string studentNaam;
        public int leeftijd;
        public int pComm;
        public int pProg;
        public int pWeb;
        public Student()
        {

        }
        // set //
        public void KlasLokaal(KlasLokaal v)
        {
            klas = v;
        }

        internal void Naam(string v)
        {
            studentNaam = v;
        }

        internal void Leeftijd(int v)
        {
            leeftijd = v;
        }
        internal void PuntenComm(int v)
        {
            pComm = v;
        }
        internal void PuntenProg(int v)
        {
            pProg = v;
        }
        internal void PuntenWeb(int v)
        {
            pWeb = v;
        }


        /// get /////
        public KlasLokaal GetKlasLokaal()
        {
            return klas;
        }

        public string GetNaam()
        {
            return studentNaam;
        }

        public int GetLeeftijd()
        {
            return leeftijd;
        }
        public int GetPuntenCommunicatie()
        {
            return pComm;
        }
        public int GetPuntenProgrammingPrinciples()
        {
            return pProg;
        }
        public int GetPuntenWebTech()
        {
            return pWeb;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine(value: $"student: {GetNaam()}" +
                $"\nleeftijd: {GetLeeftijd()}" +
                $"\npunten communicatie: {GetPuntenCommunicatie()}" +
                $"\npunten programmeren: {GetPuntenProgrammingPrinciples()}" +
                $"\npunten webtechnologie: {GetPuntenWebTech()}" +
                $"\nklaslokaal: {GetKlasLokaal()}" +
                $" ");
        }
    }
}
