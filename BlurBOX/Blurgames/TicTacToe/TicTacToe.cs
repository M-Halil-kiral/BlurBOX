using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.TicTacToe
{
    public partial class TicTacToe : Form
    {
        private Game game;

        public TicTacToe()
        {
            InitializeComponent();
            game = new Game();
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";
        }
        private void ResetGame()
        {
            game = new Game();
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int row = -1, col = -1;

            // Butonun hangi satır ve sütunda olduğunu belirleyin
            switch (button.Name)
            {
                case "btn1": row = 0; col = 0; break;
                case "btn2": row = 0; col = 1; break;
                case "btn3": row = 0; col = 2; break;
                case "btn4": row = 1; col = 0; break;
                case "btn5": row = 1; col = 1; break;
                case "btn6": row = 1; col = 2; break;
                case "btn7": row = 2; col = 0; break;
                case "btn8": row = 2; col = 1; break;
                case "btn9": row = 2; col = 2; break;
            }

            game.MakeMove(row, col);
            button.Text = game.CurrentPlayer == "X" ? "O" : "X"; // Oyuncunun işaretini butona yaz
            lblStatus.Text = $"{game.CurrentPlayer}'in Sırası";

            // Kazanan kontrolü
            string winner;
            if (game.CheckWinner(out winner))
            {
                MessageBox.Show($"{winner} kazandı!"); // Kazananı göster
                ResetGame();
            }
            else if (game.IsDraw())
            {
                MessageBox.Show("Beraberlik!");
                ResetGame();
            }
        }
    }
}
