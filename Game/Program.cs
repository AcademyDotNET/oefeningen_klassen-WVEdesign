using System;
using System.Text;

// ToDo:    - map uit text file halen
//          - verschilllende levels (maps met newWorld, en static level counter in Game) maken.,
//             "░" gebruiken om naar de volgende level te gaan.
//          - parser maken om van map/grid automatisch monsters (en rotsen) in List van objecten te steken.
//
//          - 1.a., schieten van player == OK, nog functie toevoegen die scant of op bepaalde positie monsterobject staat en
//                // dit terug geeft == OK., alsook leven verwijderd van object tot het dood is.
//          - 1.b., Monsters player laten opeten + player terug op originele positie laten beginnen.
//          - 2. levens toevoegen dat player kan doodgaan(verliezen)+score
//
//          - Klasse Monster, .naam == OK + en .levens ♥♥♥ [10]
//          - Child klasse maken van Monster naar RockDestroyer ??
//          - polymorphe toepassen op monsters???, -> afgeleide.
//
//          - Infoboard onderaan(of rechts), player en monsters met levens en coordinaten, killed bool? Extra: tijd opmeting,
//             levelnr, score.
//          - herstarten van new game en stop game op basis van game object toevoegen
//          - Top 10 High Score board invoegen met Name entry enkel wanneer er een nieuwe high score is.
//          - Stylesheet integreren in code met klasse Css.cs (consolekleuren ed...)

namespace Game_map_and_player
{
    class Program  
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.Start();
        }
    }
}
