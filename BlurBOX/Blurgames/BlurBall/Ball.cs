using System.Drawing;

namespace BlurBOX.Blurgames.BlurBall
{
    public class Ball : GameObject
    {
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public Ball(int x, int y, int diameter, Color color)
            : base(x, y, diameter, diameter, color)
        {
            SpeedX = 4;
            SpeedY = 4;
        }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(ObjectColor))
            {
                g.FillEllipse(brush, X, Y, Width, Height);
            }
        }

        public override void Move(bool upPressed, bool downPressed, bool leftPressed, bool rightPressed)
        {
            X += SpeedX;
            Y += SpeedY;

            if (X < 0 || X + Width > 800) SpeedX = -SpeedX;
            if (Y < 0 || Y + Height > 600) SpeedY = -SpeedY;
        }

        // Çarpışma kontrol
        public void CheckCollision(Player player)
        {
            Rectangle ballRect = new Rectangle(X, Y, Width, Height);
            Rectangle playerRect = new Rectangle(player.X, player.Y, player.Width, player.Height);

            if (ballRect.IntersectsWith(playerRect))
            {
                // X ekseninde yön değiştir
                SpeedX = -SpeedX;
            }
        }
    }
}
