using System;
using System.Collections.Generic;

namespace snake
{
    public class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yBegin, int yEnd, int x, char sym)
        {
            pList = new List<Point>();

            for (int i = yBegin; i <= yEnd; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
