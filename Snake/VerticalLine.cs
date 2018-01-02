using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine:Figure
    {
        public VerticalLine(int yStart, int yFinish, int x, char symb)
        {
            pList = new List<Point>();

            for(int i = yStart; i <= yFinish; i++)
            {
                Point p = new Point(x, i, symb);
                pList.Add(p);
            }
        }
    }
}
