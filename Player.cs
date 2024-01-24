using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace game
{
    internal class Player
    {
        public int x; public int y;

        public int width; public int height;

        public Image sealImg;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
            sealImg = new Bitmap("C:\\projects c#\\game\\sprites\\seal-sprite3.png");
            width = 129; height = 61;
        }

        public void inUp()
        {
            sealImg = new Bitmap("C:\\projects c#\\game\\sprites\\seal-sprite1.png");
        }

        public void inDown()
        {
            sealImg = new Bitmap("C:\\projects c#\\game\\sprites\\seal-sprite2.png");
        }
    }
}
