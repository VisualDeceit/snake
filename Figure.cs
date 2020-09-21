using System;
using System.Collections.Generic;

namespace snake
{
    public class Figure
    {
        protected List<Point> pList;

        public Figure()
        {
        }

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
