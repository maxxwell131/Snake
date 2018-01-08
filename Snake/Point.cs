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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.LEFT)
            {
                x = x - offset;
            } else if(direction == Direction.RIGHT)
            {
                x = x + offset;
            } else if(direction == Direction.UP)
            {
                y = y - offset;
            } else
            {
                y = y + offset;
            }
        }

        internal void Clear()
        {
            symb = ' ';
            Draw();
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

        public override string ToString()
        {
            return x + ", " + y + " ," + symb; 
                //base.ToString();
        }
    }
}
