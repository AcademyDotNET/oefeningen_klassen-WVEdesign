using System;
using System.Collections.Generic;
using System.Text;

namespace Ballspel_met_overerving_Basisklasse
{
    class Ball
    {
        public int X { get { return x; } }
        public int Y { get { return y; } }
        private int x = 0;
        private int y = 0;
        protected int vx = 0;
        protected int vy = 0;
        protected char drawChar = '#';
        protected ConsoleColor drawColor = ConsoleColor.Red;

        public Ball(int xin, int yin, int vxin, int vyin)
        {
            x = xin;
            y = yin;
            vx = vxin;
            vy = vyin;
        }

        public void Update()
        {
            x += vx;
            y += vy;
            if (x >= Console.WindowWidth || x < 0)
            {
                vx *= -1;           //detects if ball hits right or left side of console border
                x += vx;
            }
            if (y >= Console.WindowHeight || y < 0)
            {
                vy *= -1;          //detects if ball hits upper or bottom side of console border
                y += vy;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = drawColor;
            Console.Write(drawChar);
            Console.ResetColor();

        }

        static public bool CheckHit(Ball ball1, Ball ball2)
        {

            if (ball1.X == ball2.X && ball1.Y == ball2.Y)
                return true;

            return false;
        }
    }
}
