using System;
using System.Collections.Generic;
namespace snake
{
    public class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xBegin, int xEnd, int y, char sym)
        {
            pList = new List<Point>();

            for (int i = xBegin; i <= xEnd; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }

        public  void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        
    }
}
