using System;
namespace Snake
{
    public class Point
    {
            public int x;
        public int y;
        public char symb;

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        
    }
}
