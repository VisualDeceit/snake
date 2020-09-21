using System;
namespace snake
{
    public class Point
    {

        public int x;
        public int y;
        public char sym;


        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            sym = _p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Directions dir)
        {
            switch (dir)
            {
                case Directions.RIGTH:
                    x += offset;
                    break;
                case Directions.LEFT:
                    x -= offset;
                    break;
                case Directions.UP:
                    y -= offset;
                    break;
                case Directions.DOWN:
                    y += offset;
                    break;
                default:
                    break;

            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + sym;
        }


        internal bool IsHit(Point p)
        {
            return x == p.x && y == p.y;
        }
    }
}
