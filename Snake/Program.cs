﻿using System;
using System.Collections.Generic;

//https://github.com/Kartavec/snake/blob/lesson-5/RAM/Snake/Snake/Program.cs

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HorizontalLine hLine = new HorizontalLine( 10, 20, 5,'*');
            hLine.Drow();

            Console.ReadLine();
        }


    }
}
