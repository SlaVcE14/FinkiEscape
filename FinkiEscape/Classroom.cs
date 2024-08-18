using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinkiEscape
{
    public partial class Classroom : UserControl
    {

        GameForm main;
        List<string> dialogs = null;


        public Classroom(GameForm main)
        {
            InitializeComponent();
            
            this.main = main;

            this.DoubleBuffered = true;

            //panel1.Parent = pictureBox1;
            dialogPanel.BackColor = Color.FromArgb(100, Color.Black);
            dialogs = new List<string>(StringData.startGameDialogs);
            Focus();
        }



        private void goToBreakerBox()
        {
            Visible = false;
            main.breakerBox.Visible = true;
        }

        private void goToPCDisplay()
        {
            if (!main.isPowerOn)
            {
                showPowerOffDialog();
                return;
            }

            Visible = false;
            main.pcDisplay.Visible = true;
        }

        private void goToExit()
        {
            Visible = false;
            main.exit.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goToBreakerBox();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            goToPCDisplay();
        }

        private void showPowerOffDialog()
        {
            dialogs = new List<string>(StringData.powerOffDialog);
            dialogPanel.Visible = true;
            nextDialog();
        }

        private void nextDialog()
        {
            if (dialogs.Count > 0)
            {
                dialogText.Text = dialogs[0];
                dialogs.RemoveAt(0);
                return;
            }

            dialogPanel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextDialog();
            dialogText.Visible = true;
            timer1.Enabled = false;
        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            nextDialog();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            goToBreakerBox();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            goToExit();
        }



        public void keyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (dialogPanel.Visible)
                {
                    nextDialog();
                }
            }
        }

        internal void showExitBtn()
        {
            exitBtn.Visible = true;
        }
    }
}
