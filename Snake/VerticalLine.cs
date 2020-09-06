using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine: Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }

    }
}
