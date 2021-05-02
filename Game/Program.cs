using System;
using System.Text;

// ToDo:    - parser maken om van map/grid automatisch monsters en rotsen in List van objecten te steken.
//          - Klasse Monster, .naam + en .levens♥♥♥ + en schietmogelijkheid toevoegen
//          - Scoreboard onderaan, player en monsters met levens en coordinaten, killed bool? Extra: tijd opmeting
//          - Child klasse maken van Monster naar RockDestroyer ??
//          - Een speler kan niet door rotsen of monsters wandelen. Monsters door monsters werkt al.
//          - speler rechts laten schieten + mapelement vernietigen
//          - Monsters laten schieten., player wanneer leven kwijt op originele/initial coordinaten laten herbeginnen? 

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
