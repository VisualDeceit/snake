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

        public void KeyHandle(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Directions.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Directions.RIGTH;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Directions.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Directions.DOWN;
                    break;
                default:
                    break;
            }
        }


        internal bool Eat(Point foodPoint)
        {
            Point headPoint = GetNextPoint();

            if (headPoint.IsHit(foodPoint))
            {
                foodPoint.sym = headPoint.sym;
                pList.Add(foodPoint);
                foodPoint.Draw();
                return true;
            } else
            {
                return false;
            }
        }
    }
}
