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

        public bool isPowerOn = false;
        

        public GameForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            KeyPreview = true;

            classRoom = new Classroom(this);
            breakerBox = new BreakerBox(this);
            pcDisplay = new PCDisplay(this);

            Controls.Add(classRoom);
            Controls.Add(breakerBox);
            Controls.Add(pcDisplay);


            classRoom.BackColor = Color.FromArgb(100, Color.Black);
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(startMsgId < StringData.startGameDialogs.Count) 
            //{
            //    label1.Text = StringData.startGameDialogs[startMsgId];
            //    startMsgId++;
            //}
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
                    MainScene scene = new MainScene();
                    Hide();
                    scene.Show();
                    

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


        }

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
