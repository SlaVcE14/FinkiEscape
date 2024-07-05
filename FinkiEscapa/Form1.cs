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
    public partial class MainScene : Form
    {

        public MainMenuScene mainMenu;
        public HowToPlayScene howToPlay;
        public CreditsScene credits;

        public MainScene()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.DoubleBuffered = true;
            mainMenu = new MainMenuScene(this);
            howToPlay = new HowToPlayScene(this);
            credits = new CreditsScene(this);


            Controls.Add(mainMenu);
            Controls.Add(howToPlay);
            Controls.Add(credits);

            KeyPreview = true;
        }

        private void MainScene_KeyDown(object sender, KeyEventArgs e)
        {
            mainMenu.Visible = true;
            howToPlay.Visible = false;
            credits.Visible = false;
        }

        private void MainScene_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
