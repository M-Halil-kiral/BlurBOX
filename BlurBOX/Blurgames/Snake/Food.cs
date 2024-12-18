using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX.Blurgames.Snake
{
    public class Food
    {
        public Point Position { get; private set; }

        public Food(Point startPosition)
        {
            Position = startPosition;
        }

        public void Reposition(Size gameAreaSize)
        {
            Random rand = new Random();
            Position = new Point(rand.Next(gameAreaSize.Width), rand.Next(gameAreaSize.Height));
        }
    }

}
