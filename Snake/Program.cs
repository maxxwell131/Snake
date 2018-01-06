using System;
using System.Collections.Generic;
using System.Threading;

//https://github.com/Kartavec/snake/blob/lesson-5/RAM/Snake/Snake/Program.cs

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25);

            HorizontalLine upLine = new HorizontalLine( 0, 70, 0,'*');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 70, 24, '*');
            downLine.Drow();

            VerticalLine leftLine = new VerticalLine( 0, 24, 0, '+');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(0, 24, 70, '+');
            rightLine.Drow();

            Point p = new Point( 4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            System.Threading.Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }


    }
}
