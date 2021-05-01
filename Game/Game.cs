using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Game_map_and_player
{
    class Game //Game Loop
    {
        private World MyWorld;
        private Player CurrentPlayer;
        private Monster CurrentMonster;
        private Monster CurrentMonster1;
        private Monster CurrentMonster2;
        private Monster CurrentMonster3;
        private Monster CurrentMonster4;



        public Random directionMonster = new Random();
        
        public void Start()
        {
            //WriteLine("Game is starting");
            Console.Title = "Save Mr. Smiley of Happy Evil Monsters";

            string[,] grid =
            {
                {"╔","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╗" },
                {"║"," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","⌂"," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," ","⌂"," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","⌂"," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"╚","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╝" },
            };
            //World myWorld = new World(grid);
            //myWorld.Draw();
            MyWorld = new World(grid);
            //Player currentPlayer = new Player(2, 2);
            //currentPlayer.Draw();
            CurrentPlayer = new Player(1, 10);

            CurrentMonster = new Monster(17, 10, "☻", ConsoleColor.Red);
            CurrentMonster1 = new Monster(15, 12, "☻", ConsoleColor.Red);
            CurrentMonster2 = new Monster(14, 17, "☻", ConsoleColor.Red);
            CurrentMonster3 = new Monster(16, 10, "☻", ConsoleColor.Red);
            CurrentMonster4 = new Monster(17, 13, "☻", ConsoleColor.Red);

            RunGameLoop();
        }
        private void displayIntro()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("WELKOM op 'Save Mr. Smiley of Happy Evil Monsters' GAME");
            Console.WriteLine("Probeer met de pijltjes ↔ ↕ op uw keyboard Mr. ☺ de overkant te laten bereiken..");
            Console.WriteLine("Druk op een toets om het spel te starten.");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.CursorVisible = false;
        }
        private void displayOutro()
        {
                for (int j = 0; j < 30; j++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                    Console.WriteLine("\n\n\nProficiat, u heeft heelhuids Mr. ☺ aan de overkant gekregen, en zodus GEWONNEN !!!!!");
                   
                    System.Threading.Thread.Sleep(200); // was 20
                }
            Console.WriteLine("\nDruk op een toets om het spel te sluiten.");
            Console.ReadKey(true);
        }

        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
            CurrentMonster.Draw();
            CurrentMonster1.Draw();
            CurrentMonster2.Draw();
            CurrentMonster3.Draw();
            CurrentMonster4.Draw();
        }
        private void HandleMonster()
        {
            int dir = directionMonster.Next(1, 5);
            switch (dir)
            {
                case 1:
                    {
                        if (MyWorld.IsPositioningWalkable(CurrentMonster.X, CurrentMonster.Y - 1))
                        {
                            CurrentMonster.Y -= 1;
                        }
                        break;
                    }
                case 2:
                    {
                        if (MyWorld.IsPositioningWalkable(CurrentMonster.X, CurrentMonster.Y + 1))
                        {
                            CurrentMonster.Y += 1;
                        }
                        break;
                    }
                case 3:
                    {
                        if (MyWorld.IsPositioningWalkable(CurrentMonster.X-1, CurrentMonster.Y))
                        {
                            CurrentMonster.X -= 1;
                        }
                        break;
                    }
                case 4:
                    {
                        if (MyWorld.IsPositioningWalkable(CurrentMonster.X+1, CurrentMonster.Y))
                        {
                            CurrentMonster.X += 1;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void HandlePlayerInput()
        {
            ConsoleKey key;
            //ontdendering
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;
            } while (KeyAvailable);

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                default:
                    break;
            }
        }
        private void RunGameLoop()
        {
            displayIntro();
            while (true)
            {
                //1. Draw everything
                DrawFrame();
                //2. Check input player + move avatar
                HandlePlayerInput();
                //3. let monsters move or shoot (TODO)
                HandleMonster();
                //4. Check if game has to end
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y); //get a copy of players position in Grid
                if (elementAtPlayerPos == "░")
                {
                    break;
                }
                //5. Give Console time to render
                System.Threading.Thread.Sleep(20);
            }
            displayOutro();
        }
    }
}
