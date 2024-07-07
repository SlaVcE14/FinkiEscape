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
    public partial class GameForm : Form
    {

        public Classroom classRoom;
        public BreakerBox breakerBox;
        public PCDisplay pcDisplay;
        public Exit exit;
        public Keypad keypad;

        public bool isPowerOn = false;
        public int timePlayed = 0;
        

        public GameForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            KeyPreview = true;

            classRoom = new Classroom(this);
            breakerBox = new BreakerBox(this);
            pcDisplay = new PCDisplay(this);
            exit = new Exit(this);
            keypad = new Keypad(this);

            Controls.Add(classRoom);
            Controls.Add(breakerBox);
            Controls.Add(pcDisplay);
            Controls.Add(exit);
            Controls.Add(keypad);


            classRoom.BackColor = Color.FromArgb(100, Color.Black);
           

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timePlayed++;
            
        }


        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaint(PaintEventArgs e) { }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)

            {
                DialogResult dialogResult = MessageBox.Show(Properties.Resources.exitMessage, Properties.Resources.exitMessageTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    exitGame();

                }
            }

            if (this.ActiveControl is Button && e.KeyCode == Keys.Space)
            {
                var button = this.ActiveControl;
                button.Enabled = false;
                Application.DoEvents();
                button.Enabled = true;
                button.Focus();
            }


            if (classRoom.Visible)
                classRoom.keyDown(e);
            if (pcDisplay.Visible)
                pcDisplay.keyDown(e);
            if (breakerBox.Visible)
                breakerBox.keyDown(e);
            if (exit.Visible)
                exit.keyDown(e);
            if (keypad.Visible)
                keypad.keyDown(e);
        }

        public void exitGame()
        {
            MainScene scene = new MainScene();
            Hide();
            scene.Show();
        }

        public void stopGameTimer()
        {
            gameTimer.Enabled = false;  
        }

    }
}
