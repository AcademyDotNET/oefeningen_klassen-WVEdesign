//Prijzen met foreach
//Maak een array die tot 20 prijzen (double) kan bewaren.Vraag aan de gebruiker om 20 prijzen in te voeren en bewaar deze in de array. 
//Doorloop vervolgens m.b.v.een foreach-lus de volledige array en toon enkel de elementen op het scherm wiens prijs hoger of gelijk is aan €5.00. 
//Toon op het einde van het programma het gemiddelde van alle prijzen (dus inclusief de lagere prijzen).



using System;

namespace Prijzen_met_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = new double[20];
            double sum = 0;
            double averageTotal = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Enter price {i + 1}:");
                prices[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (double price in prices)
            {
                sum += price;

                if (price >= 5)
                {
                    Console.WriteLine(price);
                }
            }

            averageTotal = sum / prices.Length;
            Console.WriteLine($"Total average is {averageTotal}");
        }
    }
}
