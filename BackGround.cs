using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class BackGround
    {
        public Image image;
        public int width; public int height; public int x; public int y;

        public BackGround(int x, int y)
        {
            this.image = new Bitmap("C:\\projects c#\\game\\sprites\\background.jpg");
            this.width = 1920;
            this.height = 1080;
            this.x = x;
            this.y = y;
        }
    }
}
