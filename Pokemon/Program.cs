using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ratata = new Pokemon();
            Pokemon weedle = new Pokemon();
            Pokemon kakuna = new Pokemon();

            ratata.HP_Base = 30;
            ratata.Attack_Base = 10;
            ratata.Defense_Base = 10;
            ratata.SpecialAttack_Base = 24;
            ratata.SpecialDefense_Base = 17;
            ratata.Speed_Base = 80;

            weedle.HP_Base = 55;
            weedle.Attack_Base = 16;
            weedle.Defense_Base = 18;
            weedle.SpecialAttack_Base = 64;
            weedle.SpecialDefense_Base = 37;
            weedle.Speed_Base = 8;

            kakuna.HP_Base = 15;
            kakuna.Attack_Base = 33;
            kakuna.Defense_Base = 90;
            kakuna.SpecialAttack_Base = 30;
            kakuna.SpecialDefense_Base = 11;
            kakuna.Speed_Base = 21;

            Console.WriteLine(ratata.HP_FULL);

            PrintPokemonStats(ratata);
            PrintPokemonStats(weedle);
            PrintPokemonStats(kakuna);

            //Level - up tester
            //Maak een kleine loop die je toelaat om per loop een bepaalde Pokemon z’n level met 1 te verhogen en vervolgens toon je dan z’n nieuwe stats.
            Console.WriteLine($"\nLevel: {ratata.Level}");
            for (int i=0; i < 100; i++)
            {
                ratata.VerhoogLevel();
            }
            Console.WriteLine($"Level: {ratata.Level}");
            
            PrintPokemonStats(ratata);
            PrintPokemonStats(weedle);
            PrintPokemonStats(kakuna);

            ratata.ShowInfo();
            weedle.ShowInfo();
            kakuna.ShowInfo();
        }

        private static void PrintPokemonStats(Pokemon pokemonNaam)
        {
            Console.WriteLine(pokemonNaam.Attack_Full);
            Console.WriteLine(pokemonNaam.Defence_Full);
            Console.WriteLine(pokemonNaam.HP_FULL);
            Console.WriteLine(pokemonNaam.SpecialAttack_Full);
            Console.WriteLine(pokemonNaam.SpecialDefence_Full);
            Console.WriteLine(pokemonNaam.Speed_Full);
        }
    }
}
