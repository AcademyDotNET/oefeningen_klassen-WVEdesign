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
        public void Start()
        {
            WriteLine("Game is starting");

            Console.Title = "Wouter's Game of Happy Evil Monsters";
            

            string[,] grid =
            {
                {"╔","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╗" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," ","☻"," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," ","☻"," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," ","☻"," "," ","░","║" },
                {"║"," "," "," "," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," ","☻"," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," ","☻"," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," ","☻","☻"," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," ","⌂"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," ","☻"," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","☻"," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"║"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","║" },
                {"╚","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","═","╝" },
            };
            //World myWorld = new World(grid);
            //myWorld.Draw();
            MyWorld = new World(grid);
            //Player currentPlayer = new Player(2, 2);
            //currentPlayer.Draw();
            CurrentPlayer = new Player(2, 2);

            RunGameLoop();
        }
        private void displayIntro()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("WELKOM op Wouter's HAPPY Evil game");
            Console.WriteLine("Probeer met de pijltjes ← ↑ → op uw keyboard Mr. ☺ de overkant te laten bereiken..");
            Console.WriteLine("Druk op een toets om het spel te starten.");
            Console.ResetColor();
           Console.ReadKey(true);
            Console.CursorVisible = false;
            
            
        }
        private void displayOutro()
        {
            Console.Clear();
            Console.WriteLine("you have Won!");
            Console.WriteLine("Druk op een toets om het spel te sluiten.");
            Console.ReadKey(true);
        }
        //SetCursorPosition(4, 2);
        //Write("☺");

        //WriteLine("\n\nPress any key to exit ...");
        //ReadKey(true);

        private void DrawFrame()
        {
            Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
       
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X, CurrentPlayer.Y-1))
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
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X-1, CurrentPlayer.Y))
                    {
                        CurrentPlayer.X -= 1;
                    }
                        break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositioningWalkable(CurrentPlayer.X+1, CurrentPlayer.Y))
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
                // Draw everything
                DrawFrame();
                // Check input player + move avatar
                HandlePlayerInput();
                // Check if game has to end
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.X, CurrentPlayer.Y); //get a copy of players position in Grid
                if(elementAtPlayerPos == "░")
                {
                    break;
                    
                }

                // give Console time to render
                    System.Threading.Thread.Sleep(20);

            }
            displayOutro();
        }
    }
}
