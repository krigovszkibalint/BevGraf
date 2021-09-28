using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikaAlap
{
    public partial class Form1 : Form
    {
        Graphics g;
        PointF center;
        Pen grass = new Pen(Color.Green, 2f);
        Pen sun = new Pen(Color.Yellow, 3f);

        public Form1()
        {
            InitializeComponent();
            center = new PointF(canvas.Width / 2, canvas.Height / 2);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            //g.DrawLine(penCoordSys, 0, center.Y, canvas.Width, center.Y);
            //g.DrawLine(penCoordSys, center.X, 0, center.X, canvas.Height);

            //g.FillRectangle(Brushes.Yellow, 100, 100, 150, 350);
            //g.DrawRectangle(Pens.Black, 100, 100, 150, 350);
            //g.FillEllipse(new SolidBrush(Color.Green), 100, 100, 150, 350);
            //g.DrawEllipse(new Pen(Color.Red, 5f), 100, 100, 150, 350);

            PointF P = new PointF(0, 0);
            float r = 50;
            //g.DrawEllipse(Pens.Red, P.X - r, P.Y - r, 2 * r, 2 * r);

            //grass
            g.FillRectangle(new SolidBrush(Color.LimeGreen), P.X, P.Y, canvas.Width, canvas.Height);

            //sky
            g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), P.X, P.Y, canvas.Width, 400);


            g.FillRectangle(Brushes.Orange, 300, 200, 400, 200);
            g.DrawRectangle(new Pen(Color.DarkOrange, 3f), 300, 200, 400, 200);
            g.FillRectangle(Brushes.Orange, 150, 200, 150, 200);
            g.DrawRectangle(new Pen(Color.DarkOrange, 3f), 150, 200, 150, 200);

            g.FillPolygon(Brushes.OrangeRed, new Point[3] { new Point(225, 100), new Point(300, 200), new Point(150, 200) });
            g.DrawPolygon(new Pen(Color.Red, 3f), new Point[3] { new Point(225, 100), new Point(300, 200), new Point(150, 200) });

            g.FillPolygon(Brushes.OrangeRed, new Point[5] { new Point(225, 100), new Point(600, 100), new Point(650, 125), new Point(700, 200), new Point(300, 200) });
            g.DrawPolygon(new Pen(Color.Red, 3f), new Point[5] { new Point(225, 100), new Point(600, 100), new Point(650, 125), new Point(700, 200), new Point(300, 200) });

            g.FillRectangle(Brushes.Brown, 175, 250, 75, 150);
            g.DrawRectangle(new Pen(Color.SandyBrown, 3f), 175, 250, 75, 150);

            g.FillRectangle(Brushes.SkyBlue, 325, 250, 150, 100);
            g.DrawRectangle(new Pen(Color.DeepSkyBlue, 3f), 325, 250, 150, 100);
            g.FillRectangle(Brushes.SkyBlue, 525, 250, 150, 100);
            g.DrawRectangle(new Pen(Color.DeepSkyBlue, 3f), 525, 250, 150, 100);

            g.FillRectangle(Brushes.Chocolate, 750, 250, 50, 150);
            g.DrawRectangle(new Pen(Color.Brown, 3f), 750, 250, 50, 150);

            g.FillEllipse(new SolidBrush(Color.Green), 700, 150, 150, 200);
            g.DrawEllipse(new Pen(Color.DarkGreen, 3f), 700, 150, 150, 200);

            

            Random rnd = new Random();

            for (int i = 0; i < 150; i++)
            {
                g.DrawLine(sun, rnd.Next(0, 140), rnd.Next(0, 140), 2, rnd.Next(5,25));
            }

            g.FillEllipse(new SolidBrush(Color.Yellow), -100, -100, 200, 200);
            g.DrawEllipse(new Pen(Color.Orange, 3f), -100, -100, 200, 200);

            g.DrawEllipse(new Pen(Color.DeepSkyBlue, 65f), -75, -75, 250, 250);

            for (int i = 0; i < 100; i++)
            {
                g.FillEllipse(new SolidBrush(Color.DarkGreen), rnd.Next(700, 850), rnd.Next(145, 305), 25, 35);
                g.FillEllipse(new SolidBrush(Color.ForestGreen), rnd.Next(700, 850), rnd.Next(145, 305), 35, 25);
            }

            for (int i = 0; i < 5000; i++)
            {
                g.FillRectangle(Brushes.Green, rnd.Next(0,850), rnd.Next(390,500), 2, 25);
            }

            //P = new PointF(450, 200);
            //for (int i = 0; i < 256; i++)
            //    for (int j = 0; j < 256; j++)
            //        g.DrawRectangle(new Pen(Color.FromArgb(j, (i + j) % 256, 0)), P.X + i, P.Y + j, 0.5f, 0.5f);
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
