using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiEscapa
{
    public partial class TicTacToe : Form
    {
        private Button[,] board;

        bool playerTurn;

        bool isPass = false;
        public TicTacToe()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeGame();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null && btn.Text == "")
            {
                if (playerTurn)
                {
                    btn.Text = "X";
                    if (CheckWin('X'))
                    {
                        isPass = true;
                        this.DialogResult = isPass ? DialogResult.OK : DialogResult.Cancel;
                        return;
                    }
                    playerTurn = false;
                    if (movesLeft(board))
                    {
                        enableButtons(false);
                        Cursor.Current = Cursors.WaitCursor;
                        ComputerMove();
                        enableButtons(true);
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        if (IsDraw())
                        {
                            InitializeGame();
                            return;
                        }
                    }

                }
            }
        }

        private void InitializeGame()
        {
            board = new Button[3, 3]
            {
                {btn1,btn2,btn3 },
                {btn4,btn5,btn6 },
                {btn7,btn8,btn9 }
            };

            playerTurn = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j].Text = "";
                }
            }

        }

        private void enableButtons(bool enable) 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j].Enabled = enable;
                }

            }
        }

        private bool CheckWin(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Text == player.ToString() && board[i, 1].Text == player.ToString() && board[i, 2].Text == player.ToString())
                    return true;
                if (board[0, i].Text == player.ToString() && board[1, i].Text == player.ToString() && board[2, i].Text == player.ToString())
                    return true;
            }
            if (board[0, 0].Text == player.ToString() && board[1, 1].Text == player.ToString() && board[2, 2].Text == player.ToString())
                return true;
            if (board[0, 2].Text == player.ToString() && board[1, 1].Text == player.ToString() && board[2, 0].Text == player.ToString())
                return true;

            return false;
        }

        private int Minimax(Button[,] board, int depth, bool isMaximizing)
        {
            if (CheckWin('O')) return 10 - depth;
            if (CheckWin('X')) return depth - 10;
            if (IsDraw()) return 0;

            if (movesLeft(board) == false)
            {
                return 0;
            }

            if (isMaximizing)
            {
                int bestScore = -1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j].Text == "")
                        {
                            board[i, j].Text = "O";
                            int score = Minimax(board, depth + 1, !isMaximizing);
                            bestScore = Math.Max(score, bestScore);
                            board[i, j].Text = "";
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = 1000;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j].Text == "")
                        {
                            board[i, j].Text = "X";
                            int score = Minimax(board, depth + 1, isMaximizing);
                            bestScore = Math.Min(score, bestScore);
                            board[i, j].Text = "";
                        }
                    }
                }
                return bestScore;
            }
        }

        private void ComputerMove()
        {

            int bestScore = -1000;
            int moveRow = -1;
            int moveCol = -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j].Text == "")
                    {
                        board[i, j].Text = "O";
                        int score = Minimax(board, 0, false);
                        board[i, j].Text = "";
                        if (score > bestScore)
                        {
                            moveRow = i;
                            moveCol = j;
                            bestScore = score;
                        }
                    }
                }
            }

            board[moveRow, moveCol].Text = "O";


            if (CheckWin('O'))
            {
                MessageBox.Show("Компјутерот те победи.Пробај повторно!","X/O",MessageBoxButtons.OK,MessageBoxIcon.Information);
                InitializeGame();
                return;
            }

            playerTurn = true;
        }

        private bool IsDraw()
        {
            foreach (Button btn in board)
            {
                if (btn.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private static bool movesLeft(Button[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j].Text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
