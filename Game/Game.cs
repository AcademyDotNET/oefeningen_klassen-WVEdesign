using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<Monster> monsters = new List<Monster>(5);

        private Random directionMonster = new Random();

        // Player settings
        const int shootRangeMax = 8; // Player's max shooting range
        bool shootInVoid = true;  // bij true ook shoot animatie laten zien wanneer er niets in de weg staat

        public void Start()
        {
            //WriteLine("Game is starting");
            Console.Title = "Save Mr. Smiley of Happy Evil Monsters";

            string[,] grid =
            {
                {"╔","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╗" },
                {"║"," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," ","⌂"," "," "," ","⌂"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," "," "," ","║"," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," ","║"," ","⌂","⌂"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," ","║"," "," "," ","═","═","╣"," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," ","⌂"," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," ","⌂"," "," "," "," "," "," ","║"," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," ","⌂"," ","⌂"," ","║"," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," ","║"," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," ","⌂"," "," "," "," "," ","⌂","⌂"," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," ","║"," ","⌂","⌂"," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," ","═","╬","═"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," ","⌂"," "," ","║","⌂","⌂"," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","═","╗"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," ","⌂"," ","░","║"," "," "," ","⌂"," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," ","⌂"," "," "," ","║"," "," "," "," "," "," "," "," ","⌂"," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","╚","═"," "," "," "," "," "," "," "," ","⌂"," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," ","⌂"," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"╚","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╝" },
            };
            //World myWorld = new World(grid);   
            //myWorld.Draw();
            MyWorld = new World(grid);
            //Player currentPlayer = new Player(2, 2);
            //currentPlayer.Draw();
            CurrentPlayer = new Player(1, 9);

            monster1 = new Monster("monster1", 17, 11, "☻", ConsoleColor.Red);
            monster2 = new Monster("monster2", 17, 12, "☻", ConsoleColor.Red);
            monster3 = new Monster("monster3", 17, 13, "☻", ConsoleColor.Red);
            monster4 = new Monster("monster4", 14, 14, "¤", ConsoleColor.DarkRed);
            monster5 = new Monster("monster5", 15, 14, "¤", ConsoleColor.DarkRed);

            //charmap windows font consolas
            //Console.WriteLine("☺☻╣╝×¹²³«»╠╣═║‡†∞∩≈↑→↓↔↕↨∑←⌂▓▒░▌☼♦♥♣♠╔╗╬╚╝§¤¶");

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
            Console.WindowHeight = 22; // 20
            Console.WindowWidth = 85; //30
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("\n\n\n\n          WELKOM op 'Save Mr. Smiley of Happy Evil Monsters' GAME");
            Console.Write("\nProbeer met de pijltjes ↔ ↕ op uw keyboard Mr. ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("☺");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" de overkant te laten bereiken..");
            Console.WriteLine("\n              Druk op een toets om het spel te starten...");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.CursorVisible = false;


        }
        private void displayOutro()
        {
            Console.WindowHeight = 22; // 20
            Console.WindowWidth = 85; //30
            for (int j = 0; j < 20; j++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();

                Console.WriteLine();
                var margin = "".PadLeft(j);
                Console.WriteLine(margin + "                                     _          ");
                Console.WriteLine(margin + "                                    ▒∩░         ");
                Console.WriteLine(margin + "      |||||                        ▓▒░▒▌        ");
                Console.WriteLine(margin + "      (⌐`_´)                      ▓▒▓░░         ");
                Console.WriteLine(margin + "     <,►╦╤─ ☼ - -                ▓▒▓▒▒▒         ");
                Console.WriteLine(margin + "      _/ \\_                    ▓▒▓▒░ ░▒        ");
                Console.WriteLine("     --------------------------------------------------  ");
                Console.WriteLine("\n\n\nProficiat, u heeft Mr. ☺ heelhuids aan de overkant gekregen, en zodus GEWONNEN !!!!!");

                System.Threading.Thread.Sleep(100); // was 20
            }

            //Console.WriteLine("\nDruk op een toets om het spel te sluiten.");
            //Console.ReadKey(true);
        }

        private void DrawFrame()
        {
            //Clear();

            MyWorld.Draw();
            CurrentPlayer.Draw();
            DrawAllMonsters();

        }

        private void DrawAllMonsters()
        {
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
                            if (MyWorld.IsPositionFree(var.X, var.Y - 1, monsters))
                            {
                                var.Y -= 1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (MyWorld.IsPositionFree(var.X, var.Y + 1, monsters))
                            {
                                var.Y += 1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (MyWorld.IsPositionFree(var.X - 1, var.Y, monsters))
                            {
                                var.X -= 1;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (MyWorld.IsPositionFree(var.X + 1, var.Y, monsters))
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
                    if (MyWorld.IsPositionFree(CurrentPlayer.X, CurrentPlayer.Y - 1, monsters))
                    {
                        CurrentPlayer.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionFree(CurrentPlayer.X, CurrentPlayer.Y + 1, monsters))
                    {
                        CurrentPlayer.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionFree(CurrentPlayer.X - 1, CurrentPlayer.Y, monsters))
                    {
                        CurrentPlayer.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionFree(CurrentPlayer.X + 1, CurrentPlayer.Y, monsters))
                    {
                        CurrentPlayer.X += 1;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    {
                        for (int i = 0; i <= shootRangeMax; i++)
                        {
                            int range = i - 1;
                            shootInVoid = true;
                            string mapElementInFrontPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X + i, CurrentPlayer.Y); //get a copy of players position in Grid
                            string monsterInFrontPlayerPos = MyWorld.GetMonsterAt(CurrentPlayer.X + i, CurrentPlayer.Y, monsters);

                            // not shooting through map elements
                            if (mapElementInFrontPlayerPos != " ")
                            {
                                CurrentPlayer.Shoot(false, range);
                                shootInVoid = false;
                                i = shootRangeMax;
                            }

                            // shooting monster if there is one
                            if (monsterInFrontPlayerPos != " ")
                            {
                                CurrentPlayer.Shoot(true, range);
                                shootInVoid = false;
                                
                                foreach (Monster var in monsters.ToList())
                                {
                                    // monster op monsterplaats
                                    if (var.MonsterNaam == monsterInFrontPlayerPos)
                                    {
                                        var.Die(); // animation
                                        monsters.Remove(var);
                                    }
                                }
                                i = shootRangeMax;
                            }
                        }
                        // shooting full range when nothing is in the way
                        if (shootInVoid == true)
                        {
                            CurrentPlayer.Shoot(false, shootRangeMax);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void RunGameLoop()
        {
            displayIntro();
            MyWorld.DrawConsole();
            while (true)
            {
                //1. Draw everything
                DrawFrame();
                //2. Check input player + move avatar
                HandlePlayerInput();
                //3. let monsters move or shoot 
                HandleMonsters();
                //4. Check if game has to end and if so play animation and suggest to play again
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y); //get a copy of players position in Grid
                if (elementAtPlayerPos == "░")
                {
                    displayOutro();

                    Console.CursorVisible = true;
                    Console.WriteLine("\n\n\n            Play Again? [Y]     , to Stop Hit any other key");

                    string toEndOrNot = Console.ReadLine();
                    if (toEndOrNot == "y" || toEndOrNot == "Y")
                    {
                        // set playersposition back to origin and continue while loop
                        // monsters posities blijven onverandert, dit moet anders met new game object.
                        CurrentPlayer.X = 1;
                        CurrentPlayer.Y = 9;
                        Console.CursorVisible = false;
                        MyWorld.DrawConsole();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing, cu soon !");
                        break;
                    }
                }
                //5. Give Console time to render
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}
