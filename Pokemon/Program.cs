using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ratata = GeneratorPokemon("ratata");
            Pokemon weedle = GeneratorPokemon2();
            Pokemon kakuna = GeneratorPokemon2();

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
        // optie1
        private static Pokemon GeneratorPokemon(string naam)
        {
            Pokemon pokemonNewName = new Pokemon();
            Random pokemonR = new Random();

            pokemonNewName.Naam = naam;
            pokemonNewName.HP_Base = pokemonR.Next(0,101);
            pokemonNewName.Attack_Base = pokemonR.Next(0, 101);
            pokemonNewName.Defense_Base = pokemonR.Next(0, 101);
            pokemonNewName.SpecialAttack_Base = pokemonR.Next(0, 101);
            pokemonNewName.SpecialDefense_Base = pokemonR.Next(0, 101);
            pokemonNewName.Speed_Base = pokemonR.Next(0, 101);

            return pokemonNewName;
        }
        // optie2
        private static Pokemon GeneratorPokemon2()
        {
            Pokemon pokemonNewName = new Pokemon();
            Random pokemonR = new Random();

            pokemonNewName.HP_Base = pokemonR.Next(0, 101);
            pokemonNewName.Attack_Base = pokemonR.Next(0, 101);
            pokemonNewName.Defense_Base = pokemonR.Next(0, 101);
            pokemonNewName.SpecialAttack_Base = pokemonR.Next(0, 101);
            pokemonNewName.SpecialDefense_Base = pokemonR.Next(0, 101);
            pokemonNewName.Speed_Base = pokemonR.Next(0, 101);

            return pokemonNewName;
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
