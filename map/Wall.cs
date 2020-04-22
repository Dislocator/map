using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace map
{
    class Wall
    {
        public int WallPosX { get; set; }
        public int WallPosY { get; set; }
        public int WallSizeX { get; set; }
        public int WallSizeY { get; set; }
        public Wall(int x, int y, int sizex, int sizey)
        {
            this.WallPosX = x;
            this.WallPosY = y;
            this.WallSizeX = sizex;
            this.WallSizeY = sizey;

        }
        public void WallCreate()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("X");
            Console.ResetColor();
        }
    }
}
