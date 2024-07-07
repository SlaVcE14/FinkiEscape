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
    public partial class BallGame : Form
    {
        private BallScene scene;

        private Random random;

        bool isPass = false;
        public BallGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            scene = new BallScene();
            random = new Random();
        }

        private void BallGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scene.Click(e.Location);
                
            }
            Invalidate();
        }

        private void BallGame_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void SpawnBalls(int count)
        {
            int max = 100;
            int padding = 100;
            for (int i = 0; i < count; i++)
            {
                bool collision;
                int attempts = 0;
                do
                {
                    Point center = new Point(
                    random.Next(padding, Width - padding),
                    random.Next(padding, Height - padding));

                    Ball newBall = new Ball(center);
                    collision = false;

                    foreach (Ball b in scene.Balls)
                    {
                        if (newBall.isColliding(b))
                        {
                            collision = true; break;
                        }
                    }

                    if (!collision)
                    {
                        scene.AddBall(newBall);
                        break;
                    }
                    attempts++;
                }while (attempts < max && collision);
            }
            Invalidate();
        }

        private void BallGame_Load(object sender, EventArgs e)
        {
            SpawnBalls(10);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.PickRandomBallForDeletions();


            if (scene.GameOver())
            {
                scene.PickRandomBallForDeletions();
                Invalidate();
                timer1.Stop();
                toolStripStatusLabel1.Text = $"Поени: {scene.Points}";

                if (scene.Points >= 5)
                {
                    MessageBox.Show("Успеа да освоиш 5 или повеќе поени.", "Кругови", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isPass = true;
                    this.DialogResult = isPass ? DialogResult.OK : DialogResult.Cancel;
                    Close();
                }
                else
                {
                    MessageBox.Show("Не успеа да освоиш повеќе од 5 поени.Пробај повторно.", "Кругови", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    scene = new BallScene();
                    toolStripStatusLabel1.Text = $"Поени: 0";
                    SpawnBalls(10);
                    timer1.Start();
                }
            }

            

            Invalidate();
        }

        
    }
}
