using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator : Figure
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x;
            int y;
            int i = 0;

            x = random.Next(2, mapWidht - 2);
            y = random.Next(2, mapHeight - 2);
            Point p = new Point(x, y, sym);
            while(true)
            {
                if (p.IsFoodInSnake())
                {
                    x = random.Next(2, mapWidht - 2);
                    y = random.Next(2, mapHeight - 2);
                    i++;
                }
                else break;
            }
            return new Point(x, y, sym);
        }
    }
}