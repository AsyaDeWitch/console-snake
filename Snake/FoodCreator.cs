using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Channels;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char symb;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char symb)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
