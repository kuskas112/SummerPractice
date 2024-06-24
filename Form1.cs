using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Diagnostics;

namespace SummerPractice
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point center;
        int scale = 20;
        double gap = 0.5;
        public Form1()
        {
            InitializeComponent();
        }

        public void drawXLine()
        {
            Pen pen; 
            int count = (center.X) / scale;
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    pen = Pens.Black;
                }
                else
                {
                    pen = Pens.Red;
                }

                g.DrawLine(pen, center.X + scale * i, center.Y, center.X + scale * (i+1), center.Y);
                g.DrawLine(pen, center.X + scale * -i, center.Y, center.X + scale * (-i-1), center.Y);
            }
        }

        public void drawYLine()
        {
            Pen pen;
            int count = (center.Y) / scale;
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    pen = Pens.Black;
                }
                else
                {
                    pen = Pens.Red;
                }

                g.DrawLine(pen, center.X, center.Y + scale * i, center.X, center.Y + scale * (i+1));
                g.DrawLine(pen, center.X, center.Y + scale * -i, center.X, center.Y + scale * (-i-1));
            }
        }

        private List<Point> calculateFunction()
        {
            List<Point> points = new List<Point>();
            string func = input.Text;
            int count = center.X / scale;
            for (double x = -count; x <= count; x += gap)
            {
                string expr = func.Replace("x", "(" + x.ToString() + ")");
                expr = expr.Replace(",", ".");
                double result = 0;
                try
                {
                    result = Convert.ToDouble(new DataTable().Compute(expr, ""));
                }
                catch (DivideByZeroException ex){
                    result = double.NegativeInfinity;
                }
                points.Add(new Point(center.X + (int)(x * scale), center.Y - (int)(result * scale)));
            }
            return points;
        }

        private void showResult()
        {
            List<Point> points = calculateFunction();
            int cnt = 0;
            foreach (var point in points)
            {
                cnt ++;
                if (point.Y < 0)
                {
                    continue;
                }
                drawPoint(point);
            }

            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].Y < 0 || points[i-1].Y < 0)
                {
                    continue;
                }
                g.DrawLine(Pens.Aqua, points[i - 1], points[i]);
            }
        }

        private void drawPoint(Point point)
        {
            if (point.Y < 0) { return; }
            g.FillEllipse(Brushes.Red, point.X-2, point.Y-2, 4, 4);
        }

        private void paintButton_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(DefaultBackColor);
            center = new Point(this.Width / 2, this.Height / 2);
            drawXLine();
            drawYLine();
            showResult();
        }
    }
}
