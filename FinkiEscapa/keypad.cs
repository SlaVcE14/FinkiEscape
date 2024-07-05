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
    public partial class Keypad : UserControl
    {

        GameForm main;

        public Keypad(GameForm main)
        {
            InitializeComponent();
            this.main = main;
            Visible = false;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            main.exit.Visible = true;
        }

        internal void keyDown(KeyEventArgs e)
        {

        }

    }
}
