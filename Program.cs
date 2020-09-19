using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 2, '*');

            Point p2 = new Point(3, 4, '#') ;

            Point p3 = new Point(5, 6, '$');

            Point p4 = new Point(7, 8, '%');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point p in pList)
            {
                p.Draw();
            }


            Console.ReadLine();

        }

    }
}
