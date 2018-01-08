using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Snake(Point taile, int leght, Direction direction)
        {
            pList = new List<Point>();
            this.direction = direction;

            for (int i = 0; i < leght; i++)
            {
                Point p = new Point(taile);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);

            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            bool result = false;

            if(head.IsHit( food))
            {
                food.symb = head.symb;
                pList.Add(food);
                result = true;
            }
            return result;
        }
    }
}
