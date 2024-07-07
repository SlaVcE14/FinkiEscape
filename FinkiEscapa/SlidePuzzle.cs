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
    public partial class SlidePuzzle : Form
    {
        private bool isPass = false;
        private int count = 0;
        public SlidePuzzle()
        {
            InitializeComponent();
        }

        private void checkEmptySpot(Button btn1, Button btn2)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn1.Text;
                btn1.Text = "";
            }
        }

        private void checkWin()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15" && button16.Text == "")
            {
                isPass = true;
                this.DialogResult = isPass ? DialogResult.OK : DialogResult.Cancel;
                MessageBox.Show("Успешно ја решивте сложувалката.", "Сложувалка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            count++;
            lblCount.Text = $"Број на кликови: {count}";
        }

        private void ShuffleNumbers()
        {
            int[] array = new int[16];
            int i = 1, j, check;
            bool flag = false;

            while (i <= 15)
            {
                Random rdm = new Random();
                check = Convert.ToInt32((rdm.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (array[j] == check)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    array[i] = check;
                    i++;
                }
            }
            button1.Text = Convert.ToString(array[1]);
            button2.Text = Convert.ToString(array[2]);
            button3.Text = Convert.ToString(array[3]);
            button4.Text = Convert.ToString(array[4]);
            button5.Text = Convert.ToString(array[5]);
            button6.Text = Convert.ToString(array[6]);
            button7.Text = Convert.ToString(array[7]);
            button8.Text = Convert.ToString(array[8]);
            button9.Text = Convert.ToString(array[9]);
            button10.Text = Convert.ToString(array[10]);
            button11.Text = Convert.ToString(array[11]);
            button12.Text = Convert.ToString(array[12]);
            button13.Text = Convert.ToString(array[13]);
            button14.Text = Convert.ToString(array[14]);
            button15.Text = Convert.ToString(array[15]);
            button16.Text = "";
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
            isPass = true;
            this.DialogResult = isPass ? DialogResult.OK : DialogResult.Cancel;
            MessageBox.Show("Успешно ја решивте сложувалката.", "Сложувалка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void SlidePuzzle_Load(object sender, EventArgs e)
        {
            ShuffleNumbers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShuffleNumbers();
            count = 0;
            lblCount.Text = $"Број на кликови: {count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button1, button2);
            checkEmptySpot(button1, button5);
            checkWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button2, button1);
            checkEmptySpot(button2, button3);
            checkEmptySpot(button2, button6);
            checkWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button3, button2);
            checkEmptySpot(button3, button4);
            checkEmptySpot(button3, button7);
            checkWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button4, button3);
            checkEmptySpot(button4, button8);
            checkWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button5, button1);
            checkEmptySpot(button5, button6);
            checkEmptySpot(button5, button9);
            checkWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button6, button2);
            checkEmptySpot(button6, button5);
            checkEmptySpot(button6, button7);
            checkEmptySpot(button6, button10);
            checkWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button7, button3);
            checkEmptySpot(button7, button6);
            checkEmptySpot(button7, button8);
            checkEmptySpot(button7, button11);
            checkWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button8, button4);
            checkEmptySpot(button8, button7);
            checkEmptySpot(button8, button12);
            checkWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button9, button5);
            checkEmptySpot(button9, button10);
            checkEmptySpot(button9, button13);
            checkWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button10, button6);
            checkEmptySpot(button10, button9);
            checkEmptySpot(button10, button11);
            checkEmptySpot(button10, button14);
            checkWin();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button11, button7);
            checkEmptySpot(button11, button10);
            checkEmptySpot(button11, button12);
            checkEmptySpot(button11, button15);
            checkWin();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button12, button8);
            checkEmptySpot(button12, button11);
            checkEmptySpot(button12, button16);
            checkWin();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button13, button9);
            checkEmptySpot(button13, button14);
            checkWin();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button14, button10);
            checkEmptySpot(button14, button13);
            checkEmptySpot(button14, button15);
            checkWin();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button15, button11);
            checkEmptySpot(button15, button14);
            checkEmptySpot(button15, button16);
            checkWin();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            checkEmptySpot(button16, button12);
            checkEmptySpot(button16, button15);
            checkWin();
        }
    }
}
