using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yStart, int yFinish, char symb)
        {
            pList = new List<Point>();

            for(int i = yStart; i <= yFinish; i++)
            {
                Point p = new Point(x, i, symb);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (Point obj in pList)
            {
                //obj.pointPrint();
                obj.Draw();
            }
        }
    }
}
