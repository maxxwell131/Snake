using System;
using System.Collections.Generic;

//https://github.com/Kartavec/snake/blob/lesson-5/RAM/Snake/Snake/Program.cs

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            Point p3 = new Point(21, 23, '@');
            Point p4 = new Point(33, 44, '%');


            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);
            pointList.Add(p1);

            foreach(Point obj in pointList)
            {
                obj.pointPrint();
            }

            pointList.RemoveAt(pointList.Count - 1);

            Console.WriteLine(new string('*', 30));

            foreach (Point obj in pointList)
            {
                obj.pointPrint();
            }


            Console.ReadLine();
        }


    }
}
