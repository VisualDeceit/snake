using System;
using System.Collections.Generic;
using System.Linq;

namespace snake
{
    public class Snake: Figure
    {
        Directions direction;

        public Snake(Point tail, int length, Directions _direction)
        {

            direction = _direction;

            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);

            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }


        private Point GetNextPoint()
        {
            Point p = new Point(pList.Last());
            p.Move(1, direction);
            return p;
        }
    }
}
