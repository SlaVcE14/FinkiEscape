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
    public partial class ConnectWires : Form
    {
        //Start
        static Rectangle r1Area = new Rectangle(118, 93, 15, 15);
        static Rectangle b1Area = new Rectangle(118, 168, 15, 15);
        static Rectangle y1Area = new Rectangle(118, 243, 15, 15);
        //End
        static Rectangle b2Area = new Rectangle(466, 93, 15, 15);
        static Rectangle y2Area = new Rectangle(466, 168, 15, 15);
        static Rectangle r2Area = new Rectangle(466, 243, 15, 15);

        List<Rectangle> rectangles = new List<Rectangle>{ r1Area, b1Area, y1Area, r2Area, b2Area, y2Area};

        Color[] colors = { Color.FromArgb(224, 27, 34), Color.FromArgb(0, 114, 188), Color.FromArgb(225, 199, 26) };


        bool[] drawnLine = new bool[3];
        int currentIndex = -1;
        Point[] points = new Point[2];
        List<Point[]> lines = new List<Point[]>();
        
        bool connectingWiresStarted;

        public ConnectWires()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            DoubleBuffered = true;
            init();
        }

        private void ConnectWires_Paint(object sender, PaintEventArgs e)
        {

            if (drawnLine[0])
            {
                e.Graphics.DrawLine(new Pen(colors[0], 15), lines[0][0], lines[0][1]);
            }
            if (drawnLine[1])
            {
                e.Graphics.DrawLine(new Pen(colors[1], 15), lines[1][0], lines[1][1]);
            }
            if (drawnLine[2])
            {
                e.Graphics.DrawLine(new Pen(colors[2], 15), lines[2][0], lines[2][1]);
            }

            if (connectingWiresStarted)
                e.Graphics.DrawLine(new Pen(colors[currentIndex],15), points[0], points[1]);

            Invalidate();

        }

        private void ConnectWires_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rect = isOnTarget(e.Location);

            if (!connectingWiresStarted && isStartPos(rect))
            {
                currentIndex = rectangles.IndexOf(rect);

                if (drawnLine[currentIndex])
                    return;

                connectingWiresStarted = true;

                points[0] = rect.Location;
                points[0].Offset(7, 7);

                return;
            }

            if (isEndPos(rect) && rect == rectangles[currentIndex + 3])
            {
                drawnLine[currentIndex] = true;
                connectingWiresStarted = false;
                isFinished();
            }

        }

        private void ConnectWires_MouseMove(object sender, MouseEventArgs e)
        {

            if (isOnTarget(e.Location) != Rectangle.Empty)
            {
                Cursor.Current = Cursors.Hand;
                
            }else Cursor.Current = Cursors.Default;
            
            points[1] = e.Location;

        }

        private bool isStartPos(Rectangle rect)
        {
            if (rect == r1Area || rect == b1Area || rect == y1Area)
                return true;

            return false;
        }

        private bool isEndPos(Rectangle rect)
        {
            if (rect == r2Area || rect == b2Area || rect == y2Area)
                return true;

            return false;
        }

        private Rectangle isOnTarget(Point location)
        {

            foreach (Rectangle r in rectangles)
            {
                if (r.Contains(location))
                {
                    return r;
                }
            }


            return Rectangle.Empty;
        }

        private void init()
        {
            lines.Add(new Point[] { r1Area.Location, r2Area.Location });
            lines.Add(new Point[] { b1Area.Location, b2Area.Location });
            lines.Add(new Point[] { y1Area.Location, y2Area.Location });

            lines[0][0].Offset(7, 7);
            lines[0][1].Offset(7, 7);

            lines[1][0].Offset(7, 7);
            lines[1][1].Offset(7, 7);

            lines[2][0].Offset(7, 7);
            lines[2][1].Offset(7, 7);

        }

        private void isFinished()
        {
            if(drawnLine[0] && drawnLine[1] && drawnLine[2])
            {
                DialogResult = DialogResult.OK;
            }
        }


    }
}
