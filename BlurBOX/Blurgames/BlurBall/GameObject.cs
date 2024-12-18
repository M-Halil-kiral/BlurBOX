using System.Drawing;

namespace BlurBOX.Blurgames.BlurBall
{
    public abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color ObjectColor { get; set; }

        protected GameObject(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            ObjectColor = color;
        }

        public abstract void Draw(Graphics g);
        public abstract void Move(bool upPressed, bool downPressed, bool leftPressed, bool rightPressed);
    }
}
