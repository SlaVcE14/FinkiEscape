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
    public partial class Keypad : UserControl
    {

        GameForm main;
        public string code = "123456";
        int codeLenght = 6;
        string codeEntered = "";


        public Keypad(GameForm main)
        {
            InitializeComponent();
            generateCode();

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
            
            main.stopGameTimer();

            endPanel.Visible = true;
            string time;


            TimeSpan t = TimeSpan.FromSeconds(main.timePlayed);
            
            if (main.timePlayed <= 60)
                time = string.Format("{0} секунди", main.timePlayed);
            else if (main.timePlayed <= 3600)
            {
                time = string.Format("{0} мин. и {1} секунди",
                t.Minutes,
                t.Seconds);
            }
            else
            {
                time = string.Format("{0} часа, {1} мин. и {2} секунди",
                t.Hours,
                t.Minutes,
                t.Seconds);
            }
           
            timeTxt.Text = String.Format("Играта ја завршивте за \n" + time);

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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            main.exitGame();
        }

        private void generateCode()
        {
			code = new Random().Next(100000,999999).ToString();
        }
    }
}
