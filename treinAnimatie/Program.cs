using System;

namespace treinAnimatie
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o");
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o");
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o");
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.");
                    Console.WriteLine(margin + "      [________]_|__|________)< ");
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_");
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");

                    System.Threading.Thread.Sleep(10); // was 200
                }
            }

        }
    }
}
