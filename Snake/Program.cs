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
            Console.SetBufferSize( 80, 26);

            HorizontalLine upLine = new HorizontalLine( 0, 79, 0,'*');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 79, 24, '*');
            downLine.Drow();

            VerticalLine leftLine = new VerticalLine( 0, 23, 0, '+');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(0, 23, 79, '+');
            rightLine.Drow();

            Point p = new Point( 4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(78, 24, '&');
            Point food =  foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else snake.Move();

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                System.Threading.Thread.Sleep(200);
            }
          
        }


    }
}
