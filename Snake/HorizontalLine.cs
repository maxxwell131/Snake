using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>();
            for(int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pList.Add(p);
            }
           
        }

        public void Drow()
        {
            foreach(Point obj in pList)
            {
                //obj.pointPrint();
                obj.Draw();
            }
        }
    }
}
