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
        public int PlayerLives;
        private ConsoleColor PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            //Console.WriteLine("       Rechts bewegen: ☺→    , Links bewegen: ¬☺");
            PlayerAvatar = "☺";
            PlayerLives = 3;
            PlayerColor = ConsoleColor.DarkGreen;
            
        }
        public void Draw()
        {
            Console.ForegroundColor = PlayerColor;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(X,Y);
            Console.Write(PlayerAvatar);
            Console.ResetColor();
        }
        public void Shoot(bool fatal, int range) // Shooting animation
          {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(X+1, Y);
            
            for (int i = 0; i < range; i++)
            {
                Console.Write("—");
            }
            System.Threading.Thread.Sleep(10);
            Console.SetCursorPosition(X + 1, Y);
            for (int i = 0; i < range; i++)
            {
                Console.Write(" ");
                System.Threading.Thread.Sleep(5);
            }
            if (fatal)
            {
            Console.SetCursorPosition(X + range + 1, Y);
            Console.WriteLine("×");
            System.Threading.Thread.Sleep(50);
            Console.SetCursorPosition(X + range + 1, Y);
            Console.WriteLine("o");//¹²³
            System.Threading.Thread.Sleep(30);
            Console.SetCursorPosition(X + range + 1 , Y);
            Console.WriteLine("☼");//×¹²³
            System.Threading.Thread.Sleep(30);
            }
            else
            {

            }
        }
        
        public void Walk()
        {
            PlayerAvatar = "☺";//" ☺ "
        }
       
    }
}
