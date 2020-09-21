using System;
namespace snake
{
    public class Food
    {
        int fieldWidth;
        int fieldHeigth;
        char sym;

        Random random = new Random();

        public Food(int fiedWidth, int fieldHeigth, char sym)
        {
            this.fieldWidth = fiedWidth;
            this.fieldHeigth = fieldHeigth;
            this.sym = sym;
        }


        public Point Create()
        {
            int x = random.Next(2, fieldWidth - 2);
            int y = random.Next(2, fieldHeigth - 2);

            return new Point(x, y, sym);

        }

    }
}
