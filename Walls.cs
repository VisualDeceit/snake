using System;
using System.Collections.Generic;
namespace snake
{
    public class Walls
    {
        List<Figure> wallsList;

        public Walls(int fieldWidth, int fieldHeight)
        {
            wallsList = new List<Figure>();

            //borders
            Figure upLine = new HorizontalLine(1, fieldWidth - 1, 0, '═');
            Figure downLine = new HorizontalLine(1, fieldWidth - 1 , fieldHeight, '═');
            Figure leftLine = new VerticalLine(1, fieldHeight - 1, 0, '║');
            Figure rightLine = new VerticalLine(1, fieldHeight - 1, fieldWidth, '║');

            //corners
            Figure corner1 = new HorizontalLine(0, 0, 0, '╔');
            Figure corner2 = new HorizontalLine(fieldWidth , fieldWidth, 0, '╗');
            Figure corner3 = new HorizontalLine(0, 0, fieldHeight, '╚');
            Figure corner4 = new HorizontalLine(fieldWidth, fieldWidth, fieldHeight, '╝');


            wallsList.Add(upLine);
            wallsList.Add(downLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
            wallsList.Add(corner1);
            wallsList.Add(corner2);
            wallsList.Add(corner3);
            wallsList.Add(corner4);
        }

        public void Draw()
        {
            foreach (var wall in wallsList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallsList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
