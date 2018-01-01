using System;
namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {

        }

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

        public void pointPrint()
        {
            Console.WriteLine("x = {0} y = {1} symbol = {2}", this.x, this.y, this.symb);
        }
        
    }
}
