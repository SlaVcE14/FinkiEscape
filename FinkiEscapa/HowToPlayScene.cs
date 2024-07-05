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
    public partial class HowToPlayScene : UserControl
    {

        MainScene main;

        public HowToPlayScene(MainScene main)
        {
            InitializeComponent();
            this.main = main;
            Visible = false;

        }

        private void goBack()
        {
            Visible = false;
            main.mainMenu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goBack();
        }
    }
}
