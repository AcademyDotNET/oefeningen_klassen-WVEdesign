using System;

namespace RapportModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultaat mijnPunten = new Resultaat();
            mijnPunten.Percentage = 65;
            mijnPunten.PrintGraad();
        }
    }
}
