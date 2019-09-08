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

namespace _09_Grathics
{
    public partial class Form1 : Form
    {
        SolidBrush brush;
        Pen pen1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
            pen1 = new Pen(Color.Pink, 4f);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle r = button1.Bounds;
          //  r.Inflate(-4, -4);

            Pen pen = new Pen(Color.Red, 4f);
            g.DrawRectangle(pen, 10, 10, this.Width-40, this.Height - 60);

         //   g.DrawEllipse(pen, 20, 20, 150, 100);

            SolidBrush solidBrush = new SolidBrush(Color.PowderBlue);
            //  g.FillEllipse(solidBrush, 22, 22, 146, 96);     
            g.FillRectangle(solidBrush, 20, 20, Width - 60, Height - 80);
            g.Dispose();
            solidBrush.Dispose();
         //   pen.Dispose();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            //---PAINT BUTTON----
           // e.Graphics()
            Graphics gBtn = e.Graphics;
            Pen pen = new Pen(Color.Red, 4f);
            Rectangle r = button1.ClientRectangle;
            r.Inflate(-2, -2);
            gBtn.DrawRectangle(pen, r);
            r.Inflate(-4, -4);
            gBtn.FillRectangle(brush, r);
          //  gBtn.Dispose();
           // pen.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Red);
            MessageBox.Show("Test");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.FromArgb(13,57,37));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.Black);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = button2.ClientRectangle;
            r.Inflate(-2, -2);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(r);
            button2.Region = new Region(path);

            Graphics gBtn = e.Graphics;
            gBtn.DrawEllipse(pen1, r);
            r.Inflate(-4, -4);
            gBtn.FillEllipse(brush, r);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {            
            pen1 = new Pen(Color.Red, 4f);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pen1 = new Pen(Color.Pink, 4f);
        }
    }
}
