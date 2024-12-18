using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX.Blurgames.Snake
{
    public enum Direction { Up, Down, Left, Right }

    public class Snake
    {
        public List<Point> Body { get; private set; }
        public Direction CurrentDirection { get; set; }

        public Snake(Point startPosition)
        {
            Body = new List<Point> { startPosition };
            CurrentDirection = Direction.Right;
        }

        public void Move()
        {
            // Hareket mantığı
            Point newHead = Body.First();

            switch (CurrentDirection)
            {
                case Direction.Up:
                    newHead.Y -= 1;
                    break;
                case Direction.Down:
                    newHead.Y += 1;
                    break;
                case Direction.Left:
                    newHead.X -= 1;
                    break;
                case Direction.Right:
                    newHead.X += 1;
                    break;
            }

            Body.Insert(0, newHead);
            Body.RemoveAt(Body.Count - 1);
        }

        public void Grow()
        {
            // Yılanın büyümesi için vücut uzatılması
            Body.Add(Body.Last());
        }
    }

}
