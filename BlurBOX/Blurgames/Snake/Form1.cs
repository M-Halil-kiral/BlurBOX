using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.Snake
{
   

    
        public partial class Form1 : Form
        {
            private Game game;
            private Timer timer;

            public Form1()
            {
                InitializeComponent();
                game = new Game();
                this.Paint += new PaintEventHandler(Form1_Paint);
                this.KeyDown += new KeyEventHandler(Form1_KeyDown);
                this.DoubleBuffered = true;
                this.KeyPreview = true;

                timer = new Timer();
                timer.Interval = 100;
                timer.Tick += Timer_Tick;
                timer.Start();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); // Form kapanma olayını işleme
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop(); // Timer'ı durdur
            game.Reset();
            // Oyunu sıfırla
            }

            private void Form1_Paint(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                foreach (Point part in game.Snake.Body)
                {
                    g.FillRectangle(Brushes.Green, new Rectangle(part.X * 20, part.Y * 20, 20, 20));
                }

                g.FillRectangle(Brushes.Red, new Rectangle(game.Food.Position.X * 20, game.Food.Position.Y * 20, 20, 20));

                g.DrawString("Score: " + game.Score, new Font("Arial", 16), Brushes.Black, new PointF(10, 10));
                g.DrawString("High Score: " + game.HighScore, new Font("Arial", 16), Brushes.Black, new PointF(10, 30));
            }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        if (game.Snake.CurrentDirection != Direction.Down)
                            game.Snake.CurrentDirection = Direction.Up;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        if (game.Snake.CurrentDirection != Direction.Up)
                            game.Snake.CurrentDirection = Direction.Down;
                        break;
                    case Keys.A:
                    case Keys.Left:
                        if (game.Snake.CurrentDirection != Direction.Right)
                            game.Snake.CurrentDirection = Direction.Left;
                        break;
                    case Keys.D:
                    case Keys.Right:
                        if (game.Snake.CurrentDirection != Direction.Left)
                            game.Snake.CurrentDirection = Direction.Right;
                        break;
                }
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                game.Update(new Size(this.ClientSize.Width / 20, this.ClientSize.Height / 20));
                this.Invalidate();

                if (game.IsGameOver)
                {
                    timer.Stop();
                    MessageBox.Show("Game Over! Your Score: " + game.Score);
                    game.Reset();
                    timer.Start();
                }
            }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    




      

        
    
}
