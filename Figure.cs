using System;
using System.Collections.Generic;

namespace snake
{
    public class Figure
    {
        List<Point> pList;

        public Figure()
        {
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
