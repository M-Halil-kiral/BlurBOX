using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBOX.Blurgames.MayınTarlası
{
    public partial class MayinTarlasi : Form
    {
        public MayinTarlasi()
        {
            InitializeComponent();
        }
        private Minesweeper minesweeper;

        private void MayinTarlasi_Load(object sender, EventArgs e)
        {
            minesweeper = new Minesweeper(10, 10, 20); // 10x10 grid, 20 mayın
            CreateGrid();
        }

        private void CreateGrid()
        {
            panel1.Controls.Clear();
            int cellSize = 40;

            for (int r = 0; r < minesweeper.Rows; r++)
            {
                for (int c = 0; c < minesweeper.Columns; c++)
                {
                    Button button = new Button
                    {
                        Width = cellSize,
                        Height = cellSize,
                        Location = new Point(c * cellSize, r * cellSize),
                        Tag = minesweeper.Cells[r, c]
                    };

                    button.MouseClick += Cell_Click;
                    panel1.Controls.Add(button);
                }
            }
        }

        private void Cell_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Cell cell = button.Tag as Cell;

            if (e.Button == MouseButtons.Left) // Sol tıklama
            {
                RevealCell(cell, button);
                CheckWinCondition(); // Oyun kazanma durumunu kontrol et
            }
            else if (e.Button == MouseButtons.Right) // Sağ tıklama: İşaretleme
            {
                if (!cell.IsRevealed)
                {
                    cell.IsFlagged = !cell.IsFlagged;
                    button.Text = cell.IsFlagged ? "🚩" : "";
                    UpdateLabels();
                }
            }
        }

        private void RevealCell(Cell cell, Button button)
        {
            if (cell.IsRevealed || cell.IsFlagged) return;

            cell.IsRevealed = true;

            // Hücreyi aç ve metni güncelle
            if (cell.IsMine)
            {
                button.Text = "💣";
                GameOver(false); // Oyun bitti
            }
            else if (cell.AdjacentMines > 0)
            {
                button.Text = cell.AdjacentMines.ToString();
                button.Enabled = false;
            }
            else
            {
                button.Text = "";
                button.Enabled = false;

                // Çevresindeki hücreleri aç
                int row = button.Location.Y / button.Height;
                int column = button.Location.X / button.Width;

                for (int dr = -1; dr <= 1; dr++)
                {
                    for (int dc = -1; dc <= 1; dc++)
                    {
                        int nr = row + dr;
                        int nc = column + dc;

                        if (nr >= 0 && nr < minesweeper.Rows && nc >= 0 && nc < minesweeper.Columns)
                        {
                            Button neighborButton = panel1.Controls
                                .OfType<Button>()
                                .FirstOrDefault(b => b.Location == new Point(nc * button.Width, nr * button.Height));

                            if (neighborButton != null)
                            {
                                RevealCell(minesweeper.Cells[nr, nc], neighborButton);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateLabels()
        {
            int flaggedCount = minesweeper.Cells.Cast<Cell>().Count(c => c.IsFlagged);
            // Buraya işaretli hücrelerin sayısını gösteren label güncelleme kodu ekleyebilirsiniz
        }

        private void CheckWinCondition()
        {
            bool allRevealed = minesweeper.Cells.Cast<Cell>()
                .All(c => c.IsRevealed || (c.IsMine && c.IsFlagged));

            if (allRevealed)
            {
                GameOver(true);
            }
        }

        private void GameOver(bool won)
        {
            lblGameStatus.Text = won ? "Durum: Kazandınız!" : "Durum: Kaybettiniz!";
            foreach (Control control in panel1.Controls)
            {
                if (control is Button button)
                {
                    Cell cell = button.Tag as Cell;
                    if (cell.IsMine)
                    {
                        button.Text = "💣";
                    }
                }
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            minesweeper = new Minesweeper(10, 10, 20);
            lblGameStatus.Text = "Durum: Devam Ediyor";
            UpdateLabels();
            CreateGrid();
        }
    }
}
