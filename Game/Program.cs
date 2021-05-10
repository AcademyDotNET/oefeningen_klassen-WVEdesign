using System;
using System.Text;

// ToDo:    - 2.a., parser maken om van map/grid automatisch monsters (2.b., en rotsen) in List van objecten te steken.
//          - map(=level) uit text file halen
//          - verschilllende levels (maps met newWorld, en static level counter in Game) maken.,
//             "░" gebruiken om naar de volgende level te gaan.
//
//          - 1.a., schieten van player == OK, nog functie toevoegen die scant of op bepaalde positie monsterobject staat en
//    OK       dit terug geeft == OK., alsook leven verwijderd van object tot het dood is. == OK
//          - 1.b., Monsters player laten opeten == OK + player terug op originele positie laten beginnen == OK
//          - 1.c.. levens toevoegen dat player kan doodgaan(verliezen) == OK 
//
//          - Klasse Monster, .naam == OK + en .levens ♥♥♥ [10]
//          - Child klasse maken van Monster naar RockDestroyer ??
//          - polymorphe toepassen op monsters???, -> afgeleide.
//
//          - Infoboard onderaan(of rechts)==OK, player en monsters met levens en coordinaten, killed bool? Extra: tijd opmeting,
//             levelnr, score.
//          - herstarten van new game en stop game op basis van game object toevoegen = OK
//          - Top 10 High Score board invoegen met Name entry enkel wanneer er een nieuwe high score is.
//          - Stylesheet integreren in code met klasse Css.cs (consolekleuren ed...)

namespace Game_map_and_player
{
    class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            startNewGameOrQuit(currentGame, false);
        }

        private static void startNewGameOrQuit(Game currentGame, bool resetGame)
        {
            if (resetGame)
            {
                Console.WriteLine("\n\n\n            Play Again? [Y]     , to Stop Hit any other key");
                Console.SetCursorPosition(25, 16);
                Console.CursorVisible = true; string toEndOrNot = Console.ReadLine();
                
                if (toEndOrNot == "y" || toEndOrNot == "Y")
                {
                    currentGame = null;
                    currentGame = new Game();
                    currentGame.Start();
                    startNewGameOrQuit(currentGame, true);
                }
                else
                {
                    Console.WriteLine("Thanks for playing, cu soon !");
                }
            }
            else
            {
                Console.CursorVisible = false;
                currentGame.Start();
                startNewGameOrQuit(currentGame, true);
            }
        }
    }
}