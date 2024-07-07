using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiEscapa
{
    public class BallScene
    {
        public List<Ball> Balls { get; set; }
        public int Points { get; set; } = 0;
        public Random rdm { get; set; }
        public Ball MarkedForDeletion { get; set; }

        public BallScene()
        {
            Balls = new List<Ball>();
            rdm = new Random();
        }

        public void AddBall(Ball ball)
        {
            Balls.Add(ball);
        }

        public void Draw(Graphics g)
        {
            foreach (Ball b in Balls)
            {
                b.Draw(g);
            }
        }

        public void Click(Point location)
        {
            foreach(Ball b in Balls)
            {
                if (b.isHit(location) && !b.marked)
                {
                    b.Saved = true;
                    Points++;
                    return;
                }
            }
        }

        public bool GameOver()
        {
            foreach(Ball b in Balls)
            {
                if (!b.Saved)
                {
                    return false;
                }
            }
            return true;
        }

        public void PickRandomBallForDeletions()
        {
            if (MarkedForDeletion != null)
            {
                Balls.Remove(MarkedForDeletion);
            }

            if (Balls.Count > 0 && !GameOver())
            {
                List<int> indices = new List<int>();

                for (int i = 0; i < Balls.Count; i++)
                {
                    if (!Balls[i].Saved && !Balls[i].marked)
                    {
                        indices.Add(i);
                    }
                }

                int rdmIdx = indices[rdm.Next(0, indices.Count)];

                Ball selected = Balls[rdmIdx];

                selected.marked = true;
                MarkedForDeletion = selected;
            }
        }
    }
}
