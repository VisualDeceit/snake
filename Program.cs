using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            upLine.Draw();

            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '-');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');
            rightLine.Draw();

            Point pBegin = new Point(39, 12, '*');
            Snake snake = new Snake(pBegin, 3, Directions.RIGTH);
            snake.Draw();

            Console.ReadLine();

        }

    }
}
