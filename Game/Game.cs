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
        private Monster monster1;
        private Monster monster2;
        private Monster monster3;
        private Monster monster4;
        private Monster monster5;
        public List<Monster> monsters = new List<Monster>(5);

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
                {"║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","║"," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," ","║"," "," ","⌂"," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," ","═","═","╣"," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," ","║"," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," ","║"," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," ","║"," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," ","║"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," ","═","╬","═"," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","═","╗"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," ","⌂"," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","║"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","╚","═"," "," "," "," "," "," "," "," ","⌂"," ","░","║" },
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
            CurrentPlayer = new Player(1, 9);

            monster1 = new Monster(17, 11, "☻", ConsoleColor.Red);
            monster2 = new Monster(17, 12, "☻", ConsoleColor.Red);
            monster3 = new Monster(17, 13, "☻", ConsoleColor.Red);
            monster4 = new Monster(17, 14, "☻", ConsoleColor.DarkRed);
            monster5 = new Monster(17, 15, "☻", ConsoleColor.DarkRed);

            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);
            monsters.Add(monster4);
            monsters.Add(monster5);

            //foreach(Monster var in monsters)
            //{
            //    Console.WriteLine(var.X +" "+ var.Y + " " + var.MonsterAvatar + " " + var.MonsterColor);
            //}

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

                Console.WriteLine();
                var margin = "".PadLeft(j);
                Console.WriteLine(margin + "                                              ");
                Console.WriteLine(margin + "        __                                    ");
                Console.WriteLine(margin + "      _/  \\_                                 ");
                Console.WriteLine(margin + "      (⌐`_´)                                  ");
                Console.WriteLine(margin + "     <,►╦╤─ ☼ - -                             ");
                Console.WriteLine(margin + "      _/ \\_                                  ");
                Console.WriteLine("     --------------------------------------------------");
                Console.WriteLine("\n\n\nProficiat, u heeft heelhuids Mr. ☺ aan de overkant gekregen, en zodus GEWONNEN !!!!!");

                System.Threading.Thread.Sleep(200); // was 20
            }
            //charmap windows font consolas
            //Console.WriteLine("☺☻╣╝×¹²³«»╠╣═║‡†∞∩≈↑→↓↔↕↨∑←⌂▓▒░▌☼♦♥♣♠╔╗╬╚╝");
            Console.WriteLine("\nDruk op een toets om het spel te sluiten.");
            Console.ReadKey(true);
        }

        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();

            foreach (Monster var in monsters)
            {
                var.Draw();
            }
        }
        
        private void HandleMonsters()
        {
            foreach (Monster var in monsters)
            {
                int dir = directionMonster.Next(1, 5);
                switch (dir)
                {
                    case 1:
                        {
                            if (MyWorld.IsPositioningWalkable(var.X, var.Y - 1, monsters))
                            {
                                var.Y -= 1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (MyWorld.IsPositioningWalkable(var.X, var.Y + 1, monsters))
                            {
                                var.Y += 1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (MyWorld.IsPositioningWalkable(var.X - 1, var.Y, monsters))
                            {
                                var.X -= 1;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (MyWorld.IsPositioningWalkable(var.X + 1, var.Y, monsters))
                            {
                                var.X += 1;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void HandlePlayerInput()
        {
            ConsoleKey key;
            //ontdendering (debouncing) Keyboard inputs
            do
            {
                ConsoleKeyInfo keyInfo = ReadKey(true);
                key = keyInfo.Key;
            } while (KeyAvailable);

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X, CurrentPlayer.Y - 1, monsters))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X, CurrentPlayer.Y + 1, monsters))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X - 1, CurrentPlayer.Y, monsters))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X + 1, CurrentPlayer.Y, monsters))
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
                //3. let monsters move or shoot 
                HandleMonsters();
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
