using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Numerics;

namespace game
{
    public partial class Form1 : Form
    {
        Player seal;
        Stone current_stone, actually_stone;
        BackGround bck;

        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
        }

        public void Init()
        {
            seal = new Player(200, 200);
            bck = new BackGround(0, 0);
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(current_stone == null)
            {
                Random rnd = new Random();
                current_stone = new Stone(2020, 1080, rnd.Next(100, 400), rnd.Next(0, 2), false);
            }
            else { 
                if(current_stone.time <= 0)
                {
                    actually_stone = current_stone;
                    actually_stone.hv = true;
                    Random rnd = new Random();
                    current_stone = new Stone(2020, 1080, rnd.Next(100, 400), rnd.Next(0, 2), false);
                }
                else
                {
                    current_stone.time--;
                }
            }
            if(actually_stone != null)
            {
                if (actually_stone.hv)
                {
                    g.DrawImage(actually_stone.stoneImg, actually_stone.x, actually_stone.y, actually_stone.width, actually_stone.height);
                    actually_stone.x -= 5;
                }
            }
            if (bck.x * -1 >= 3468 - 1864)
            {
                bck.x = 0;
            }
            int toy = Cursor.Position.Y;

            if(toy + 50 > seal.y)
            {
                seal.inDown();
                seal.y += 3;
            }
            if(toy - 50 < seal.y)
            {
                seal.inUp();
                seal.y -= 3;
            }
            g.DrawImage(bck.image, bck.x, 0);
            g.DrawImage(seal.sealImg, seal.x,seal.y, seal.width, seal.height);

            bck.x -= 6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
