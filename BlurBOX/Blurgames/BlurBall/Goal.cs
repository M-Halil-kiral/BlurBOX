using System.Drawing;

namespace BlurBOX.Blurgames.BlurBall
{
    public class Goal : GameObject
    {
        public Goal(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color)
        {
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
        }
    }
}
