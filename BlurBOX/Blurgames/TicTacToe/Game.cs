using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlurBOX.Blurgames.TicTacToe
{
    public class Game
    {
        public string[,] Board { get; private set; }
        public string CurrentPlayer { get; private set; }

        public Game()
        {
            Board = new string[3, 3];
            CurrentPlayer = "X"; // İlk oyuncu "X"
        }

        public void MakeMove(int row, int col)
        {
            if (string.IsNullOrEmpty(Board[row, col]))
            {
                Board[row, col] = CurrentPlayer;
                SwitchPlayer();
            }
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = (CurrentPlayer == "X") ? "O" : "X";
        }

        public bool CheckWinner(out string winner)
        {
            winner = null; // Başlangıçta kazanan yok

            for (int i = 0; i < 3; i++)
            {
                // Satır kontrolü
                if (Board[i, 0] != null && Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2])
                    winner = Board[i, 0];

                // Sütun kontrolü
                if (Board[0, i] != null && Board[0, i] == Board[1, i] && Board[1, i] == Board[2, i])
                    winner = Board[0, i];
            }

            // Çapraz kontrolü
            if (Board[0, 0] != null && Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2])
                winner = Board[0, 0];
            if (Board[0, 2] != null && Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0])
                winner = Board[0, 2];

            return winner != null;
        }


        public bool IsDraw()
        {
            // Beraberlik kontrolü
            foreach (var cell in Board)
            {
                if (string.IsNullOrEmpty(cell))
                    return false;
            }
            return true;
        }
    }

}
