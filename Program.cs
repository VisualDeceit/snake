using System;
using System.Collections.Generic;
using System.Threading;

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


            Food foodField= new Food(78, 24, '$');
            Point food = foodField.Create();
            food.Draw();

            while (true)
            {
                if (Console.KeyAvailable){
                    snake.KeyHandle(Console.ReadKey().Key);
                }

                if (snake.Eat(food))
                {
                    food = foodField.Create();
                    food.Draw();
                } else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                //snake.Move();
            }

           // Console.ReadLine();

        }

    }
}
