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

        // Player settings //
        /////////////////////
        const int startPosPlayerX = 1;
        const int startPosPlayerY = 9;
        const int shootRangeMax = 8; // Player's max shooting range
        bool shootInVoid = true;  // bij true ook shoot animatie laten zien wanneer er niets in de weg staat

        public void Start()
        {
            //WriteLine("Game is starting");
            Console.Title = "Save Mr. Smiley of Happy Evil Monsters";

            CurrentPlayer = new Player(startPosPlayerX, startPosPlayerY);

            monster1 = new Monster("monster1", 7, 2, "☻", ConsoleColor.Red);
            monster2 = new Monster("monster2", 17, 12, "☻", ConsoleColor.Red);
            monster3 = new Monster("monster3", 2, 18, "☻", ConsoleColor.Red);
            monster4 = new Monster("monster4", 14, 9, "¤", ConsoleColor.DarkRed);
            monster5 = new Monster("monster5", 4, 14, "¤", ConsoleColor.DarkRed);

            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);
            monsters.Add(monster4);
            monsters.Add(monster5);

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

            MyWorld = new World(grid);

            RunGameLoop();

        }
        private void DisplayIntro()
        {
            Console.WindowHeight = 22;
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
            Console.WriteLine(" , gebruik SPATIEBALK om te schieten..");
            Console.WriteLine("\n              Druk op een toets om het spel te starten...");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.CursorVisible = false;
            Console.Clear();
        }
        private void DisplayOutro()
        {
            Console.WindowHeight = 22; // 20
            Console.WindowWidth = 85; //30
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int j = 0; j < 20; j++)
            {
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
        }
        private void DisplayOutroFail()
        {
            Console.WindowHeight = 22; // 20
            Console.WindowWidth = 85; //30
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (int j = 0; j < 20; j++)
            {
                Console.Clear();

                Console.WriteLine();
                var margin = "".PadLeft(j);
                Console.WriteLine(margin + "              _                                ");
                Console.WriteLine(margin + "             ▒∩░                               ");
                Console.WriteLine(margin + "          ▓▒░▒▌_               |||||         ");
                Console.WriteLine(margin + "          ▓▒▓░░               (⌐´_`)        ");
                Console.WriteLine(margin + "         ▓▒▓▒▒▒               |,  />        ");
                Console.WriteLine(margin + "       ▓▒▓▒░ ░▒              _/ \\_         ");
                Console.WriteLine("     -------------------------------------------------------- ");
                Console.WriteLine("\n\n\n                           You Lost !!                      ");

                System.Threading.Thread.Sleep(100); // was 20
            }
        }

        private void DrawFrame()
        {
            DrawInterface();
            MyWorld.Draw();
            CurrentPlayer.Draw();
            DrawAllMonsters();
        }

        private void DrawInterface()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkBlue;
            //MENU right side approach2
            WindowHeight = 22; // 20
            WindowWidth = 40; //30 
                              // setting everything with white spaces first
            for (int i = 0; i < 22; i++)
            {
                SetCursorPosition(23, i);
                Write("                  ");
            }
            // writing InterfaceConsole
            int lineNr = 0;
            ForegroundColor = ConsoleColor.DarkGreen;
            SetCursorPosition(23, lineNr);
            Write("             ");
            for (int i = 0; i < CurrentPlayer.PlayerLives; i++)
            {
                Write("☺");
            }
            ForegroundColor = ConsoleColor.DarkBlue;
            lineNr++;
            SetCursorPosition(23, lineNr); Write("     |||||       "); lineNr++;
            SetCursorPosition(23, lineNr); Write("     (⌐`_´)      "); lineNr++;
            SetCursorPosition(23, lineNr); Write("    <,►╦╤─       "); lineNr++;
            SetCursorPosition(23, lineNr); Write("     _/ \\_       "); lineNr++;
            SetCursorPosition(23, lineNr); Write("  -------------  "); lineNr++;
            //ForegroundColor = ConsoleColor.DarkRed;
            //BackgroundColor = ConsoleColor.Yellow;
            ////SetCursorPosition(25, lineNr); Write(">GOD-mode ON<"); lineNr++;
            //ForegroundColor = ConsoleColor.DarkBlue;
            //BackgroundColor = ConsoleColor.White;
            SetCursorPosition(25, lineNr); Write("          "); lineNr++;
            lineNr++;

            foreach (Monster var in monsters)
            {
                SetCursorPosition(25, lineNr); lineNr++;
                Console.Write(var.MonsterNaam + ": ");
                ForegroundColor = var.MonsterColor;
                Console.Write(var.MonsterAvatar);
                SetCursorPosition(25, lineNr); lineNr++;
                ForegroundColor = ConsoleColor.Black;
                Console.Write("x=" + var.X + " y=" + var.Y);
                ForegroundColor = ConsoleColor.DarkBlue;
            }


            //MENU right side approach1
            //Console.WindowHeight = 22; // 20
            //Console.WindowWidth = 40; //30 
            //Console.SetCursorPosition(0, 0);
            //var margin = "".PadLeft(23);
            //Console.WriteLine(margin + "                  ");
            //Console.WriteLine(margin + "      |||||       ");
            //Console.WriteLine(margin + "      (⌐`_´)      ");
            //Console.WriteLine(margin + "     <,►╦╤─       ");
            //Console.WriteLine(margin + "      _/ \\_       ");
            //Console.WriteLine(margin + "                  ");
            //for (int i = 0; i < 16; i++)
            //{
            //    Console.WriteLine(margin + "                  ");
            //}

            //MENU down side
            //Console.WindowHeight = 28; // 20
            //Console.WindowWidth = 23; //30 
            //Console.SetCursorPosition(0, 22);
            //var margin = "".PadLeft(5);
            //Console.WriteLine(margin + "                  ");
            //Console.WriteLine(margin + "      |||||       ");
            //Console.WriteLine(margin + "      (⌐`_´)      ");
            //Console.WriteLine(margin + "     <,►╦╤─       ");
            //Console.WriteLine(margin + "      _/ \\_       ");
            //Console.WriteLine(margin + "                  ");

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
            //if (KeyAvailable)
            //{
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
                                i = shootRangeMax; //exit FOR loop
                            }

                            // shooting monster if there is one
                            if (monsterInFrontPlayerPos != " ")
                            {
                                CurrentPlayer.Shoot(true, range);
                                shootInVoid = false;


                                foreach (Monster var in monsters.ToList())
                                {
                                    if (var.MonsterNaam == monsterInFrontPlayerPos)
                                    {
                                        var.Die(); // animation
                                        monsters.Remove(var);
                                    }
                                }
                                i = shootRangeMax; //exit FOR loop
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
            //}
            //else
            //{

            //}
        }

        private void RunGameLoop()
        {
            DisplayIntro();
            Clear();
            Console.BackgroundColor = ConsoleColor.White;

            while (true)
            {
                //1. Draw everything
                DrawFrame();

                //2. Check input player + move avatar
                HandlePlayerInput();

                //3. let monsters move or shoot 
                HandleMonsters();
                // if monster at playerposition, decrease player's lives and return current player to start position
                if (MyWorld.GetMonsterAt(CurrentPlayer.X, CurrentPlayer.Y, monsters) != " ")
                {
                    CurrentPlayer.PlayerLives--;
                    CurrentPlayer.X = startPosPlayerX;
                    CurrentPlayer.Y = startPosPlayerY;
                }

                //4. Check if game has to end and if so play correct animation and suggest to play again
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y); //get a copy of players position in Grid
                //WIN PART
                if (elementAtPlayerPos == "░")
                {
                    DisplayOutro();
                    break;
                }
                //LOOSE PART
                if (CurrentPlayer.PlayerLives < 1)
                {
                    DisplayOutroFail();
                    break;
                }

                //5. Give Console time to render
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
