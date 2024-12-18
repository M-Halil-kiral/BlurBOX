using System.Drawing;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.BlurBall
{
    public class Player : GameObject
    {
        public Keys UpKey { get; set; }
        public Keys DownKey { get; set; }
        public Keys LeftKey { get; set; }
        public Keys RightKey { get; set; }
        public Keys ShootKey { get; set; }

        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public Player(int x, int y, int width, int height, Color color, Keys up, Keys down, Keys left, Keys right, Keys shoot)
     : base(x, y, 20, 50, color) // Boyutları 20x50 ayarlandı
        {
            UpKey = up;
            DownKey = down;
            LeftKey = left;
            RightKey = right;
            ShootKey = shoot;
            SpeedX = 5;
            SpeedY = 5;
        }


        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(ObjectColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
            }
        }

        public override void Move(bool upPressed, bool downPressed, bool leftPressed, bool rightPressed)
        {
            if (upPressed) Y -= SpeedY;
            if (downPressed) Y += SpeedY;
            if (leftPressed) X -= SpeedX;
            if (rightPressed) X += SpeedX;
        }
    }
}
