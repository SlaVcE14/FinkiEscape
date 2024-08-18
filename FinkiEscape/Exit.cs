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
    public partial class Exit : UserControl
    {

        GameForm main;
        


        public Exit(GameForm main)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.main = main;
            Visible = false;
        }

        private void goToClassRoom()
        {
            Visible = false;
            main.classRoom.Visible = true;
        }

        private void goToKeypad()
        {
            Visible = false;
            main.keypad.Visible = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToClassRoom();
        }

        internal void keyDown(KeyEventArgs e)
        {
            
        }

        private void keypadBtn_Click(object sender, EventArgs e)
        {
            goToKeypad();
        }
    }
}
