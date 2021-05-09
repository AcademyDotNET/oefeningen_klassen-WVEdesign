using System;
using System.Collections.Generic;
using System.Text;

namespace Game_map_and_player
{
    class World //2D array drawManager world
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;
       // public Monster monster;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0); // Y-as
            Cols = Grid.GetLength(1); // X-as

        }
        
        public void DrawConsole()
        {
            Console.WindowHeight = Rows; // 20
            Console.WindowWidth = Cols; //30 
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    Console.SetCursorPosition(x, y);
                    if (element == "☻")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (element == "⌂")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (element == "░")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (element == "╔" || element == "═" || element == "╗" || element == "║" ||
                        element == "╝" || element == "╬" || element == "╣" || element == "╠" || element == "╚")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(element);
                }
            }
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }
        public string GetMonsterAt(int x, int y, List<Monster> monsters)
        {
            string name = " ";
            foreach (Monster var in monsters)
            {
                // monster op monsterplaats
                if (var.X == x && var.Y == y)
                {
                    name =  var.MonsterNaam ;
                }
            }
            return name;
        }

        public bool IsPositionFree(int x, int y, List<Monster> monsters)
        {
            // monsters
            foreach (Monster var in monsters)
            {
                // monster op monsterplaats
                if (var.X == x && var.Y == y)
                {
                    return false;
                }
            }
            foreach (Monster var in monsters)
            {
                // RockDestroyermonster vs rock
                if (var.MonsterAvatar == "¤")
                {
                    if (Grid[var.Y, var.X - 1] == "⌂")
                    {
                        //white spacing rock links
                        Grid[var.Y, var.X - 1] = " ";
                        //Console.Beep();
                        return false;
                    }
                    else if (Grid[var.Y, var.X + 1] == "⌂")
                    {
                        //white spacing rock rechts
                        Grid[var.Y, var.X + 1] = " ";
                        // Console.Beep(); explosion sound
                        return false;
                    }
                }
                //Console.WriteLine(var.X + " " + var.Y + " " + var.MonsterAvatar + " " + var.MonsterColor);
            }

            // Bounderies en rotsen
            if (x < 1 || y < 1 || x >= Cols - 1 || y >= Rows - 1 || Grid[y, x] == "⌂" || Grid[y, x] == "☻")
            {
                return false;
            }

            if (Grid[y, x] == " " || Grid[y, x] == "░")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
