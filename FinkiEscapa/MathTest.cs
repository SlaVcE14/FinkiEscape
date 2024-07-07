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
    public partial class MathTest : Form
    {

        int[] answers = new int[10];
        bool[] answered = new bool[10];

        public MathTest()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            
            init();
        }


        private void init()
        {

            z1Txt.Text = "20 + 5 =";
            z2Txt.Text = "18 – 9 =";
            z3Txt.Text = "5 * 5 =";
            z4Txt.Text = "20 / 2 =";
            z5Txt.Text = "2 * 2 * 2 =";
            z6Txt.Text = "25 + 3 - 7 =";
            z7Txt.Text = "x + 3 = 10, x =";
            z8Txt.Text = "23 - x = 20, x =";
            z9Txt.Text = "x * 1 = 1, x =";
            z10Txt.Text = "x / 4 = 4, x =";

            answers[0] = 25;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 10;
            answers[4] = 8;
            answers[5] = 21;
            answers[6] = 7;
            answers[7] = 3;
            answers[8] = 1;
            answers[9] = 16;

        }

        private void a_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = sender as TextBox;
            int id = int.Parse(input.Name.Substring(1, input.Name.Length - 1)) - 1;
            if (input.Text.Trim() == answers[id].ToString())
            {
                input.Enabled = false;
                input.BackColor = Color.LightGreen;
                answered[id] = true;

                if (isAllAnswered())
                {
                    DialogResult = DialogResult.OK;
                }

                
            }else
            {
                input.BackColor = Color.Red;
                e.Cancel = true;
            }
        }

        private bool isAllAnswered()
        {
            foreach (bool b in answered)
                if (!b)
                    return false;

            return true;
        }

        private void MathTest_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {


				((Control)sender).SelectNextControl(ActiveControl, true, true, true, true);

            }
        }

    }
}
