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
        public string code = "1234";
        int codeLenght = 4;
        string codeEntered = "";


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

        private void btn_Click(object sender, EventArgs e)
        {
            string name = (sender as PictureBox).Name;

            if(name == "btnDel")
            {
                if(codeEntered.Length > 0)
                {
                    codeEntered = codeEntered.Substring(0, codeEntered.Length - 1);
                    updateDisplay();
                }
                return;

            }

            codeEntered += name.Substring(3,1);
            updateDisplay();

            if (codeEntered.Length == codeLenght)
                checkCode();

        }

        private void checkCode()
        {
            if (codeEntered == code)
                validCodeEntered();
            else invalidCodeEntered();
                
        }


        private void validCodeEntered()
        {
            MessageBox.Show("Code is valid");
        }

        private void invalidCodeEntered()
        {
            MessageBox.Show("Code is invalid");
            codeEntered = "";
            updateDisplay();
        }

        private void updateDisplay()
        {
            displayTxt.Text = codeEntered;
        }
    }
}
