using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Walls walls = new Walls(74, 28);
            walls.Draw();

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

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
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
            }
        }

    }
}
