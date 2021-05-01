using System;
using System.Collections.Generic;
using System.Text;

namespace Game_map_and_player
{
    class Monster
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string MonsterAvatar { get; set; }
        public ConsoleColor MonsterColor { get; set; }

        public Monster(int initialX, int initialY, string avatarSymbol, ConsoleColor Color)
        {
            X = initialX;
            Y = initialY;
            MonsterAvatar = avatarSymbol;
            MonsterColor = Color;
        }
        public void Draw() 
        {
            Console.ForegroundColor = MonsterColor;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X, Y);
            Console.Write(MonsterAvatar);
            Console.ResetColor();
        }
    }
}
