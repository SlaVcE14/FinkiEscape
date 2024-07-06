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
    public partial class MemoryGame : Form
    {
        Random rdm = new Random();

        private bool isPass = false;

        List<string> images = new List<string>()
        {
            "b", "b", "!", "!", "Y", "Y", "j", "j", "o", "o", "%", "%", "L", "L", "N", "N"
        };

        Label firstImage, secondImage;

        public MemoryGame()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            AssignRandomImages();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstImage != null && secondImage != null)
            {
                return;
            }

            Label selectedLabel = sender as Label;

            if (selectedLabel == null)
            {
                return;
            }

            if (selectedLabel.ForeColor == Color.Black)
            {
                return;
            }

            if (firstImage == null)
            {
                firstImage = selectedLabel;
                firstImage.ForeColor = Color.Black;
                return;
            }

            secondImage = selectedLabel;
            secondImage.ForeColor = Color.Black;

            CheckWin();

            if (firstImage.Text == secondImage.Text)
            {
                firstImage = null;
                secondImage = null;
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstImage.ForeColor = firstImage.BackColor;
            secondImage.ForeColor = secondImage.BackColor;

            firstImage = null;
            secondImage = null;

        }

        private void CheckWin()
        {
            Label l;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                l = tableLayoutPanel1.Controls[i] as Label;
                if (l != null && l.ForeColor == l.BackColor)
                {
                    return;
                }
            }

            isPass = true;
            this.DialogResult = isPass ? DialogResult.OK : DialogResult.Cancel;
            Close();
        }

        private void AssignRandomImages()
        {
            Label l;
            int rdmNum;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    l = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }

                rdmNum = rdm.Next(0, images.Count);
                l.Text = images[rdmNum];

                images.RemoveAt(rdmNum);
            }
        }
    }
}
