using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinkiEscapa
{
    public class Ball
    {
        public int Radius { get; set; } = 25;
        public Color Color { get; set; } = Color.Red;
        public Point Center { get; set; }

        public bool Saved = false;

        public bool marked = false;

        public Ball(Point center)
        {
            Center = center; 
        }

        public bool isColliding(Ball ball)
        {
            return Math.Sqrt(Math.Pow(Center.X - ball.Center.X, 2) + Math.Pow(Center.Y - ball.Center.Y, 2)) <= (Radius + ball.Radius);
        }

        public bool isHit(Point point)
        {
            return Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b,Center.X - Radius,Center.Y - Radius,2 * Radius,2 * Radius);
            b.Dispose();

            if (Saved)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();
            }
            if (marked)
            {
                b = new SolidBrush(Color.Black);
                g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
                b.Dispose();
            }

        }
    }
}
