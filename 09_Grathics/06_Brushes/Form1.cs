using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Brushes
{
    public partial class Form1 : Form
    {
        Random rand;
        Point p1 = new Point(10,10);
        Point p2 = new Point(20,20);
        Image img;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            InitializeComponent();
            rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(this.GetType(), "grass.jpeg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(rand.Next(2, 50), rand.Next(2, 50), 50, 50);
            Brush b = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            g.FillRectangle(b, r);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(rand.Next(2, 50), rand.Next(50, 200), 50, 50);
            Color c1 = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            Color c2 = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            Brush b = new HatchBrush(HatchStyle.DashedHorizontal, c1, c2);
            g.FillEllipse(b, r);
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(rand.Next(50, 100), rand.Next(100, 200), 150, 150);
            Color c1 = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            Color c2 = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            Brush b = new LinearGradientBrush(r, c1, c2, rand.Next(30, 70), true);
            g.FillPie(b, r, 90f, 90f);
            g.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Random r = new Random();
            //int x = r.Next(0, this.ClientSize.Width - 50);
            //int y = r.Next(0, this.ClientSize.Height - 50);

            //Rectangle rec = new Rectangle(x, y, 50, 50);
            //Graphics g = CreateGraphics();

            //TextureBrush br = new TextureBrush(Image.FromFile(@"D:\STEP\WinForm\WinForm\32ПР\09_Grathics\06_Brushes\grass.jpeg"));
            //g.FillRectangle(br, rec);
            //g.Dispose();
            //br.Dispose();

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            p2 = e.Location;
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            Pen p = new Pen(Color.Red, 5);
            p.DashStyle = DashStyle.DashDotDot;
            p.StartCap = LineCap.DiamondAnchor;
            p.EndCap = LineCap.Round;
            g.DrawLine(p, p1, p2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
               // Graphics g = CreateGraphics();
               // g.Clear(BackColor);

               // p2 = e.Location;
               // Pen p = new Pen(Color.Gray);
               // p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
               // Rectangle r = new Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);

               // Brush b = new LinearGradientBrush(r, Color.AliceBlue, Color.Gray, 50);
               // g.DrawRectangle(p, r);
               //// r.Inflate(-1, -1);
               // g.FillRectangle(b, r);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Graphics g = CreateGraphics();
            //g.Clear(BackColor);
            //Pen p = new Pen(Color.Gray);
            //p.DashStyle = DashStyle.Dash;
            //p.StartCap = LineCap.DiamondAnchor;
            //p.EndCap = LineCap.Round;

            //g.DrawLine(p, p1, p2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Point[] p = { new Point(240, 110),
                new Point(440, 110),
                new Point(510, 150),
                new Point(300, 150) };
            HatchBrush hBrush = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Violet, Color.White);
          //  TextureBrush tBrush = new TextureBrush(Image.FromFile(@"D:\STEP\Forms_3\Lesson2\BrushesPens\grass.jpeg"));
            g.FillPolygon(hBrush, p);
            Point[] p1 = { new Point(240, 110),
                new Point(300, 150),
                new Point(300, 360),
                new Point(240, 310) };
            g.FillPolygon(hBrush, p1);
        }
    }
}
