using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Resultaat
    {
        public int Percentage { get; set; }

        public Resultaat()
        {

        }
        public void PrintGraad()
        {
            if (Percentage < 50)
            {
                Console.WriteLine("< 50: niet geslaagd");
            }
            else if (Percentage >= 50 && Percentage < 68)
            {
                Console.WriteLine("tussen 50 en 68: voldoende");
            }
            else if (Percentage >= 68 && Percentage < 75)
            {
                Console.WriteLine("tussen 68 en 75: onderscheiding");
            }
            else if (Percentage >= 75 && Percentage < 85)
            {
                Console.WriteLine("tussen 75 en 85: grote onderscheiding");
            }
            else if (Percentage >= 85)
            {
                Console.WriteLine(">= 85: grootste onderscheiding, fantastisch!");
            }
        }
    }
}

