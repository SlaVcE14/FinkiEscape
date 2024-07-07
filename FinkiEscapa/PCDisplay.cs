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
    public partial class PCDisplay : UserControl
    {

        GameForm main;
        bool[] gameFinished = new bool[6];
        List<string> gameNames = new List<string>();
        bool allGamesFinished = false;


        public PCDisplay(GameForm main)
        {
            InitializeComponent();

            DoubleBuffered = true;

            this.main = main;
            Visible = false;
            init();

            //Debug mode 
            //------------------------------------
            //gameFinished[0] = true;
            //gameFinished[1] = true;
            //gameFinished[2] = true;
            //gameFinished[3] = true;
            //gameFinished[4] = true;
            //gameFinished[5] = true;
            //main.isPowerOn = true;
            //------------------------------------

        }

        private void goToClassroom()
        {
            Visible = false;
            main.classRoom.Visible = true;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToClassroom();
        }

        public void keyDown(KeyEventArgs e)
        {

        }

        private void PCDisplay_VisibleChanged(object sender, EventArgs e)
        {
            backBtb.Enabled = Visible;

            if (main.isPowerOn)
            {
                screen.Visible = true;
            }else
            {
                screen.Visible = false;
            }

        }


        private void init()
        {
            gameNames.Add(Properties.Resources.game1Name);
            gameNames.Add(Properties.Resources.game2Name);
            gameNames.Add(Properties.Resources.game3Name);
            gameNames.Add(Properties.Resources.game4Name);
            gameNames.Add(Properties.Resources.game5Name);
            gameNames.Add(Properties.Resources.game6Name);


            game1Lbl.Text = gameNames[0];
            game2Lbl.Text = gameNames[1];
            game3Lbl.Text = gameNames[2];
            game4Lbl.Text = gameNames[3];
            game5Lbl.Text = gameNames[4];
            game6Lbl.Text = gameNames[5];

            game1Btn.Image = Properties.Resources.mathTestIcon;
            game3Btn.Image = Properties.Resources.memotyIcon;
            game4Btn.Image = Properties.Resources.IQQuizIcon;
            game5Btn.Image = Properties.Resources.puzzleIcon;
        }

        private void game1Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }

            MathTest game = new MathTest();

            if (game.ShowDialog() == DialogResult.OK)
            {
                finishedMessage(0);
                gameFinished[0] = true;
            }

        }

        private void game2Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }


            if (!isGameFinished(0))
            {
                return;
            }
            
            TicTacToe game = new TicTacToe();

            if (game.ShowDialog() == DialogResult.OK)
            {
                finishedMessage(1);
                gameFinished[1] = true;
            }
        }

        private void game3Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }

            if (!isGameFinished(1))
            {
                return;
            }
            
            MemoryGame game = new MemoryGame();

            if (game.ShowDialog() == DialogResult.OK)
            {
                finishedMessage(2);
                gameFinished[2] = true;
            }
        }

        private void game4Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }


            if (!isGameFinished(2))
            {
                return;
            }

            IQQuiz quiz = new IQQuiz();

            if(quiz.ShowDialog() == DialogResult.OK)
            {
                finishedMessage(3);
                gameFinished[3] = true;
            }

        }

        private void game5Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }

            if (!isGameFinished(3))
            {
                return;
            }
            
            SlidePuzzle puzzle = new SlidePuzzle();
            if (puzzle.ShowDialog() == DialogResult.OK)
            {
                finishedMessage(4);
                gameFinished[4] = true;
            }
        }

        private void game6Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                return;
            }

            if (!isGameFinished(4))
            {
                return;
            }

            BallGame game = new BallGame();
            if (game.ShowDialog() == DialogResult.OK)
            {
                gameFinished[5] = true;
                codeMessage();
            }

            main.classRoom.showExitBtn();

        }

        private bool isGameFinished(int id)
        {
            if (!gameFinished[id])
            {
                notFinishedMessage(id);
                return false;
            }

            return true;
        }

        private void notFinishedMessage(int id)
        {
            string str = string.Format(Properties.Resources.notFinishedGameMessage, gameNames[id]);

            showDialog(str);

        }

        private void finishedMessage(int id)
        {
            string str = string.Format(Properties.Resources.finishedGameMessage, gameNames[id]);

            showDialog(str);
        }


        private void codeMessage()
        {
            string str = string.Format(Properties.Resources.codeMessage, main.keypad.code);
            allGamesFinished = true;
            showDialog(str);
        }

        private void showDialog(string message)
        {

            dialogMsg.Text = message;
            pcDialog.Visible = true;

        }

        private void dialogBtn_Click(object sender, EventArgs e)
        {

            if (allGamesFinished)
            {
                goToClassroom();
                return;
            }

            pcDialog.Visible = false;
        }
    }
}
