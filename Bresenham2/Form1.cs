using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bresenham2
{
    public partial class Form1 : Form
    {
        private List<Point> linePoints = new List<Point>();
        private int pixelSize = 5; // Her pikselin boyutu
        public Form1()
        {
            InitializeComponent();
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawBresenhamLine(e.Graphics);
        }
        private void DrawBresenhamLine(Graphics g)
        {
            if (linePoints.Count >= 2)
            {
                Point startPoint = linePoints[0];
                Point endPoint = linePoints[1];

                int x1 = startPoint.X;
                int y1 = startPoint.Y;
                int x2 = endPoint.X;
                int y2 = endPoint.Y;

                int dx = Math.Abs(x2 - x1);
                int dy = Math.Abs(y2 - y1);

                int sx = (x1 < x2) ? 1 : -1;
                int sy = (y1 < y2) ? 1 : -1;
                int err = dx - dy;

                while (true)
                {
                    DrawPixel(g, x1, y1);

                    if (x1 == x2 && y1 == y2)
                        break;

                    int e2 = 2 * err;

                    if (e2 > -dy)
                    {
                        err -= dy;
                        x1 += sx;
                    }

                    if (e2 < dx)
                    {
                        err += dx;
                        y1 += sy;
                    }
                }
            }
        }
        private void DrawPixel(Graphics g, int x, int y)
        {
            g.FillRectangle(Brushes.Black, x * pixelSize, y * pixelSize, pixelSize, pixelSize);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (linePoints.Count < 2)
            {
                linePoints.Add(new Point(e.X / pixelSize, e.Y / pixelSize));
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("İki noktadan fazlasını ekleyemezsiniz.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            linePoints.Clear();
            pictureBox1.Refresh();
        }
    }
}
