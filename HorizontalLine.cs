using System;
using System.Collections.Generic;
namespace snake
{
    public class HorizontalLine : Figure
    {

        public HorizontalLine(int xBegin, int xEnd, int y, char sym)
        {
            pList = new List<Point>();

            for (int i = xBegin; i <= xEnd; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }
        
    }
}
