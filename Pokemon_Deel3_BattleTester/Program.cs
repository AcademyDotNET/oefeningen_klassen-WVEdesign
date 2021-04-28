using System;

namespace Pokemon_Deel1_3_BattleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon weedle = GeneratorPokemon("weedle");
            Pokemon kakuna = GeneratorPokemon("kakuna");
            //Pokemon weedle = GeneratorPokemon2();
            //Pokemon kakuna = GeneratorPokemon2();

            //Console.WriteLine(Battle(ratata, kakuna));
            //Console.WriteLine(Battle(null, weedle));
            //Console.WriteLine(Battle(null, ratata));
            //Console.WriteLine(Battle(ratata, null)); //test

            string inputKeyString;
            do
            {
                

                Console.WriteLine($"Press any key to continue. (enter \'stop\' to end game) ");
                inputKeyString = Console.ReadLine();
                Console.WriteLine(BattleAndUpdateScore(weedle, kakuna));

                weedle.ShowInfo();
                kakuna.ShowInfo();

                //PrintPokemonStats(weedle);
                //PrintPokemonStats(kakuna);

            } while (inputKeyString != "stop");

            //PrintPokemonStats(ratata);
            //PrintPokemonStats(weedle);
            //PrintPokemonStats(kakuna);

            //ratata.ShowInfo();
            //weedle.ShowInfo();
            //kakuna.ShowInfo();
        }
        // optie1
        private static Pokemon GeneratorPokemon(string naam)
        {
            Pokemon pokemonNewName = new Pokemon();
            Random pokemonR = new Random();

            pokemonNewName.Naam = naam;

            pokemonNewName.HP_Base = pokemonR.Next(0, 101);
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

        static int Battle(Pokemon poke1, Pokemon poke2)
        {

            if (poke1 != null && poke2 != null)  // check of object geïnstantieerd is
            {
                int pokeFirst = poke1.HP_Base;
                int pokeSec = poke2.HP_Base;

                // int pokeFirst = (int)poke1.Average;
                //int pokeSec = (int)poke2.Average;

                if (pokeFirst > pokeSec)
                {
                    Console.WriteLine($"Poke1 {pokeFirst}");
                    Console.WriteLine($"Poke2 {pokeSec}");
                    return 1;
                }
                else if (pokeFirst < pokeSec)
                {
                    Console.WriteLine($"Poke1 {pokeFirst}");
                    Console.WriteLine($"Poke2 {pokeSec}");
                    return 2;
                }
                else
                {
                    Console.WriteLine($"Poke1 {pokeFirst}");
                    Console.WriteLine($"Poke2 {pokeSec}");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("één of meerdere pokemons zijn niet geïnstantieerd.");

                if (poke1 == null)
                {
                    Console.WriteLine($"Poke2 wint");
                    return 2;
                }
                else if (poke2 == null)
                {
                    Console.WriteLine($"Poke1 wint");
                    return 1;
                }
                else
                {
                    Console.WriteLine($"geen enkele Pokemon wint");
                    return 0;
                }
            }
        }

        static int BattleAndUpdateScore(Pokemon poke1, Pokemon poke2)
        {

            if (poke1 != null && poke2 != null)  // check of object geïnstantieerd is
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Wedstrijd tussen: {poke1.Naam} en {poke2.Naam}.");
                Console.ForegroundColor = ConsoleColor.Gray;

                int pokeFirst = poke1.HP_Base;
                int pokeSec = poke2.HP_Base;
                
                // int pokeFirst = (int)poke1.Average;
                //int pokeSec = (int)poke2.Average;

                if (pokeFirst > pokeSec)
                {
                    Console.WriteLine($"Poke1 ({poke1.Naam}): {pokeFirst}");
                    Console.WriteLine($"Poke2 ({poke2.Naam}): {pokeSec}");
                    Console.WriteLine($"{poke1.Naam} wint deze ronde.");
                    poke1.VerhoogLevel();
                    return 1;
                }
                else if (pokeFirst < pokeSec)
                {
                    Console.WriteLine($"Poke1 ({poke1.Naam}): {pokeFirst}");
                    Console.WriteLine($"Poke2 ({poke2.Naam}): {pokeSec}");
                    Console.WriteLine($"{poke2.Naam} wint deze ronde.");
                    poke2.VerhoogLevel();
                    return 2;
                }
                else
                {
                    Console.WriteLine($"Poke1 ({poke1.Naam}): {pokeFirst}");
                    Console.WriteLine($"Poke2 ({poke2.Naam}): {pokeSec}");
                    Console.WriteLine($"Gelijkspel tussen {poke1.Naam} en {poke2.Naam}.");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("één of meerdere pokemons zijn niet geïnstantieerd.");

                if (poke1 == null)
                {
                    Console.WriteLine($"{poke2.Naam} wint");
                    poke2.VerhoogLevel();
                    return 2;
                }
                else if (poke2 == null)
                {
                    Console.WriteLine($"{poke1.Naam} wint");
                    poke1.VerhoogLevel();
                    return 1;
                }
                else
                {
                    Console.WriteLine($"geen enkele Pokemon wint");
                    return 0;
                }
            }
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
