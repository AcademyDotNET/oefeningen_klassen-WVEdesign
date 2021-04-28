using System;

namespace Ballspel_met_overerving_Basisklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ballspel met overerving(zie hoorcollege voor extra uitleg)
            //============================================================

            //Volgende code toont hoe we een bestaande klasse Ball kunnen overerven om een bestuurbare bal te maken

            //Basisklasse Ball
            //We maken een klasse Ball die via Update en Draw zichzelf over het consolescherm beweegt. Enkele opmerkingen:

            //We maken sommige variabelen protected zodat later de overgeërfde klasse er aan kunnen
            //Een static methode CheckHit laat ons toe te ontdekken of twee Ballobjecten mekaar raken

            Console.CursorVisible = false;
            Console.WindowHeight = 50; // 20
            Console.WindowWidth = 100; //30
            Ball b1 = new Ball(4, 4, 1, 0);
            PlayerBall player = new PlayerBall(10, 10, 0, 0);
            while (true)
            {

                Console.Clear();

                //Ball
                b1.Update();
                b1.Draw();

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                if (Ball.CheckHit(b1, player))
                {
                    Console.Clear();
                    Console.WriteLine("Gewonnen!");
                    Console.ReadLine();
                }
                System.Threading.Thread.Sleep(20);//100
            }
        }
    }
}
