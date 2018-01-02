using System;
using System.Collections.Generic;

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

            Console.ReadLine();
        }


    }
}
