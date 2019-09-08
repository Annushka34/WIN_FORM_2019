using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GrathicsImg
{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        bool isInRect = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rectangle = new Rectangle(10, 10, 150, 50);

            Image img = new Bitmap(this.GetType(), "1.png");
         

            MyButton b1 = new MyButton("Gradient rectangle");
            b1.SetBounds(80, this.Height - 120, 100, 50);
            Controls.Add(b1);
            b1.Click += B1_Click;

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
           
            Pen p = new Pen(Color.Pink, 2);
            Brush b = new LinearGradientBrush(rectangle, Color.AliceBlue, Color.Pink, 0.3f);
            g.DrawRectangle(p, rectangle);
            rectangle.Inflate(-2, -2);
            g.FillRectangle(b, rectangle);
            g.Dispose();
            p.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectangle != null)
            {
                if (rectangle.Contains(e.Location) && !isInRect)
                {
                    Graphics g = CreateGraphics();
                    Pen p = new Pen(Color.Blue, 2);
                    Brush b = new LinearGradientBrush(rectangle, Color.Pink, Color.Blue, 0.6f);
                    g.DrawRectangle(p, rectangle);
                    rectangle.Inflate(-2, -2);
                    g.FillRectangle(b, rectangle);
                    g.Dispose();
                    isInRect = !isInRect;
                }              
             }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rectangle != null)
            {
                if (rectangle.Contains(e.Location))
                {
                    Graphics g = CreateGraphics();
                    Pen p = new Pen(Color.Blue, 2);
                    Brush b = new LinearGradientBrush(rectangle, Color.Pink, Color.Blue, LinearGradientMode.Vertical);
                    g.DrawRectangle(p, rectangle);
                    rectangle.Inflate(-2, -2);
                    g.FillRectangle(b, rectangle);
                    g.Dispose();
                    isInRect = !isInRect;
                }
            }
        }
    }

    public class MyButton : Button
    {
        public MyButton(string text)
        {
            this.Text = text;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle r = e.ClipRectangle;
            r.Inflate(-5, -5);
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(new LinearGradientBrush(r, Color.Red, Color.Black, 0.5f), 5), r);
            r.Inflate(-5, -5);
            g.FillRectangle(new LinearGradientBrush(r, Color.AliceBlue, Color.AntiqueWhite, 0.5f), r);
        }
    } 
}
