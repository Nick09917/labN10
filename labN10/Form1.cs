using System;
using System.Drawing;
using System.Windows.Forms;

namespace labN10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Рисование линий
            for (int i = 0; i < 50; i++)
                g.DrawLine(new Pen(Brushes.Black, 2), 10, 4 * i + 20, 200, 4 * i + 20);

            // Рисование прямоугольника
            g.DrawRectangle(Pens.Blue, 10, 250, 80, 50);

            // Закрашивание прямоугольника
            g.FillRectangle(Brushes.Green, 100, 250, 80, 50);

            // Рисование эллипса
            g.DrawEllipse(Pens.Red, 200, 250, 80, 50);

            // Закрашивание эллипса
            g.FillEllipse(Brushes.Yellow, 300, 250, 80, 50);

            // Рисование многоугольника
            Point[] polygonPoints = {
                new Point(420, 250),
                new Point(470, 230),
                new Point(520, 250),
                new Point(490, 300),
                new Point(450, 300)
            };
            g.DrawPolygon(Pens.Orange, polygonPoints);

            // Закрашивание многоугольника
            g.FillPolygon(Brushes.Purple, polygonPoints);
        }
    }
}