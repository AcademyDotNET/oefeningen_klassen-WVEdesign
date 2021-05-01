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

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0); // Y-as
            Cols = Grid.GetLength(1); // X-as
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
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    Console.Write(element);
                }
            }
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }

        public bool IsPositioningWalkable(int x, int y)
        {
            if (x < 1 || y < 1 || x >= Cols-1 || y >= Rows-1 || Grid[y, x] == "⌂" || Grid[y, x] == "☻")
            {
                return false;
            }
            if(Grid[y,x] == " " || Grid[y, x] == "░")
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
