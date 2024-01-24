using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    internal class Stone
    {
        public int x; public int y;

        public int width; public int height;

        public int time; public bool hv;

        public Image stoneImg;

        public Stone(int x, int y, int height, int time, bool hv)
        {
            this.x = x;
            this.y = y;
            stoneImg = new Bitmap("C:\\projects c#\\game\\sprites\\stone.png");
            this.width = 100; this.height = height; this.time = time;
            this.hv = hv;
        }
    }
}
