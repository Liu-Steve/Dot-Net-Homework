using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        private int n = 10;
        private int leng = 100;
        private double per1 = 0.5;
        private double per2 = 0.5;
        private int th1 = 30;
        private int th2 = 30;
        private Color pen = Color.FromArgb(0xFF, 0xFF, 0xFF);
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            graphics = panelTree.CreateGraphics();
        }

        private void trackNBar_Scroll(object sender, EventArgs e)
        {
            n = trackNBar.Value;
            labelNValue.Text = n.ToString();
        }

        private void trackLengBar_Scroll(object sender, EventArgs e)
        {
            leng = trackLengBar.Value;
            labelLengValue.Text = leng.ToString();
        }

        private void trackPer1Bar_Scroll(object sender, EventArgs e)
        {
            per1 = trackPer1Bar.Value / 100.0;
            labelPer1Value.Text = per1.ToString();
        }

        private void trackPer2Bar_Scroll(object sender, EventArgs e)
        {
            per2 = trackPer2Bar.Value / 100.0;
            labelPer2Value.Text = per2.ToString();
        }

        private void trackTh1Bar_Scroll(object sender, EventArgs e)
        {
            th1 = trackTh1Bar.Value;
            labelTh1Value.Text = th1.ToString();
        }

        private void trackTh2Bar_Scroll(object sender, EventArgs e)
        {
            th2 = trackTh2Bar.Value;
            labelTh2Value.Text = th2.ToString();
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                pen = colorDia.Color;
                labelPenShow.BackColor = pen;
                labelPenValue.Text = "#" + 
                    pen.R.ToString("X").PadLeft(2, '0') + 
                    pen.G.ToString("X").PadLeft(2, '0') + 
                    pen.B.ToString("X").PadLeft(2, '0');
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            graphics.Clear(splitContainer1.Panel1.BackColor);
            drawCayleyTree(n, panelTree.Size.Width / 2, 
                panelTree.Size.Height - 50, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                new Pen(pen),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
