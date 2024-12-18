using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX.Blurgames.Snake
{
    using System.Drawing;

    public class Game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }
        public int Score { get; private set; }
        public int HighScore { get; private set; }
        public bool IsGameOver { get; private set; }

        public Game()
        {
            Start();
        }

        public void Start()
        {
            Snake = new Snake(new Point(5, 5));
            Food = new Food(new Point(10, 10));
            Score = 0;
            IsGameOver = false;
        }

        public void Update(Size gameAreaSize)
        {
            if (IsGameOver)
                return;

            Snake.Move();

            Point head = Snake.Body.First();
            if (head.X < 0 || head.Y < 0 || head.X >= gameAreaSize.Width || head.Y >= gameAreaSize.Height)
            {
                IsGameOver = true;
                if (Score > HighScore)
                {
                    HighScore = Score;
                }
            }

            if (head.Equals(Food.Position))
            {
                Snake.Grow();
                Food.Reposition(gameAreaSize);
                Score += 10;
            }
        }

        public void Reset()
        {
            Start();
        }
    }


}
