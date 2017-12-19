using System;

namespace Snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            int x1 = 1;
            int y1 = 3;
            char symb1 = '*';
            Draw(x1,y1,symb1);
           

            int x2 = 4;
            int y2 = 5;
            char symb2 = '#';
            Draw(x2,y2,symb2);

*/
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.symb = '*';
            p1.Draw();
            //Draw(p1.x,p1.y, p1.symb);

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.symb = '#';
            p2.Draw();
            //Draw(p2.x, p2.y, p2.symb);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
