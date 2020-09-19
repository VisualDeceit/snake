using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine hLine = new HorizontalLine(2, 10, 1, '+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(1, 10, 2, '+');
            vLine.Draw();

            Console.ReadLine();

        }

    }
}
