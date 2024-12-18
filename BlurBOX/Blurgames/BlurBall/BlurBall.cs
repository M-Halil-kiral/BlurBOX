using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.BlurBall
{
    public partial class BlurBall : Form
    {
        private Player player1;
        private Player player2;
        private Ball ball;
        private Goal goal1;
        private Goal goal2;
        private Timer gameTimer;

        private bool upPressed1, downPressed1, leftPressed1, rightPressed1;
        private bool upPressed2, downPressed2, leftPressed2, rightPressed2;

        private int scorePlayer1 = 0;
        private int scorePlayer2 = 0;

        public BlurBall()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.DoubleBuffered = true;

            player1 = new Player(50, 250, 20, 100, Color.Blue, Keys.W, Keys.S, Keys.A, Keys.D, Keys.Space);
            player2 = new Player(730, 250, 20, 100, Color.Red, Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.NumPad0);
            ball = new Ball(400, 300, 20, Color.Green);
            goal1 = new Goal(0, 200, 20, 200, Color.Black);
            goal2 = new Goal(780, 200, 20, 200, Color.Black);

            gameTimer = new Timer();
            gameTimer.Interval = 16;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            player1.Move(upPressed1, downPressed1, leftPressed1, rightPressed1);
            player2.Move(upPressed2, downPressed2, leftPressed2, rightPressed2);
            ball.Move(false, false, false, false);

            ball.CheckCollision(player1);
            ball.CheckCollision(player2);

            CheckGoal();

            this.Invalidate();
        }

        private void CheckGoal()
        {
            Rectangle ballRect = new Rectangle(ball.X, ball.Y, ball.Width, ball.Height);

            if (ballRect.IntersectsWith(new Rectangle(goal1.X, goal1.Y, goal1.Width, goal1.Height)))
            {
                scorePlayer2++;
                ResetBall();
            }
            else if (ballRect.IntersectsWith(new Rectangle(goal2.X, goal2.Y, goal2.Width, goal2.Height)))
            {
                scorePlayer1++;
                ResetBall();
            }
        }

        private void ResetBall()
        {
            ball.X = 400;
            ball.Y = 300;
            ball.SpeedX = 4;
            ball.SpeedY = 4;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            player1.Draw(g);
            player2.Draw(g);
            ball.Draw(g);
            goal1.Draw(g);
            goal2.Draw(g);

            using (Font font = new Font("Arial", 16))
            {
                g.DrawString($"Player 1: {scorePlayer1}", font, Brushes.Blue, 10, 10);
                g.DrawString($"Player 2: {scorePlayer2}", font, Brushes.Red, 650, 10);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == player1.UpKey) upPressed1 = true;
            if (e.KeyCode == player1.DownKey) downPressed1 = true;
            if (e.KeyCode == player1.LeftKey) leftPressed1 = true;
            if (e.KeyCode == player1.RightKey) rightPressed1 = true;

            if (e.KeyCode == player2.UpKey) upPressed2 = true;
            if (e.KeyCode == player2.DownKey) downPressed2 = true;
            if (e.KeyCode == player2.LeftKey) leftPressed2 = true;
            if (e.KeyCode == player2.RightKey) rightPressed2 = true;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == player1.UpKey) upPressed1 = false;
            if (e.KeyCode == player1.DownKey) downPressed1 = false;
            if (e.KeyCode == player1.LeftKey) leftPressed1 = false;
            if (e.KeyCode == player1.RightKey) rightPressed1 = false;

            if (e.KeyCode == player2.UpKey) upPressed2 = false;
            if (e.KeyCode == player2.DownKey) downPressed2 = false;
            if (e.KeyCode == player2.LeftKey) leftPressed2 = false;
            if (e.KeyCode == player2.RightKey) rightPressed2 = false;
        }
    }
}
