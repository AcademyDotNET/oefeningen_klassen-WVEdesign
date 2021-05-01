using System;
using System.Collections.Generic;
using System.Text;

namespace Game_map_and_player
{
    class Player // x, y draw
    {
        public int Y { get; set; }
        public int X { get; set; }
        private string PlayerAvatar;
        private ConsoleColor PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerAvatar = "☺";
            PlayerColor = ConsoleColor.Red;
        }
        public void Draw()
        {
            Console.ForegroundColor = PlayerColor;
            Console.SetCursorPosition(X,Y);
            Console.Write(PlayerAvatar);
            Console.ResetColor();


        }


    }
}
