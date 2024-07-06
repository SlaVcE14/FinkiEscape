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
            if(e.KeyCode == Keys.Space && dialogPanel.Visible)
            {
                dialogPanel.Visible = false;
            }
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
            dialogPanel.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void game1Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                pcDialog.Visible = false;
                return;
            }

            //todo open game1
            finishedMessage(0);
            gameFinished[0] = true;

        }

        private void game2Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                pcDialog.Visible = false;
                return;
            }


            if (!isGameFinished(0))
            {
                return;
            }
            finishedMessage(1);
            gameFinished[1] = true;
        }

        private void game3Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                pcDialog.Visible = false;
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
                pcDialog.Visible = false;
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
                pcDialog.Visible = false;
                return;
            }

            if (!isGameFinished(3))
            {
                return;
            }
            finishedMessage(4);
            gameFinished[4] = true;
        }

        private void game6Btn_Click(object sender, EventArgs e)
        {
            if (pcDialog.Visible)
            {
                pcDialog.Visible = false;
                return;
            }

            if (!isGameFinished(4))
            {
                return;
            }
            finishedMessage(5);
            gameFinished[5] = true;
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
            //MessageBox.Show(string.Format(Properties.Resources.notFinishedGameMessage,gameNames[id]));

            string str = string.Format(Properties.Resources.notFinishedGameMessage, gameNames[id]);

            showDialog(str);

        }

        private void finishedMessage(int id)
        {
            //MessageBox.Show(string.Format(Properties.Resources.finishedGameMessage, gameNames[id]));


            string str = string.Format(Properties.Resources.finishedGameMessage, gameNames[id]);

            showDialog(str);
        }

        private void showDialog(string message)
        {

            dialogMsg.Text = message;
            pcDialog.Visible = true;

        }

        private void dialogPanel_MouseClick(object sender, MouseEventArgs e)
        {
            dialogPanel.Visible = false;
        }

        private void screen_MouseClick(object sender, MouseEventArgs e)
        {
            if(dialogPanel.Visible)
                dialogPanel.Visible = false;
        }

        private void dialogBtn_Click(object sender, EventArgs e)
        {
            pcDialog.Visible = false;
        }
    }
}
