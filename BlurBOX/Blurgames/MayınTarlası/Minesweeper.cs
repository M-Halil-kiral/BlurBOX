using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX.Blurgames.MayınTarlası
{
    public class Minesweeper
    {
        public int Rows { get; }
        public int Columns { get; }
        public int MineCount { get; }
        public Cell[,] Cells { get; }

        public Minesweeper(int rows, int columns, int mineCount)
        {
            Rows = rows;
            Columns = columns;
            MineCount = mineCount;
            Cells = new Cell[rows, columns];
            InitializeCells();
            PlaceMines();
            CalculateAdjacentMines();
        }

        private void InitializeCells()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    Cells[r, c] = new Cell();
                }
            }
        }

        private void PlaceMines()
        {
            Random random = new Random();
            int placedMines = 0;

            while (placedMines < MineCount)
            {
                int r = random.Next(Rows);
                int c = random.Next(Columns);

                if (!Cells[r, c].IsMine)
                {
                    Cells[r, c].IsMine = true;
                    placedMines++;
                }
            }
        }

        private void CalculateAdjacentMines()
        {
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Columns; c++)
                {
                    if (Cells[r, c].IsMine) continue;

                    int adjacentMines = 0;

                    for (int dr = -1; dr <= 1; dr++)
                    {
                        for (int dc = -1; dc <= 1; dc++)
                        {
                            int nr = r + dr, nc = c + dc;

                            if (nr >= 0 && nr < Rows && nc >= 0 && nc < Columns && Cells[nr, nc].IsMine)
                            {
                                adjacentMines++;
                            }
                        }
                    }

                    Cells[r, c].AdjacentMines = adjacentMines;
                }
            }
        }
    }


}
