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
    public partial class BreakerBox : UserControl
    {

        GameForm main;

        public BreakerBox(GameForm main)
        {
            InitializeComponent();
            this.main = main;
            Visible = false;

        }

        private void goToClassRoom()
        {
            Visible = false;
            main.classRoom.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goToClassRoom();
        }

        public void keyDown(KeyEventArgs e)
        {

        }

        private void BreakerBox_VisibleChanged(object sender, EventArgs e)
        {
            button1.Enabled = Visible;
        }

        private void powerSwitch_MouseClick(object sender, MouseEventArgs e)
        {

            if (main.isPowerOn)
                return;

            ConnectWires form = new ConnectWires();

            if(form.ShowDialog() == DialogResult.OK)
            {
                main.isPowerOn = true;
                BackgroundImage = Properties.Resources.powerOn;
            }


            //if(!main.isPowerOn)
            //{
            //    main.isPowerOn = true;
            //    BackgroundImage = Properties.Resources.powerOn;
            //}
            //else
            //{
            //    main.isPowerOn = false;
            //    BackgroundImage = Properties.Resources.powerOff;
            //}

        }
    }
}
